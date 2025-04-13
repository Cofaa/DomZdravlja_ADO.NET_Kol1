using DomZdravlha.Shared;
using DomZdravlja.Business;
using DomZdravlja.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DomZdravlja.UI
{
    public partial class FrmMainMasterDetail : Form
    {
        private SluzbaManager _sluzbaManager = new SluzbaManager();
        private IzvestajManager _izvestajManager = new IzvestajManager();

        private List<SluzbaDTO> _sluzbe;
        private List<IzvestajDTO> _izvestaji;
        public FrmMainMasterDetail()
        {
            InitializeComponent();
        }

        private void FrmMainMasterDetail_load(object sender, EventArgs e)
        {
            MessageBox.Show("Pozvan je Load!");
            UcitajSluzbe();
        }

        private void UcitajSluzbe()
        {
           var _sluzbe = _sluzbaManager.GetAllSluzba();
            cmbSluzba.DataSource = _sluzbe;
            cmbSluzba.DisplayMember = "NazivSluzbe";
            cmbSluzba.ValueMember = "SluzbaID";

            if (_sluzbe.Count > 0)
            {
                cmbSluzba.SelectedIndex = 0;
                PrikaziSluzbu(_sluzbe[0]);
                UcitajIzvestaje(_sluzbe[0].SluzbaID);
            }
        }

        private void cmbSluzba_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sluzbaDTO = cmbSluzba.SelectedItem as SluzbaDTO;
            if(sluzbaDTO != null)
            {
                PrikaziSluzbu(sluzbaDTO);
                UcitajIzvestaje(sluzbaDTO.SluzbaID);
            }
        }

        private void PrikaziSluzbu(SluzbaDTO s)
        {
            txtOpisSluzbe.Text = s.OpisSluzbe;
            dtpDatumOsnivanja.Value = s.DatumOsnivanja;
        }

        private void UcitajIzvestaje(int sluzbaID)
        {
            _izvestaji = _izvestajManager.GetBySluzbaID(sluzbaID);
            dgvIzvestaji.DataSource = _izvestaji;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Novi_Click(object sender, EventArgs e)
        {
            var sluzbaDTO = cmbSluzba.SelectedItem as SluzbaDTO;
            if (sluzbaDTO == null) return;

            // Otvaramo formu za unos novog Izvestaja
            var frm = new FrmIzvestajEdit(sluzbaDTO.SluzbaID);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Ponovo učitavamo izveštaje
                UcitajIzvestaje(sluzbaDTO.SluzbaID);
            }

        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            if (dgvIzvestaji.CurrentRow == null) return;

            var izvestajDTO = dgvIzvestaji.CurrentRow.DataBoundItem as IzvestajDTO;
            if (izvestajDTO == null) return;

            var frm = new FrmIzvestajEdit(izvestajDTO);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // Ponovo učitavamo
                var sluzbaDTO = cmbSluzba.SelectedItem as SluzbaDTO;
                UcitajIzvestaje(sluzbaDTO.SluzbaID);
            }

        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            if(dgvIzvestaji.CurrentRow == null) { return; }

            var izvestajDTO = dgvIzvestaji.CurrentRow.DataBoundItem as IzvestajDTO;
            if (izvestajDTO == null) { return; }

            var dr = MessageBox.Show($"Da li ste sigurni da zelite da obristete izvestaj sa ID = {izvestajDTO.IzvestajID}?", "Brisanje", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                _izvestajManager.Delete(izvestajDTO.IzvestajID);

                //Refresh

                var sluzbaDTO = cmbSluzba.SelectedItem as SluzbaDTO ;
                UcitajIzvestaje(sluzbaDTO.SluzbaID);
            }
        }

        private void btnXmlExport_Click(object sender, EventArgs e)
        {
            //Kreiramo DataSet

            try
            {
                var ds = new DataSet("DomZdravljaDS");

                //Tabela Sluzba
                var dtSluzba = new DataTable("tblSluzba");
                dtSluzba.Columns.Add("SluzbaID", typeof(int));
                dtSluzba.Columns.Add("NazivSluzbe", typeof(string));
                dtSluzba.Columns.Add("OpisSluzbe", typeof(string));
                dtSluzba.Columns.Add("DatumOsnivanja", typeof(DateTime));
                ds.Tables.Add(dtSluzba);

                //Tabela Izvestaj
                var dtIzvestaj = new DataTable("tblIzvestah");
                dtIzvestaj.Columns.Add("IzvestajID", typeof(int));
                dtIzvestaj.Columns.Add("SluzbaID", typeof(int));
                dtIzvestaj.Columns.Add("NazivIzvestaja", typeof(string));
                dtIzvestaj.Columns.Add("BrojPacijenata", typeof(int));
                dtIzvestaj.Columns.Add("DatumKreiranja", typeof(DateTime));
                ds.Tables.Add(dtIzvestaj);

                //Ucitavamo sve sluzbe i sve izvestaje da popnimo DataTables
                var sveSluzbe = _sluzbaManager.GetAllSluzba();
                foreach(var s in sveSluzbe)
                {
                    dtSluzba.Rows.Add(s.SluzbaID, s.NazivSluzbe, s.OpisSluzbe, s.DatumOsnivanja);
                }

                //Ucitavamo sve Izvestaje
                foreach(var s in sveSluzbe)
                {
                    var izvestaji = _izvestajManager.GetBySluzbaID(s.SluzbaID);
                    foreach(var i in izvestaji)
                    {
                        dtIzvestaj.Rows.Add(i.IzvestajID, i.SluzbaID, i.NazivIzvestaja, i.BrojPacijenata, i.DatumKreiranja);
                    }
                }

                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ds.WriteXmlSchema(Path.Combine(desktop, "DomZdravlja_schema.xml"));
                ds.WriteXmlSchema(Path.Combine(desktop, "DomZdravlja_data.xml"));

                MessageBox.Show("Export u XML uspesan!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greska prilikom exporta! " + ex.Message);
            }
        }

        private void dgvIzvestaji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

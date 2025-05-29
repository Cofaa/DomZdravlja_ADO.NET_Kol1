using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomZdravlja.DataAccess;

namespace DomZdravlja.UI
{
    public partial class FrmOuterJoin : Form
    {
        public DomZdravljaDBDataContext _db = new DomZdravljaDBDataContext();
        public FrmOuterJoin()
        {
            InitializeComponent();
        }


        

        private void FrmOuterJoin_Load(object sender, EventArgs e)
        {

            UcitajOuterJoinQuery();
            UcitajOuterJoinMethod();
        }

        private void UcitajOuterJoinQuery()
        {
            var podaci = (from s in _db.tblSluzbas
                          join z in _db.Zaposlenis on s.SluzbaID equals z.SluzbaId into grupa
                          from z in grupa.DefaultIfEmpty()
                          select new
                          {
                              Sluzba = s.NazivSluzbe,
                              Zaposleni = z,
                          }).ToList();

            var transformedData = podaci.Select(p => new
            {
                p.Sluzba,
                Zaposleni = p.Zaposleni != null ? p.Zaposleni.Ime + " " + p.Zaposleni.Prezime : "Nema zaposlenih",
                DatumZaposlenja = p.Zaposleni != null ? p.Zaposleni.DatumZaposlenja.ToShortDateString() : ""
            }).ToList();

            dgvLinqJoin.DataSource = transformedData;
        }

        private void UcitajOuterJoinMethod()
        {
            // Učitaj sve sluzbe i zaposlene
            var sluzbe = _db.tblSluzbas.ToList();
            var zaposleni = _db.Zaposlenis.ToList();

            // Koristimo GroupJoin i SelectMany za kreiranje outer join-a
            var rezultat = sluzbe
                .GroupJoin(zaposleni,
                    s => s.SluzbaID,
                    z => z.SluzbaId,
                    (s, Zaposleni) => new { s, Zaposleni })
                .SelectMany(
                    x => x.Zaposleni.DefaultIfEmpty(),
                    (x, z) => new
                    {
                        Sluzba = x.s.NazivSluzbe,
                        Zaposleni = z != null ? z.Ime + " " + z.Prezime : "Nema zaposlenih",
                        DatumZaposlenja = z != null ? z.DatumZaposlenja.ToShortDateString() : ""
                    })
                .ToList();
                dgvMethodJoin.DataSource = rezultat;
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

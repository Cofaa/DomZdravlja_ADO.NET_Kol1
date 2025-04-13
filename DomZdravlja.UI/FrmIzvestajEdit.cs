using DomZdravlha.Shared;
using DomZdravlja.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomZdravlja.UI
{
        public partial class FrmIzvestajEdit : Form
        {
            private IzvestajManager _izvestajManager = new IzvestajManager();

            private bool _isEdit = false;
            private IzvestajDTO _editingIzvestaj;
            private int _sluzbaID;

            // Konstruktor za novi izveštaj
            public FrmIzvestajEdit(int sluzbaID)
            {
                InitializeComponent();
                _sluzbaID = sluzbaID;
                _isEdit = false;
            }

            // Konstruktor za izmenu postojećeg
            public FrmIzvestajEdit(IzvestajDTO izvestaj)
            {
                InitializeComponent();
                _editingIzvestaj = izvestaj;
                _sluzbaID = izvestaj.SluzbaID;
                _isEdit = true;
            }

            private void FrmIzvestajEdit_Load(object sender, EventArgs e)
            {
                if (_isEdit && _editingIzvestaj != null)
                {
                    txtNazivIzvestaja.Text = _editingIzvestaj.NazivIzvestaja;
                    txtBrojPacijenata.Text = _editingIzvestaj.BrojPacijenata.ToString();
                    dtpDatumKreiranja.Value = _editingIzvestaj.DatumKreiranja;

                    lblSluzbaID.Text = "SluzbaID: " + _editingIzvestaj.SluzbaID;
                }
                else
                {
                    // novi
                    lblSluzbaID.Text = "SluzbaID: " + _sluzbaID;
                }
            }

            private void btnSacuvaj_Click(object sender, EventArgs e)
            {
                // Osnovna validacija
                if (string.IsNullOrWhiteSpace(txtNazivIzvestaja.Text))
                {
                    MessageBox.Show("Naziv izveštaja je obavezan!");
                    return;
                }

                int brojPac;
                if (!int.TryParse(txtBrojPacijenata.Text, out brojPac))
                {
                    MessageBox.Show("Neispravan unos za broj pacijenata!");
                    return;
                }

                if (_isEdit)
                {
                    // Izmena
                    _editingIzvestaj.NazivIzvestaja = txtNazivIzvestaja.Text;
                    _editingIzvestaj.BrojPacijenata = brojPac;
                    _editingIzvestaj.DatumKreiranja = dtpDatumKreiranja.Value;

                    try
                    {
                        _izvestajManager.Update(_editingIzvestaj);
                        MessageBox.Show("Uspešno izmenjeno!");
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška prilikom izmene: " + ex.Message);
                    }
                }
                else
                {
                    // Novi
                    var novi = new IzvestajDTO
                    {
                        SluzbaID = _sluzbaID,
                        NazivIzvestaja = txtNazivIzvestaja.Text,
                        BrojPacijenata = brojPac,
                        DatumKreiranja = dtpDatumKreiranja.Value
                    };

                    try
                    {
                        _izvestajManager.Insert(novi);
                        MessageBox.Show("Uspešno dodat novi izveštaj!");
                        this.DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Greška prilikom dodavanja: " + ex.Message);
                    }
                }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

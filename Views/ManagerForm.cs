using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Winform_Mobil.Models;

namespace Winform_Mobil.Views
{
    public partial class ManagerForm : Form
    {
        private Dashboard _dashboard;
        private Mobil _mobilAkanDiUpdate;

        public ManagerForm()
        {
            InitializeComponent();
            cbKondisi.Items.AddRange(new string[] { "Baik", "Rusak Ringan", "Rusak Berat" });
            cbKondisi.SelectedIndex = 0;

            cbWarna.Items.AddRange(new string[] { "Merah", "Biru", "Hijau", "Hitam", "Putih" });
            cbWarna.SelectedIndex = 0;
        }

        public ManagerForm(Dashboard dashboard, Mobil mobil) : this()
        {
            _dashboard = dashboard;
            _mobilAkanDiUpdate = mobil;
            textMerk.Text = mobil.Merk;
            textTipe.Text = mobil.Tipe;
            textTahun.Text = mobil.Tahun.ToString();
            cbWarna.SelectedItem = mobil.Warna;
            textKapasitasMesin.Text = mobil.KapasitasMesin.ToString();
            textJenisBahanBakar.Text = mobil.JenisBahanBakar;
            textNopol.Text = mobil.NomorPolisi;
            cbKondisi.SelectedItem = mobil.Kondisi.ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (_mobilAkanDiUpdate != null)
            {
                _mobilAkanDiUpdate.Merk = textMerk.Text;
                _mobilAkanDiUpdate.Tipe = textTipe.Text;
                _mobilAkanDiUpdate.Tahun = int.Parse(textTahun.Text);
                _mobilAkanDiUpdate.Warna = cbWarna.SelectedItem.ToString();
                _mobilAkanDiUpdate.KapasitasMesin = int.Parse(textKapasitasMesin.Text);
                _mobilAkanDiUpdate.JenisBahanBakar = textJenisBahanBakar.Text;
                _mobilAkanDiUpdate.NomorPolisi = textNopol.Text;
                _mobilAkanDiUpdate.Kondisi = cbKondisi.SelectedIndex;
            }
            else
            {
                Mobil mobilBaru = new Mobil
                {
                    Merk = textMerk.Text,
                    Tipe = textTipe.Text,
                    Tahun = int.Parse(textTahun.Text),
                    Warna = cbWarna.SelectedItem.ToString(),
                    KapasitasMesin = int.Parse(textKapasitasMesin.Text),
                    JenisBahanBakar = textJenisBahanBakar.Text,
                    NomorPolisi = textNopol.Text,
                    Kondisi = StringToKondisi(cbKondisi.SelectedItem.ToString())
                };
                _dashboard.mobilList.Add(mobilBaru);
            }
            this.Close();
        }

        private int StringToKondisi(string kondisi)
        {
            switch (kondisi)
            {
                case "Baik": return 1;
                case "Rusak Ringan": return 2;
                case "Rusak Berat": return 3;
                default: return 1;
            }
        }

    }
}

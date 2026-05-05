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
        public Mobil MobilData { get; private set; }

        public ManagerForm(Mobil mobil = null)
        {
            InitializeComponent();
            cbKondisi.Items.AddRange(new string[] { "Baik", "Rusak Ringan", "Rusak Berat" });
            cbWarna.Items.AddRange(new string[] { "Merah", "Biru", "Hijau", "Hitam", "Putih" });

            if (mobil != null)
            {
                // MODE UPDATE: Isi UI dengan data lama
                MobilData = mobil;
                textMerk.Text = mobil.Merk;
                textTipe.Text = mobil.Tipe;
                textTahun.Text = mobil.Tahun.ToString();
                cbWarna.SelectedItem = mobil.Warna;
                textKapasitasMesin.Text = mobil.KapasitasMesin.ToString();
                textJenisBahanBakar.Text = mobil.JenisBahanBakar;
                textNopol.Text = mobil.NomorPolisi;
                cbKondisi.SelectedItem = mobil.Kondisi;
            }
            else
            {
                // MODE TAMBAH: Bikin objek mobil kosong baru
                MobilData = new Mobil();
                cbKondisi.SelectedIndex = 0;
                cbWarna.SelectedIndex = 0;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                

                // Timpa data di dalam objek MobilData dengan inputan dari form
                // Logika ini otomatis jalan buat mode Tambah maupun Update!
                MobilData.Merk = textMerk.Text.Trim();
                MobilData.Tipe = textTipe.Text.Trim();
                MobilData.Tahun = int.Parse(textTahun.Text.Trim());

                // Pake operator ?. biar nggak crash kalau gak ada yang di-select
                MobilData.Warna = cbWarna.SelectedItem?.ToString();
                MobilData.KapasitasMesin = int.Parse(textKapasitasMesin.Text.Trim());
                MobilData.JenisBahanBakar = textJenisBahanBakar.Text.Trim();
                MobilData.NomorPolisi = textNopol.Text.Trim();
                MobilData.Kondisi = cbKondisi.SelectedItem?.ToString();

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Kasih sinyal ke Dashboard kalau proses sukses, lalu tutup
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format data tidak valid! Pastikan Tahun dan Kapasitas Mesin adalah angka.", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

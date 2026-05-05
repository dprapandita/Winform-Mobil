using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_Mobil.Models
{
    public class Mobil
    {
        private string _merk;
        private string _tipe;
        private int _tahun;
        private string _warna;
        private int _kapasitasMesin;
        private string _jenisBahanBakar;
        private string _nomorPolisi;
        private string _kondisi;

        public string Merk
        {
            get { return _merk; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Merk tidak boleh kosong!");
                _merk = value;
            }
        }

        public string Tipe
        {
            get { return _tipe; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tipe tidak boleh kosong!");
                _tipe = value;
            }
        }

        public int Tahun
        {
            get { return _tahun; }
            set 
            { 
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException($"Tahun harus antara 1900 dan {DateTime.Now.Year}!");
                _tahun = value;
            }
        }

        public string Warna
        {
            get { return _warna; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Warna tidak boleh kosong!");
                _warna = value;
            }
        }

        public int KapasitasMesin
        {
            get { return _kapasitasMesin; }
            set 
            { 
                if (value <= 0)
                    throw new ArgumentException("Kapasitas Mesin harus lebih dari 0!");
                _kapasitasMesin = value;
            }
        }

        public string JenisBahanBakar
        {
            get { return _jenisBahanBakar; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Jenis Bahan Bakar tidak boleh kosong!");
                _jenisBahanBakar = value;
            }
        }

        public string NomorPolisi
        {
            get { return _nomorPolisi; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nomor Polisi tidak boleh kosong!");
                _nomorPolisi = value;
            }
        }

        public string Kondisi
        {
            get { return _kondisi; }
            set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Kondisi tidak boleh kosong!");
                _kondisi = value;
            }
        }
    }
}

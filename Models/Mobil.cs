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
        private int _harga;

        public string Merk
        {
            get { return _merk; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _merk = value;
                }
            }
        }

        public string Tipe
        {
            get { return _tipe; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _tipe = value;
                }
            }
        }

        public int Tahun
        {
            get { return _tahun; }
            set 
            { 
                if (value >= 1900 && value <= DateTime.Now.Year)
                {
                    _tahun = value;
                }
            }
        }

        public string Warna
        {
            get { return _warna; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _warna = value;
                }
            }
        }

        public int KapasitasMesin
        {
            get { return _kapasitasMesin; }
            set 
            { 
                if (value > 0)
                {
                    _kapasitasMesin = value;
                }
            }
        }

        public string JenisBahanBakar
        {
            get { return _jenisBahanBakar; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _jenisBahanBakar = value;
                }
            }
        }

        public string NomorPolisi
        {
            get { return _nomorPolisi; }
            set 
            { 
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _nomorPolisi = value;
                }
            }
        }

        public int Harga
        {
            get { return _harga; }
            set 
            { 
                if (value > 0)
                {
                    _harga = value;
                }
            }
        }
    }
}

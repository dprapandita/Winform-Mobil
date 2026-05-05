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

    public partial class Dashboard : Form
    {
        public List<Mobil> mobilList = new List<Mobil>();
        public BindingSource bs = new BindingSource();
        public Dashboard()
        {
            InitializeComponent();

            bs.DataSource = mobilList;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = bs;
        }

        public void RefreshDataGrid()
        {
            bs.DataSource = null;
            bs.DataSource = mobilList;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            Mobil mobilBaru = new Mobil();
            using (ManagerForm managerForm = new ManagerForm(mobilBaru))
            {
                if (managerForm.ShowDialog() == DialogResult.OK)
                {
                    mobilList.Add(mobilBaru);
                    RefreshDataGrid();
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih mobil yang ingin diupdate.");
                return;
            }

            var selectedMobil = dataGridView1.SelectedRows[0].DataBoundItem as Mobil;
            if (selectedMobil != null)
            {
                using (ManagerForm managerForm = new ManagerForm(selectedMobil))
                {
                    managerForm.ShowDialog();
                    RefreshDataGrid();
                }
            }
        }
    }
}

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
        public BindingList<Mobil> mobilList = new BindingList<Mobil>();
        public Dashboard()
        {
            InitializeComponent();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mobilList;
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.ShowDialog();
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
                ManagerForm managerForm = new ManagerForm(this, selectedMobil);
                managerForm.ShowDialog();
                dataGridView1.Refresh();
            }
        }
    }
}

namespace Winform_Mobil.Views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Tambah = new Button();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1376, 399);
            dataGridView1.TabIndex = 0;
            // 
            // Tambah
            // 
            Tambah.BackColor = Color.Lime;
            Tambah.BackgroundImageLayout = ImageLayout.Center;
            Tambah.FlatStyle = FlatStyle.Popup;
            Tambah.Location = new Point(1220, 12);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(121, 41);
            Tambah.TabIndex = 1;
            Tambah.Text = "Tambah";
            Tambah.UseVisualStyleBackColor = false;
            Tambah.Click += Tambah_Click;
            // 
            // Update
            // 
            Update.BackColor = Color.Yellow;
            Update.BackgroundImageLayout = ImageLayout.Center;
            Update.FlatStyle = FlatStyle.Popup;
            Update.Location = new Point(1080, 12);
            Update.Name = "Update";
            Update.Size = new Size(121, 41);
            Update.TabIndex = 2;
            Update.Text = "Update";
            Update.UseVisualStyleBackColor = false;
            Update.Click += Update_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 470);
            Controls.Add(Update);
            Controls.Add(Tambah);
            Controls.Add(dataGridView1);
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Tambah;
        private Button Update;
    }
}
namespace Winform_Mobil.Views
{
    partial class ManagerForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textMerk = new TextBox();
            textTipe = new TextBox();
            textTahun = new TextBox();
            textKapasitasMesin = new TextBox();
            textNopol = new TextBox();
            textJenisBahanBakar = new TextBox();
            cbKondisi = new ComboBox();
            cbWarna = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 46);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "Merk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 98);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 145);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Tahun";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 200);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Warna";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 243);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 4;
            label5.Text = "Kapasitas Mesin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 288);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 5;
            label6.Text = "Nomor Polisi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 342);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 6;
            label7.Text = "Jenis Bahan Bakar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(82, 393);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 7;
            label8.Text = "Kondisi";
            // 
            // textMerk
            // 
            textMerk.Location = new Point(214, 46);
            textMerk.Name = "textMerk";
            textMerk.Size = new Size(231, 27);
            textMerk.TabIndex = 8;
            // 
            // textTipe
            // 
            textTipe.Location = new Point(214, 98);
            textTipe.Name = "textTipe";
            textTipe.Size = new Size(231, 27);
            textTipe.TabIndex = 9;
            // 
            // textTahun
            // 
            textTahun.Location = new Point(214, 145);
            textTahun.Name = "textTahun";
            textTahun.Size = new Size(231, 27);
            textTahun.TabIndex = 10;
            // 
            // textKapasitasMesin
            // 
            textKapasitasMesin.Location = new Point(214, 243);
            textKapasitasMesin.Name = "textKapasitasMesin";
            textKapasitasMesin.Size = new Size(231, 27);
            textKapasitasMesin.TabIndex = 12;
            // 
            // textNopol
            // 
            textNopol.Location = new Point(214, 288);
            textNopol.Name = "textNopol";
            textNopol.Size = new Size(231, 27);
            textNopol.TabIndex = 13;
            // 
            // textJenisBahanBakar
            // 
            textJenisBahanBakar.Location = new Point(214, 342);
            textJenisBahanBakar.Name = "textJenisBahanBakar";
            textJenisBahanBakar.Size = new Size(231, 27);
            textJenisBahanBakar.TabIndex = 14;
            // 
            // cbKondisi
            // 
            cbKondisi.FormattingEnabled = true;
            cbKondisi.Location = new Point(214, 393);
            cbKondisi.Name = "cbKondisi";
            cbKondisi.Size = new Size(151, 28);
            cbKondisi.TabIndex = 15;
            // 
            // cbWarna
            // 
            cbWarna.FormattingEnabled = true;
            cbWarna.Location = new Point(214, 197);
            cbWarna.Name = "cbWarna";
            cbWarna.Size = new Size(151, 28);
            cbWarna.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(165, 455);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSimpan_Click;
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 517);
            Controls.Add(button1);
            Controls.Add(cbWarna);
            Controls.Add(cbKondisi);
            Controls.Add(textJenisBahanBakar);
            Controls.Add(textNopol);
            Controls.Add(textKapasitasMesin);
            Controls.Add(textTahun);
            Controls.Add(textTipe);
            Controls.Add(textMerk);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ManagerForm";
            Text = "Manager Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textMerk;
        private TextBox textTipe;
        private TextBox textTahun;
        private TextBox textKapasitasMesin;
        private TextBox textNopol;
        private TextBox textJenisBahanBakar;
        private ComboBox cbKondisi;
        private ComboBox cbWarna;
        private Button button1;
    }
}
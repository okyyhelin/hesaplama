namespace osman_hoca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnHesaplaKaydet = new Button();
            lbladi = new Label();
            lstOgrenciler = new ListBox();
            txtadi = new TextBox();
            txtokulno = new TextBox();
            lblsoyadi = new Label();
            txtsoyadi = new TextBox();
            lblokulno = new Label();
            txtvize = new TextBox();
            label4 = new Label();
            lblvize = new Label();
            txtfinal = new TextBox();
            lblfinal = new Label();
            cmbcinsiyet = new ComboBox();
            SuspendLayout();
            // 
            // btnHesaplaKaydet
            // 
            btnHesaplaKaydet.Location = new Point(665, 153);
            btnHesaplaKaydet.Name = "btnHesaplaKaydet";
            btnHesaplaKaydet.Size = new Size(75, 23);
            btnHesaplaKaydet.TabIndex = 7;
            btnHesaplaKaydet.Text = "Kaydet";
            btnHesaplaKaydet.UseVisualStyleBackColor = true;
            btnHesaplaKaydet.Click += btnHesaplaKaydet_Click_1;
            // 
            // lbladi
            // 
            lbladi.AutoSize = true;
            lbladi.Location = new Point(41, 33);
            lbladi.Name = "lbladi";
            lbladi.Size = new Size(25, 15);
            lbladi.TabIndex = 1;
            lbladi.Text = "Adi";
            // 
            // lstOgrenciler
            // 
            lstOgrenciler.FormattingEnabled = true;
            lstOgrenciler.ItemHeight = 15;
            lstOgrenciler.Location = new Point(12, 209);
            lstOgrenciler.Name = "lstOgrenciler";
            lstOgrenciler.Size = new Size(716, 229);
            lstOgrenciler.TabIndex = 8;
            // 
            // txtadi
            // 
            txtadi.Location = new Point(107, 25);
            txtadi.Multiline = true;
            txtadi.Name = "txtadi";
            txtadi.Size = new Size(100, 23);
            txtadi.TabIndex = 1;
            // 
            // txtokulno
            // 
            txtokulno.Location = new Point(375, 33);
            txtokulno.Name = "txtokulno";
            txtokulno.Size = new Size(100, 23);
            txtokulno.TabIndex = 3;
            // 
            // lblsoyadi
            // 
            lblsoyadi.AutoSize = true;
            lblsoyadi.Location = new Point(41, 91);
            lblsoyadi.Name = "lblsoyadi";
            lblsoyadi.Size = new Size(42, 15);
            lblsoyadi.TabIndex = 4;
            lblsoyadi.Text = "Soyadi";
            // 
            // txtsoyadi
            // 
            txtsoyadi.Location = new Point(107, 88);
            txtsoyadi.Name = "txtsoyadi";
            txtsoyadi.Size = new Size(100, 23);
            txtsoyadi.TabIndex = 2;
            // 
            // lblokulno
            // 
            lblokulno.AutoSize = true;
            lblokulno.Location = new Point(309, 33);
            lblokulno.Name = "lblokulno";
            lblokulno.Size = new Size(51, 15);
            lblokulno.TabIndex = 6;
            lblokulno.Text = "Okul No";
            // 
            // txtvize
            // 
            txtvize.Location = new Point(628, 41);
            txtvize.Name = "txtvize";
            txtvize.Size = new Size(100, 23);
            txtvize.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 96);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 8;
            label4.Text = "Cinsiyet";
            // 
            // lblvize
            // 
            lblvize.AutoSize = true;
            lblvize.Location = new Point(555, 41);
            lblvize.Name = "lblvize";
            lblvize.Size = new Size(28, 15);
            lblvize.TabIndex = 10;
            lblvize.Text = "Vize";
            // 
            // txtfinal
            // 
            txtfinal.Location = new Point(628, 91);
            txtfinal.Name = "txtfinal";
            txtfinal.Size = new Size(100, 23);
            txtfinal.TabIndex = 6;
            // 
            // lblfinal
            // 
            lblfinal.AutoSize = true;
            lblfinal.Location = new Point(553, 96);
            lblfinal.Name = "lblfinal";
            lblfinal.Size = new Size(32, 15);
            lblfinal.TabIndex = 12;
            lblfinal.Text = "Final";
            // 
            // cmbcinsiyet
            // 
            cmbcinsiyet.FormattingEnabled = true;
            cmbcinsiyet.Items.AddRange(new object[] { "erkek", "kadın" });
            cmbcinsiyet.Location = new Point(375, 91);
            cmbcinsiyet.Name = "cmbcinsiyet";
            cmbcinsiyet.Size = new Size(121, 23);
            cmbcinsiyet.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbcinsiyet);
            Controls.Add(txtfinal);
            Controls.Add(lblfinal);
            Controls.Add(lblvize);
            Controls.Add(txtvize);
            Controls.Add(label4);
            Controls.Add(txtsoyadi);
            Controls.Add(lblokulno);
            Controls.Add(txtokulno);
            Controls.Add(lblsoyadi);
            Controls.Add(txtadi);
            Controls.Add(lstOgrenciler);
            Controls.Add(lbladi);
            Controls.Add(btnHesaplaKaydet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHesaplaKaydet;
        private Label lbladi;
        private ListBox lstOgrenciler;
        private TextBox txtadi;
        private TextBox txtokulno;
        private Label lblsoyadi;
        private TextBox txtsoyadi;
        private Label lblokulno;
        private TextBox txtvize;
        private Label label4;
        private Label lblvize;
        private TextBox txtfinal;
        private Label lblfinal;
        private ComboBox cmbcinsiyet;
    }
}
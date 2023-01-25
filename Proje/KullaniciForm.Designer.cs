namespace M_Proje
{
    partial class KullaniciForm
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
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnHaftalik = new System.Windows.Forms.Button();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKalori = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSecilenBesinler = new System.Windows.Forms.DataGridView();
            this.dgvOgunler = new System.Windows.Forms.DataGridView();
            this.lstKullaniciBilgileri = new System.Windows.Forms.ListBox();
            this.lblKulanici = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvBesinler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecilenBesinler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAylik
            // 
            this.btnAylik.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAylik.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAylik.Location = new System.Drawing.Point(16, 600);
            this.btnAylik.Margin = new System.Windows.Forms.Padding(2);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(378, 68);
            this.btnAylik.TabIndex = 26;
            this.btnAylik.Text = "Aylik Rapor Icin Tiklayiniz";
            this.btnAylik.UseVisualStyleBackColor = false;
            this.btnAylik.Click += new System.EventHandler(this.btnAylik_Click);
            // 
            // btnHaftalik
            // 
            this.btnHaftalik.BackColor = System.Drawing.Color.LightGreen;
            this.btnHaftalik.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHaftalik.Location = new System.Drawing.Point(16, 518);
            this.btnHaftalik.Margin = new System.Windows.Forms.Padding(2);
            this.btnHaftalik.Name = "btnHaftalik";
            this.btnHaftalik.Size = new System.Drawing.Size(378, 68);
            this.btnHaftalik.TabIndex = 25;
            this.btnHaftalik.Text = "Haftalik Rapor icin Tiklayiniz";
            this.btnHaftalik.UseVisualStyleBackColor = false;
            this.btnHaftalik.Click += new System.EventHandler(this.btnHaftalik_Click);
            // 
            // btnGunluk
            // 
            this.btnGunluk.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnGunluk.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGunluk.Location = new System.Drawing.Point(16, 435);
            this.btnGunluk.Margin = new System.Windows.Forms.Padding(2);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(378, 68);
            this.btnGunluk.TabIndex = 24;
            this.btnGunluk.Text = "Gunluk Rapor icin Tiklayiniz";
            this.btnGunluk.UseVisualStyleBackColor = false;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(880, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Miktar Giriniz :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMiktar.Location = new System.Drawing.Point(1046, 344);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(225, 32);
            this.txtMiktar.TabIndex = 22;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(1291, 321);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(164, 75);
            this.btnEkle.TabIndex = 21;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKalori
            // 
            this.lblKalori.AutoSize = true;
            this.lblKalori.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalori.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKalori.Location = new System.Drawing.Point(1272, 638);
            this.lblKalori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalori.Name = "lblKalori";
            this.lblKalori.Size = new System.Drawing.Size(2, 28);
            this.lblKalori.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(1092, 638);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Toplam Kalori:";
            // 
            // dgvSecilenBesinler
            // 
            this.dgvSecilenBesinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecilenBesinler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSecilenBesinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecilenBesinler.Location = new System.Drawing.Point(428, 449);
            this.dgvSecilenBesinler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSecilenBesinler.MultiSelect = false;
            this.dgvSecilenBesinler.Name = "dgvSecilenBesinler";
            this.dgvSecilenBesinler.RowHeadersVisible = false;
            this.dgvSecilenBesinler.RowHeadersWidth = 62;
            this.dgvSecilenBesinler.RowTemplate.Height = 33;
            this.dgvSecilenBesinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecilenBesinler.Size = new System.Drawing.Size(1027, 172);
            this.dgvSecilenBesinler.TabIndex = 18;
            // 
            // dgvOgunler
            // 
            this.dgvOgunler.AllowUserToAddRows = false;
            this.dgvOgunler.AllowUserToDeleteRows = false;
            this.dgvOgunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOgunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOgunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgunler.Location = new System.Drawing.Point(428, 31);
            this.dgvOgunler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOgunler.MultiSelect = false;
            this.dgvOgunler.Name = "dgvOgunler";
            this.dgvOgunler.ReadOnly = true;
            this.dgvOgunler.RowHeadersVisible = false;
            this.dgvOgunler.RowHeadersWidth = 62;
            this.dgvOgunler.RowTemplate.Height = 33;
            this.dgvOgunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgunler.Size = new System.Drawing.Size(1027, 124);
            this.dgvOgunler.TabIndex = 17;
            this.dgvOgunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgunler_CellClick);
            // 
            // lstKullaniciBilgileri
            // 
            this.lstKullaniciBilgileri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstKullaniciBilgileri.FormattingEnabled = true;
            this.lstKullaniciBilgileri.ItemHeight = 21;
            this.lstKullaniciBilgileri.Location = new System.Drawing.Point(12, 87);
            this.lstKullaniciBilgileri.Name = "lstKullaniciBilgileri";
            this.lstKullaniciBilgileri.Size = new System.Drawing.Size(382, 319);
            this.lstKullaniciBilgileri.TabIndex = 16;
            // 
            // lblKulanici
            // 
            this.lblKulanici.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKulanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKulanici.Font = new System.Drawing.Font("SWRomnc", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKulanici.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblKulanici.Location = new System.Drawing.Point(12, 39);
            this.lblKulanici.Name = "lblKulanici";
            this.lblKulanici.Size = new System.Drawing.Size(382, 45);
            this.lblKulanici.TabIndex = 15;
            this.lblKulanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1489, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıToolStripMenuItem
            // 
            this.kullanıcıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıBilgileriToolStripMenuItem});
            this.kullanıcıToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kullanıcıToolStripMenuItem.Name = "kullanıcıToolStripMenuItem";
            this.kullanıcıToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.kullanıcıToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem});
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(161, 30);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click_1);
            // 
            // dgvBesinler
            // 
            this.dgvBesinler.AllowUserToAddRows = false;
            this.dgvBesinler.AllowUserToDeleteRows = false;
            this.dgvBesinler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBesinler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBesinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBesinler.Location = new System.Drawing.Point(428, 172);
            this.dgvBesinler.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBesinler.MultiSelect = false;
            this.dgvBesinler.Name = "dgvBesinler";
            this.dgvBesinler.ReadOnly = true;
            this.dgvBesinler.RowHeadersVisible = false;
            this.dgvBesinler.RowHeadersWidth = 62;
            this.dgvBesinler.RowTemplate.Height = 33;
            this.dgvBesinler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBesinler.Size = new System.Drawing.Size(1027, 124);
            this.dgvBesinler.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(428, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Günlük Yenilen Yemekler:";
            // 
            // KullaniciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M_Proje.Properties.Resources.en_iyi_instagram_kullanici_adleri;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1489, 719);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBesinler);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.btnHaftalik);
            this.Controls.Add(this.btnGunluk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblKalori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSecilenBesinler);
            this.Controls.Add(this.dgvOgunler);
            this.Controls.Add(this.lstKullaniciBilgileri);
            this.Controls.Add(this.lblKulanici);
            this.Controls.Add(this.menuStrip1);
            this.Name = "KullaniciForm";
            this.Text = "KullaniciForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecilenBesinler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgunler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBesinler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAylik;
        private Button btnHaftalik;
        private Button btnGunluk;
        private Label label3;
        private TextBox txtMiktar;
        private Button btnEkle;
        private Label lblKalori;
        private Label label1;
        private DataGridView dgvSecilenBesinler;
        private DataGridView dgvOgunler;
        private ListBox lstKullaniciBilgileri;
        private Label lblKulanici;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem kullanıcıToolStripMenuItem;
        private ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private DataGridView dgvBesinler;
        private Label label2;
    }
}
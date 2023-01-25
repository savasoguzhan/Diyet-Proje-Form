namespace M_Proje
{
    partial class KayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitForm));
            this.lblZorluk = new System.Windows.Forms.Label();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.lstKayit = new System.Windows.Forms.ListBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEgitmen = new System.Windows.Forms.ComboBox();
            this.rdoErkek = new System.Windows.Forms.RadioButton();
            this.rdoKadin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblZorluk
            // 
            this.lblZorluk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblZorluk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblZorluk.Location = new System.Drawing.Point(161, 212);
            this.lblZorluk.Name = "lblZorluk";
            this.lblZorluk.Size = new System.Drawing.Size(321, 23);
            this.lblZorluk.TabIndex = 52;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKayitOl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnKayitOl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKayitOl.Location = new System.Drawing.Point(28, 415);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(584, 96);
            this.btnKayitOl.TabIndex = 39;
            this.btnKayitOl.Text = "KAYIT OL";
            this.btnKayitOl.UseVisualStyleBackColor = false;
            this.btnKayitOl.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstKayit
            // 
            this.lstKayit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstKayit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstKayit.FormattingEnabled = true;
            this.lstKayit.ItemHeight = 21;
            this.lstKayit.Location = new System.Drawing.Point(684, 25);
            this.lstKayit.MultiColumn = true;
            this.lstKayit.Name = "lstKayit";
            this.lstKayit.Size = new System.Drawing.Size(267, 340);
            this.lstKayit.TabIndex = 54;
            // 
            // txtYas
            // 
            this.txtYas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtYas.Location = new System.Drawing.Point(161, 132);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(380, 29);
            this.txtYas.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(73, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 21);
            this.label12.TabIndex = 48;
            this.label12.Text = "Şifre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(87, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Yaş:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.Location = new System.Drawing.Point(161, 183);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(380, 29);
            this.txtSifre.TabIndex = 49;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAdSoyad.Location = new System.Drawing.Point(161, 78);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(380, 29);
            this.txtAdSoyad.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(40, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 42;
            this.label8.Text = "Ad Soyad:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(161, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(380, 29);
            this.txtUser.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 21);
            this.label13.TabIndex = 50;
            this.label13.Text = "Tercih Ettiğiniz Eğitmen :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(15, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // cmbEgitmen
            // 
            this.cmbEgitmen.DisplayMember = "Adı";
            this.cmbEgitmen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbEgitmen.FormattingEnabled = true;
            this.cmbEgitmen.Location = new System.Drawing.Point(246, 297);
            this.cmbEgitmen.Name = "cmbEgitmen";
            this.cmbEgitmen.Size = new System.Drawing.Size(286, 29);
            this.cmbEgitmen.TabIndex = 51;
            // 
            // rdoErkek
            // 
            this.rdoErkek.AutoSize = true;
            this.rdoErkek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoErkek.Location = new System.Drawing.Point(161, 247);
            this.rdoErkek.Name = "rdoErkek";
            this.rdoErkek.Size = new System.Drawing.Size(76, 25);
            this.rdoErkek.TabIndex = 50;
            this.rdoErkek.TabStop = true;
            this.rdoErkek.Text = "ERKEK";
            this.rdoErkek.UseVisualStyleBackColor = true;
            // 
            // rdoKadin
            // 
            this.rdoKadin.AutoSize = true;
            this.rdoKadin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoKadin.Location = new System.Drawing.Point(284, 247);
            this.rdoKadin.Name = "rdoKadin";
            this.rdoKadin.Size = new System.Drawing.Size(79, 25);
            this.rdoKadin.TabIndex = 51;
            this.rdoKadin.TabStop = true;
            this.rdoKadin.Text = "KADIN";
            this.rdoKadin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cinsiyet: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoKadin);
            this.groupBox1.Controls.Add(this.lblZorluk);
            this.groupBox1.Controls.Add(this.rdoErkek);
            this.groupBox1.Controls.Add(this.cmbEgitmen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtYas);
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 367);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(995, 657);
            this.Controls.Add(this.lstKayit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKayitOl);
            this.Name = "KayitForm";
            this.Text = "KayitForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblZorluk;
        private Button btnKayitOl;
        private ListBox lstKayit;
        private TextBox txtYas;
        private Label label12;
        private Label label7;
        private TextBox txtSifre;
        private TextBox txtAdSoyad;
        private Label label8;
        private TextBox txtUser;
        private Label label13;
        private Label label9;
        private ComboBox cmbEgitmen;
        private RadioButton rdoErkek;
        private RadioButton rdoKadin;
        private Label label1;
        private GroupBox groupBox1;
    }
}
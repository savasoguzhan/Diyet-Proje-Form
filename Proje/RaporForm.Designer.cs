namespace M_Proje
{
    partial class RaporForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRapor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTavsiye = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "RAPOR:";
            // 
            // lblRapor
            // 
            this.lblRapor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRapor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRapor.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRapor.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRapor.Location = new System.Drawing.Point(39, 125);
            this.lblRapor.Name = "lblRapor";
            this.lblRapor.Size = new System.Drawing.Size(327, 106);
            this.lblRapor.TabIndex = 1;
            this.lblRapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(39, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kalori Miktari:";
            // 
            // lblTavsiye
            // 
            this.lblTavsiye.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTavsiye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTavsiye.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTavsiye.Location = new System.Drawing.Point(39, 297);
            this.lblTavsiye.Name = "lblTavsiye";
            this.lblTavsiye.Size = new System.Drawing.Size(896, 239);
            this.lblTavsiye.TabIndex = 3;
            this.lblTavsiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblRapor);
            this.groupBox1.Controls.Add(this.lblTavsiye);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 594);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Uzman Tavsiyesi:";
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M_Proje.Properties.Resources.MicrosoftTeams_image__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1160, 642);
            this.Controls.Add(this.groupBox1);
            this.Name = "RaporForm";
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label lblRapor;
        private Label label2;
        private Label lblTavsiye;
        private GroupBox groupBox1;
        private Label label3;
    }
}
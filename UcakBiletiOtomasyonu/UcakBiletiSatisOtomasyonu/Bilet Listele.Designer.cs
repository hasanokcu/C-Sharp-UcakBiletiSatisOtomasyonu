namespace UcakBiletiSatisOtomasyonu
{
    partial class BiletListele
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdTc = new System.Windows.Forms.TextBox();
            this.biletTablo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.biletTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(387, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biletleriniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(329, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad veya TC:";
            // 
            // txtAdTc
            // 
            this.txtAdTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdTc.Location = new System.Drawing.Point(432, 17);
            this.txtAdTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdTc.Name = "txtAdTc";
            this.txtAdTc.Size = new System.Drawing.Size(157, 22);
            this.txtAdTc.TabIndex = 4;
            this.txtAdTc.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // biletTablo
            // 
            this.biletTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.biletTablo.BackgroundColor = System.Drawing.SystemColors.Window;
            this.biletTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.biletTablo.Location = new System.Drawing.Point(-3, 91);
            this.biletTablo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.biletTablo.Name = "biletTablo";
            this.biletTablo.Size = new System.Drawing.Size(902, 367);
            this.biletTablo.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UcakBiletiSatisOtomasyonu.Properties.Resources.air_tickets_shows_aircraft_flights_3d_rendering;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // BiletListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(898, 456);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.biletTablo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdTc);
            this.Name = "BiletListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilet Listele";
            this.Load += new System.EventHandler(this.BiletListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biletTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdTc;
        private System.Windows.Forms.DataGridView biletTablo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
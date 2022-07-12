namespace UcakBiletiSatisOtomasyonu
{
    partial class YöneticiPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiPaneli));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGelenMesajlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "istockphoto-1177861857-612x612.jpg");
            this.ımageList1.Images.SetKeyName(1, "depositphotos_40575109-stock-illustration-login-button.jpg");
            this.ımageList1.Images.SetKeyName(2, "Google_Messages_logo.svg.png");
            this.ımageList1.Images.SetKeyName(3, "android-messages-logo-020799A598-seeklogo.com.png");
            this.ımageList1.Images.SetKeyName(4, "783_email.jpg");
            this.ımageList1.Images.SetKeyName(5, "Emblem-question-red.svg.png");
            this.ımageList1.Images.SetKeyName(6, "150-1509062_transparent-text-message-icon-png-message-icon-png.png");
            this.ımageList1.Images.SetKeyName(7, "istockphoto-1137971264-170667a.jpg");
            this.ımageList1.Images.SetKeyName(8, "png-transparent-social-media-linkedin-business-organization-company-plane-angle-c" +
        "ompany-logo.png");
            this.ımageList1.Images.SetKeyName(9, "indir.jpg");
            this.ımageList1.Images.SetKeyName(10, "23-236356_administrator-admin-icon-admin-icons-hd-png-download.png");
            this.ımageList1.Images.SetKeyName(11, "anadolujet_logo.png");
            this.ımageList1.Images.SetKeyName(12, "354855.jpg");
            this.ımageList1.Images.SetKeyName(13, "Pegasus_Airlines-logo-239FB5E288-seeklogo.com.png");
            this.ımageList1.Images.SetKeyName(14, "thy_4265.jpg");
            this.ımageList1.Images.SetKeyName(15, "tickets-for-domestic-flights-only-airline-ticket-11563257210fp3vlxv1vp.png");
            this.ımageList1.Images.SetKeyName(16, "air-ticket-162507919.jpg");
            this.ımageList1.Images.SetKeyName(17, "pngtree-vector-lock-icon-png-image_515444.jpg");
            this.ımageList1.Images.SetKeyName(18, "login-button-png-12.png");
            this.ımageList1.Images.SetKeyName(19, "UeBuUpaE_400x400.jpeg");
            this.ımageList1.Images.SetKeyName(20, "istockphoto-1177861857-612x612.jpg");
            // 
            // btnGelenMesajlar
            // 
            this.btnGelenMesajlar.BackColor = System.Drawing.Color.White;
            this.btnGelenMesajlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelenMesajlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelenMesajlar.ImageIndex = 2;
            this.btnGelenMesajlar.ImageList = this.ımageList1;
            this.btnGelenMesajlar.Location = new System.Drawing.Point(10, 12);
            this.btnGelenMesajlar.Name = "btnGelenMesajlar";
            this.btnGelenMesajlar.Size = new System.Drawing.Size(360, 125);
            this.btnGelenMesajlar.TabIndex = 9;
            this.btnGelenMesajlar.Text = "          GELEN MESAJLAR";
            this.btnGelenMesajlar.UseVisualStyleBackColor = false;
            this.btnGelenMesajlar.Click += new System.EventHandler(this.btnGelenMesajlar_Click);
            // 
            // YöneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(380, 149);
            this.Controls.Add(this.btnGelenMesajlar);
            this.Name = "YöneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.YöneticiPaneli_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGelenMesajlar;
        private System.Windows.Forms.ImageList ımageList1;
    }
}
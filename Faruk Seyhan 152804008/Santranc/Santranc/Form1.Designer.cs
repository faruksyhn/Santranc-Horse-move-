namespace Santranc
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOlustur = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbBuyukluk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(266, 12);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Başla";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // cmbBuyukluk
            // 
            this.cmbBuyukluk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyukluk.FormattingEnabled = true;
            this.cmbBuyukluk.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbBuyukluk.Location = new System.Drawing.Point(88, 12);
            this.cmbBuyukluk.Name = "cmbBuyukluk";
            this.cmbBuyukluk.Size = new System.Drawing.Size(121, 21);
            this.cmbBuyukluk.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Büyüklük";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuyukluk);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbBuyukluk;
        private System.Windows.Forms.Label label1;
    }
}



namespace oyundatabase
{
    partial class Kullanicikaydi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textkullaniciadi = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // textkullaniciadi
            // 
            this.textkullaniciadi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textkullaniciadi.Location = new System.Drawing.Point(135, 335);
            this.textkullaniciadi.Name = "textkullaniciadi";
            this.textkullaniciadi.Size = new System.Drawing.Size(153, 22);
            this.textkullaniciadi.TabIndex = 1;
            this.textkullaniciadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label.Location = new System.Drawing.Point(12, 335);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Kullanıcı Adı";
            this.label.Click += new System.EventHandler(this.kategorid_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnlistele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlistele.Location = new System.Drawing.Point(734, 255);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 3;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textsifre
            // 
            this.textsifre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textsifre.Location = new System.Drawing.Point(135, 379);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(153, 22);
            this.textsifre.TabIndex = 4;
            this.textsifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(12, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textemail
            // 
            this.textemail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textemail.Location = new System.Drawing.Point(135, 427);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(153, 22);
            this.textemail.TabIndex = 6;
            this.textemail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnsil.Location = new System.Drawing.Point(826, 255);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 10;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnekle.Location = new System.Drawing.Point(317, 335);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 11;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnara.Location = new System.Drawing.Point(317, 426);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 12;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnguncelle.Location = new System.Drawing.Point(317, 379);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 13;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.buttonguncelle);
            // 
            // Kullanicikaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(945, 489);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textkullaniciadi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kullanicikaydi";
            this.Text = "Kullanıcı Kaydı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textkullaniciadi;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnguncelle;
    }
}


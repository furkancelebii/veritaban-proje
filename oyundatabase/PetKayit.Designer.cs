
namespace oyundatabase
{
    partial class PetKayit
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
            this.labelpetpower = new System.Windows.Forms.Label();
            this.textpetpower = new System.Windows.Forms.TextBox();
            this.labelpetname = new System.Windows.Forms.Label();
            this.textpetname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpetpower
            // 
            this.labelpetpower.AutoSize = true;
            this.labelpetpower.Location = new System.Drawing.Point(34, 364);
            this.labelpetpower.Name = "labelpetpower";
            this.labelpetpower.Size = new System.Drawing.Size(72, 17);
            this.labelpetpower.TabIndex = 39;
            this.labelpetpower.Text = "Pet Power";
            // 
            // textpetpower
            // 
            this.textpetpower.Location = new System.Drawing.Point(142, 364);
            this.textpetpower.Name = "textpetpower";
            this.textpetpower.Size = new System.Drawing.Size(153, 22);
            this.textpetpower.TabIndex = 38;
            // 
            // labelpetname
            // 
            this.labelpetname.AutoSize = true;
            this.labelpetname.Location = new System.Drawing.Point(34, 305);
            this.labelpetname.Name = "labelpetname";
            this.labelpetname.Size = new System.Drawing.Size(70, 17);
            this.labelpetname.TabIndex = 35;
            this.labelpetname.Text = "Pet Name";
            // 
            // textpetname
            // 
            this.textpetname.Location = new System.Drawing.Point(142, 305);
            this.textpetname.Name = "textpetname";
            this.textpetname.Size = new System.Drawing.Size(153, 22);
            this.textpetname.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 216);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(345, 335);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(75, 23);
            this.btnguncelle.TabIndex = 48;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(345, 364);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(75, 23);
            this.btnara.TabIndex = 47;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(345, 302);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(75, 23);
            this.btnekle.TabIndex = 46;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(713, 195);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 45;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(617, 195);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 44;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // PetKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.labelpetpower);
            this.Controls.Add(this.textpetpower);
            this.Controls.Add(this.labelpetname);
            this.Controls.Add(this.textpetname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PetKayit";
            this.Text = "PetKaydi";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelpetpower;
        private System.Windows.Forms.TextBox textpetpower;
        private System.Windows.Forms.Label labelpetname;
        private System.Windows.Forms.TextBox textpetname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnlistele;
    }
}
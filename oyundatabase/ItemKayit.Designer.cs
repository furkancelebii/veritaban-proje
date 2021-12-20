
namespace oyundatabase
{
    partial class ItemKayit
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
            this.labelitempower = new System.Windows.Forms.Label();
            this.textitempower = new System.Windows.Forms.TextBox();
            this.labelitemrank = new System.Windows.Forms.Label();
            this.textitemrank = new System.Windows.Forms.TextBox();
            this.labelitemname = new System.Windows.Forms.Label();
            this.textitemname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labeitemprice = new System.Windows.Forms.Label();
            this.textitemprice = new System.Windows.Forms.TextBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnara = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelitempower
            // 
            this.labelitempower.AutoSize = true;
            this.labelitempower.Location = new System.Drawing.Point(19, 359);
            this.labelitempower.Name = "labelitempower";
            this.labelitempower.Size = new System.Drawing.Size(77, 17);
            this.labelitempower.TabIndex = 23;
            this.labelitempower.Text = "Item Power";
            // 
            // textitempower
            // 
            this.textitempower.Location = new System.Drawing.Point(148, 359);
            this.textitempower.Name = "textitempower";
            this.textitempower.Size = new System.Drawing.Size(153, 22);
            this.textitempower.TabIndex = 22;
            // 
            // labelitemrank
            // 
            this.labelitemrank.AutoSize = true;
            this.labelitemrank.Location = new System.Drawing.Point(19, 322);
            this.labelitemrank.Name = "labelitemrank";
            this.labelitemrank.Size = new System.Drawing.Size(71, 17);
            this.labelitemrank.TabIndex = 21;
            this.labelitemrank.Text = "Item Rank";
            // 
            // textitemrank
            // 
            this.textitemrank.Location = new System.Drawing.Point(148, 322);
            this.textitemrank.Name = "textitemrank";
            this.textitemrank.Size = new System.Drawing.Size(153, 22);
            this.textitemrank.TabIndex = 20;
            // 
            // labelitemname
            // 
            this.labelitemname.AutoSize = true;
            this.labelitemname.Location = new System.Drawing.Point(21, 286);
            this.labelitemname.Name = "labelitemname";
            this.labelitemname.Size = new System.Drawing.Size(75, 17);
            this.labelitemname.TabIndex = 19;
            this.labelitemname.Text = "Item Name";
            // 
            // textitemname
            // 
            this.textitemname.Location = new System.Drawing.Point(148, 286);
            this.textitemname.Name = "textitemname";
            this.textitemname.Size = new System.Drawing.Size(153, 22);
            this.textitemname.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 228);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labeitemprice
            // 
            this.labeitemprice.AutoSize = true;
            this.labeitemprice.Location = new System.Drawing.Point(19, 395);
            this.labeitemprice.Name = "labeitemprice";
            this.labeitemprice.Size = new System.Drawing.Size(70, 17);
            this.labeitemprice.TabIndex = 29;
            this.labeitemprice.Text = "Item Price";
            // 
            // textitemprice
            // 
            this.textitemprice.Location = new System.Drawing.Point(148, 395);
            this.textitemprice.Name = "textitemprice";
            this.textitemprice.Size = new System.Drawing.Size(153, 22);
            this.textitemprice.TabIndex = 28;
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(351, 334);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(88, 42);
            this.btnguncelle.TabIndex = 34;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(351, 381);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(88, 34);
            this.btnara.TabIndex = 33;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(351, 286);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(88, 43);
            this.btnekle.TabIndex = 32;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(674, 205);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 31;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(582, 205);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(75, 23);
            this.btnlistele.TabIndex = 30;
            this.btnlistele.Text = "Listele";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // ItemKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.labeitemprice);
            this.Controls.Add(this.textitemprice);
            this.Controls.Add(this.labelitempower);
            this.Controls.Add(this.textitempower);
            this.Controls.Add(this.labelitemrank);
            this.Controls.Add(this.textitemrank);
            this.Controls.Add(this.labelitemname);
            this.Controls.Add(this.textitemname);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ItemKayit";
            this.Text = "ItemKayit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelitempower;
        private System.Windows.Forms.TextBox textitempower;
        private System.Windows.Forms.Label labelitemrank;
        private System.Windows.Forms.TextBox textitemrank;
        private System.Windows.Forms.Label labelitemname;
        private System.Windows.Forms.TextBox textitemname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labeitemprice;
        private System.Windows.Forms.TextBox textitemprice;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnlistele;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
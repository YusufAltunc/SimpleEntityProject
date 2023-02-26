namespace EntitiyProjeUygulama
{
    partial class FrmUrun
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.txtdurum = new System.Windows.Forms.TextBox();
            this.btnlistele = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbktgr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜN ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "MARKA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "STOK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "FİYAT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "DURUM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "KATEGORİ:";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(133, 45);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(216, 30);
            this.txtıd.TabIndex = 7;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(133, 84);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(216, 30);
            this.txtad.TabIndex = 8;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(133, 124);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(216, 30);
            this.txtmarka.TabIndex = 9;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(133, 165);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(216, 30);
            this.txtstok.TabIndex = 10;
            // 
            // txtfiyat
            // 
            this.txtfiyat.Location = new System.Drawing.Point(133, 204);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(216, 30);
            this.txtfiyat.TabIndex = 11;
            // 
            // txtdurum
            // 
            this.txtdurum.Location = new System.Drawing.Point(133, 244);
            this.txtdurum.Name = "txtdurum";
            this.txtdurum.Size = new System.Drawing.Size(216, 30);
            this.txtdurum.TabIndex = 12;
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(420, 57);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(178, 44);
            this.btnlistele.TabIndex = 14;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(420, 107);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(178, 44);
            this.btnekle.TabIndex = 15;
            this.btnekle.Text = "EKLE";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(420, 155);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(178, 44);
            this.btnsil.TabIndex = 16;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(420, 205);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(178, 44);
            this.btnguncelle.TabIndex = 17;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(420, 254);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(178, 44);
            this.btntemizle.TabIndex = 18;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(668, 200);
            this.dataGridView1.TabIndex = 19;
            // 
            // cmbktgr
            // 
            this.cmbktgr.FormattingEnabled = true;
            this.cmbktgr.Location = new System.Drawing.Point(133, 281);
            this.cmbktgr.Name = "cmbktgr";
            this.cmbktgr.Size = new System.Drawing.Size(216, 33);
            this.cmbktgr.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 591);
            this.Controls.Add(this.cmbktgr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.txtdurum);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtıd;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.TextBox txtdurum;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbktgr;
    }
}
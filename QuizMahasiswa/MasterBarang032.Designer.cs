namespace QuizMahasiswa
{
    partial class MasterBarang032
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
            this.BtnHapus = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnCari = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxHarga = new System.Windows.Forms.TextBox();
            this.TxtBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.TxtBoxNamaSupplierCari = new System.Windows.Forms.TextBox();
            this.TxtBoxNamaBarangCari = new System.Windows.Forms.TextBox();
            this.TxtBoxStock = new System.Windows.Forms.TextBox();
            this.TxtBoxNamaSupplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHapus
            // 
            this.BtnHapus.Location = new System.Drawing.Point(333, 415);
            this.BtnHapus.Name = "BtnHapus";
            this.BtnHapus.Size = new System.Drawing.Size(75, 24);
            this.BtnHapus.TabIndex = 59;
            this.BtnHapus.Text = "Delete";
            this.BtnHapus.UseVisualStyleBackColor = true;
            this.BtnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(191, 415);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 24);
            this.BtnUpdate.TabIndex = 58;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(47, 415);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(75, 24);
            this.BtnSimpan.TabIndex = 57;
            this.BtnSimpan.Text = "Save";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnCari
            // 
            this.BtnCari.Location = new System.Drawing.Point(333, 57);
            this.BtnCari.Name = "BtnCari";
            this.BtnCari.Size = new System.Drawing.Size(75, 24);
            this.BtnCari.TabIndex = 56;
            this.BtnCari.Text = "Search";
            this.BtnCari.UseVisualStyleBackColor = true;
            this.BtnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nama Supplier";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "ID Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Master Product";
            // 
            // TxtBoxHarga
            // 
            this.TxtBoxHarga.Location = new System.Drawing.Point(145, 270);
            this.TxtBoxHarga.Name = "TxtBoxHarga";
            this.TxtBoxHarga.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxHarga.TabIndex = 44;
            // 
            // TxtBoxNamaBarang
            // 
            this.TxtBoxNamaBarang.Location = new System.Drawing.Point(145, 219);
            this.TxtBoxNamaBarang.Name = "TxtBoxNamaBarang";
            this.TxtBoxNamaBarang.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxNamaBarang.TabIndex = 43;
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.Location = new System.Drawing.Point(145, 170);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxID.TabIndex = 42;
            // 
            // TxtBoxNamaSupplierCari
            // 
            this.TxtBoxNamaSupplierCari.Location = new System.Drawing.Point(145, 107);
            this.TxtBoxNamaSupplierCari.Name = "TxtBoxNamaSupplierCari";
            this.TxtBoxNamaSupplierCari.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxNamaSupplierCari.TabIndex = 41;
            // 
            // TxtBoxNamaBarangCari
            // 
            this.TxtBoxNamaBarangCari.Location = new System.Drawing.Point(145, 61);
            this.TxtBoxNamaBarangCari.Name = "TxtBoxNamaBarangCari";
            this.TxtBoxNamaBarangCari.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxNamaBarangCari.TabIndex = 40;
            // 
            // TxtBoxStock
            // 
            this.TxtBoxStock.Location = new System.Drawing.Point(145, 325);
            this.TxtBoxStock.Name = "TxtBoxStock";
            this.TxtBoxStock.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxStock.TabIndex = 60;
            // 
            // TxtBoxNamaSupplier
            // 
            this.TxtBoxNamaSupplier.Location = new System.Drawing.Point(145, 373);
            this.TxtBoxNamaSupplier.Name = "TxtBoxNamaSupplier";
            this.TxtBoxNamaSupplier.Size = new System.Drawing.Size(100, 20);
            this.TxtBoxNamaSupplier.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nama Supplier";
            // 
            // MasterBarang032
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 619);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxNamaSupplier);
            this.Controls.Add(this.TxtBoxStock);
            this.Controls.Add(this.BtnHapus);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.BtnCari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxHarga);
            this.Controls.Add(this.TxtBoxNamaBarang);
            this.Controls.Add(this.TxtBoxID);
            this.Controls.Add(this.TxtBoxNamaSupplierCari);
            this.Controls.Add(this.TxtBoxNamaBarangCari);
            this.Name = "MasterBarang032";
            this.Text = "MasterBarang032";
            this.Load += new System.EventHandler(this.MasterBarang032_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHapus;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnCari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxHarga;
        private System.Windows.Forms.TextBox TxtBoxNamaBarang;
        private System.Windows.Forms.TextBox TxtBoxID;
        private System.Windows.Forms.TextBox TxtBoxNamaSupplierCari;
        private System.Windows.Forms.TextBox TxtBoxNamaBarangCari;
        private System.Windows.Forms.TextBox TxtBoxStock;
        private System.Windows.Forms.TextBox TxtBoxNamaSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
namespace KutuphaneOtomasyonWinForm.kitaplar
{
    partial class kitaplarEkle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adKitaptxt = new System.Windows.Forms.TextBox();
            this.yazarKitaptxt = new System.Windows.Forms.TextBox();
            this.yayineviKitaptxt = new System.Windows.Forms.TextBox();
            this.turKitaptxt = new System.Windows.Forms.TextBox();
            this.sayfaKitapNumeric = new System.Windows.Forms.NumericUpDown();
            this.tarihKitapDTP = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaKitapNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 607);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Yazarı :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 139);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Yayınevi :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 173);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(70, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Basım Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kitap Türü :";
            // 
            // adKitaptxt
            // 
            this.adKitaptxt.Location = new System.Drawing.Point(85, 79);
            this.adKitaptxt.Name = "adKitaptxt";
            this.adKitaptxt.Size = new System.Drawing.Size(161, 20);
            this.adKitaptxt.TabIndex = 7;
            // 
            // yazarKitaptxt
            // 
            this.yazarKitaptxt.Location = new System.Drawing.Point(85, 107);
            this.yazarKitaptxt.Name = "yazarKitaptxt";
            this.yazarKitaptxt.Size = new System.Drawing.Size(161, 20);
            this.yazarKitaptxt.TabIndex = 8;
            // 
            // yayineviKitaptxt
            // 
            this.yayineviKitaptxt.Location = new System.Drawing.Point(85, 136);
            this.yayineviKitaptxt.Name = "yayineviKitaptxt";
            this.yayineviKitaptxt.Size = new System.Drawing.Size(161, 20);
            this.yayineviKitaptxt.TabIndex = 9;
            // 
            // turKitaptxt
            // 
            this.turKitaptxt.Location = new System.Drawing.Point(85, 224);
            this.turKitaptxt.Name = "turKitaptxt";
            this.turKitaptxt.Size = new System.Drawing.Size(164, 20);
            this.turKitaptxt.TabIndex = 12;
            // 
            // sayfaKitapNumeric
            // 
            this.sayfaKitapNumeric.Location = new System.Drawing.Point(85, 166);
            this.sayfaKitapNumeric.Name = "sayfaKitapNumeric";
            this.sayfaKitapNumeric.Size = new System.Drawing.Size(161, 20);
            this.sayfaKitapNumeric.TabIndex = 13;
            // 
            // tarihKitapDTP
            // 
            this.tarihKitapDTP.Location = new System.Drawing.Point(85, 195);
            this.tarihKitapDTP.Name = "tarihKitapDTP";
            this.tarihKitapDTP.Size = new System.Drawing.Size(164, 20);
            this.tarihKitapDTP.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitaplarEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1075, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarihKitapDTP);
            this.Controls.Add(this.sayfaKitapNumeric);
            this.Controls.Add(this.turKitaptxt);
            this.Controls.Add(this.yayineviKitaptxt);
            this.Controls.Add(this.yazarKitaptxt);
            this.Controls.Add(this.adKitaptxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "kitaplarEkle";
            this.Text = "kitaplarEkle";
            this.Load += new System.EventHandler(this.kitaplarEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sayfaKitapNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adKitaptxt;
        private System.Windows.Forms.TextBox yazarKitaptxt;
        private System.Windows.Forms.TextBox yayineviKitaptxt;
        private System.Windows.Forms.TextBox turKitaptxt;
        private System.Windows.Forms.NumericUpDown sayfaKitapNumeric;
        private System.Windows.Forms.DateTimePicker tarihKitapDTP;
        private System.Windows.Forms.Button button1;
    }
}
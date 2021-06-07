
namespace CodeFirstProject
{
    partial class Ekran6Form
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
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHepsiniGoster = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txbVize = new System.Windows.Forms.TextBox();
            this.txbFinal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders";
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(48, 10);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 21);
            this.cmbDers.TabIndex = 1;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(175, 10);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Göster";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğrenci No";
            // 
            // cmbOgrenciNo
            // 
            this.cmbOgrenciNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciNo.FormattingEnabled = true;
            this.cmbOgrenciNo.Location = new System.Drawing.Point(16, 60);
            this.cmbOgrenciNo.Name = "cmbOgrenciNo";
            this.cmbOgrenciNo.Size = new System.Drawing.Size(121, 21);
            this.cmbOgrenciNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Final";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(417, 280);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnHepsiniGoster
            // 
            this.btnHepsiniGoster.Location = new System.Drawing.Point(308, 10);
            this.btnHepsiniGoster.Name = "btnHepsiniGoster";
            this.btnHepsiniGoster.Size = new System.Drawing.Size(125, 23);
            this.btnHepsiniGoster.TabIndex = 11;
            this.btnHepsiniGoster.Text = "Tüm Verileri Göster";
            this.btnHepsiniGoster.UseVisualStyleBackColor = true;
            this.btnHepsiniGoster.Click += new System.EventHandler(this.btnHepsiniGoster_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(355, 58);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(78, 23);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txbVize
            // 
            this.txbVize.Location = new System.Drawing.Point(143, 60);
            this.txbVize.Name = "txbVize";
            this.txbVize.Size = new System.Drawing.Size(100, 20);
            this.txbVize.TabIndex = 15;
            // 
            // txbFinal
            // 
            this.txbFinal.Location = new System.Drawing.Point(249, 60);
            this.txbFinal.Name = "txbFinal";
            this.txbFinal.Size = new System.Drawing.Size(100, 20);
            this.txbFinal.TabIndex = 16;
            // 
            // Ekran6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 384);
            this.Controls.Add(this.txbFinal);
            this.Controls.Add(this.txbVize);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnHepsiniGoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOgrenciNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.label1);
            this.Name = "Ekran6Form";
            this.Text = "Ekran 6";
            this.Load += new System.EventHandler(this.Ekran6Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOgrenciNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHepsiniGoster;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txbVize;
        private System.Windows.Forms.TextBox txbFinal;
    }
}
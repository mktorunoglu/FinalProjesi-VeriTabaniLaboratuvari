
namespace CodeFirstProject
{
    partial class Ekran4Form
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
            this.cmbOgrenciNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.cmbYariyil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // cmbOgrenciNo
            // 
            this.cmbOgrenciNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgrenciNo.FormattingEnabled = true;
            this.cmbOgrenciNo.Location = new System.Drawing.Point(12, 25);
            this.cmbOgrenciNo.Name = "cmbOgrenciNo";
            this.cmbOgrenciNo.Size = new System.Drawing.Size(121, 21);
            this.cmbOgrenciNo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yıl";
            // 
            // cmbYil
            // 
            this.cmbYil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Items.AddRange(new object[] {
            "2017-2018",
            "2018-2019",
            "2019-2020",
            "2020-2021"});
            this.cmbYil.Location = new System.Drawing.Point(139, 25);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(121, 21);
            this.cmbYil.TabIndex = 4;
            // 
            // cmbYariyil
            // 
            this.cmbYariyil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYariyil.FormattingEnabled = true;
            this.cmbYariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbYariyil.Location = new System.Drawing.Point(266, 25);
            this.cmbYariyil.Name = "cmbYariyil";
            this.cmbYariyil.Size = new System.Drawing.Size(121, 21);
            this.cmbYariyil.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yarıyıl";
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(139, 67);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 21);
            this.cmbDers.TabIndex = 10;
            // 
            // cmbBolum
            // 
            this.cmbBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(12, 67);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(121, 21);
            this.cmbBolum.TabIndex = 8;
            this.cmbBolum.SelectedIndexChanged += new System.EventHandler(this.cmbBolum_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bölüm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ders";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(393, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(393, 36);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(393, 65);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(456, 344);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ekran4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.cmbYariyil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOgrenciNo);
            this.Controls.Add(this.label1);
            this.Name = "Ekran4Form";
            this.Text = "Ekran 4";
            this.Load += new System.EventHandler(this.Ekran4Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgrenciNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.ComboBox cmbYariyil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
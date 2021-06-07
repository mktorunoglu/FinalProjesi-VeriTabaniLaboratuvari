
namespace CodeFirstProject
{
    partial class Ekran5Form
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
            this.btnOgrenciGoster = new System.Windows.Forms.Button();
            this.txbOgrenciNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnHepsiniGoster = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbYariyil = new System.Windows.Forms.ComboBox();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDersGoster = new System.Windows.Forms.Button();
            this.btnHepsiniGoster2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // btnOgrenciGoster
            // 
            this.btnOgrenciGoster.Location = new System.Drawing.Point(118, 41);
            this.btnOgrenciGoster.Name = "btnOgrenciGoster";
            this.btnOgrenciGoster.Size = new System.Drawing.Size(75, 23);
            this.btnOgrenciGoster.TabIndex = 1;
            this.btnOgrenciGoster.Text = "Göster";
            this.btnOgrenciGoster.UseVisualStyleBackColor = true;
            this.btnOgrenciGoster.Click += new System.EventHandler(this.btnOgrenciGoster_Click);
            // 
            // txbOgrenciNo
            // 
            this.txbOgrenciNo.Location = new System.Drawing.Point(12, 43);
            this.txbOgrenciNo.Name = "txbOgrenciNo";
            this.txbOgrenciNo.Size = new System.Drawing.Size(100, 20);
            this.txbOgrenciNo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(235, 369);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnHepsiniGoster
            // 
            this.btnHepsiniGoster.Location = new System.Drawing.Point(118, 12);
            this.btnHepsiniGoster.Name = "btnHepsiniGoster";
            this.btnHepsiniGoster.Size = new System.Drawing.Size(129, 23);
            this.btnHepsiniGoster.TabIndex = 4;
            this.btnHepsiniGoster.Text = "Tüm Verileri Göster";
            this.btnHepsiniGoster.UseVisualStyleBackColor = true;
            this.btnHepsiniGoster.Click += new System.EventHandler(this.btnHepsiniGoster_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(272, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(390, 369);
            this.dataGridView2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yarıyıl";
            // 
            // cmbYariyil
            // 
            this.cmbYariyil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYariyil.FormattingEnabled = true;
            this.cmbYariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbYariyil.Location = new System.Drawing.Point(460, 43);
            this.cmbYariyil.Name = "cmbYariyil";
            this.cmbYariyil.Size = new System.Drawing.Size(121, 21);
            this.cmbYariyil.TabIndex = 7;
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
            this.cmbYil.Location = new System.Drawing.Point(293, 43);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(121, 21);
            this.cmbYil.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yıl";
            // 
            // btnDersGoster
            // 
            this.btnDersGoster.Location = new System.Drawing.Point(587, 41);
            this.btnDersGoster.Name = "btnDersGoster";
            this.btnDersGoster.Size = new System.Drawing.Size(75, 23);
            this.btnDersGoster.TabIndex = 10;
            this.btnDersGoster.Text = "Göster";
            this.btnDersGoster.UseVisualStyleBackColor = true;
            this.btnDersGoster.Click += new System.EventHandler(this.btnDersGoster_Click);
            // 
            // btnHepsiniGoster2
            // 
            this.btnHepsiniGoster2.Location = new System.Drawing.Point(533, 12);
            this.btnHepsiniGoster2.Name = "btnHepsiniGoster2";
            this.btnHepsiniGoster2.Size = new System.Drawing.Size(129, 23);
            this.btnHepsiniGoster2.TabIndex = 11;
            this.btnHepsiniGoster2.Text = "Tüm Verileri Göster";
            this.btnHepsiniGoster2.UseVisualStyleBackColor = true;
            this.btnHepsiniGoster2.Click += new System.EventHandler(this.btnHepsiniGoster2_Click);
            // 
            // Ekran5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.btnHepsiniGoster2);
            this.Controls.Add(this.btnDersGoster);
            this.Controls.Add(this.cmbYil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbYariyil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnHepsiniGoster);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbOgrenciNo);
            this.Controls.Add(this.btnOgrenciGoster);
            this.Controls.Add(this.label1);
            this.Name = "Ekran5Form";
            this.Text = "Ekran 5";
            this.Load += new System.EventHandler(this.Ekran5Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciGoster;
        private System.Windows.Forms.TextBox txbOgrenciNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHepsiniGoster;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbYariyil;
        private System.Windows.Forms.ComboBox cmbYil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDersGoster;
        private System.Windows.Forms.Button btnHepsiniGoster2;
    }
}
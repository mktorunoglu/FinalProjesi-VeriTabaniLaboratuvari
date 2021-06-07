using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstProject
{
    public partial class DerslerForm : Form
    {
        public DerslerForm()
        {
            InitializeComponent();
        }

        private void DerslerForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            VeriListele();
            cmbBolum.DataSource = db.Bolumlers.ToList();
            cmbBolum.DisplayMember = "bolumAd";
            cmbBolum.ValueMember = "bolumID";
        }

        public void VeriListele()
        {
            Model1 db = new Model1();
            dataGridView1.DataSource = db.Derslers.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txbDersNo.Text = row.Cells["dersID"].Value.ToString();
            txbDers.Text = row.Cells["dersAd"].Value.ToString();
            cmbBolum.SelectedValue = row.Cells["bolumID"].Value;
        }

        public void clearAll()
        {
            txbDersNo.Clear();
            txbDers.Clear();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            Dersler ders = new Dersler();
            ders.dersID = Int16.Parse(txbDersNo.Text);
            ders.dersAd = txbDers.Text;
            ders.bolumID = (int)cmbBolum.SelectedValue;
            db.Derslers.Add(ders);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int guncellenecek_id = Int16.Parse(txbDersNo.Text);
            Dersler guncellenecek_ders = db.Derslers.SingleOrDefault(ders => ders.dersID == guncellenecek_id);
            guncellenecek_ders.dersID = Int16.Parse(txbDersNo.Text);
            guncellenecek_ders.dersAd = txbDers.Text;
            guncellenecek_ders.bolumID = (int)cmbBolum.SelectedValue;
            db.SaveChanges();
            VeriListele();
            clearAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            int silinecek_id = Int16.Parse(txbDersNo.Text);
            Dersler silinecek_ders = db.Derslers.SingleOrDefault(ders => ders.dersID == silinecek_id);
            db.Derslers.Remove(silinecek_ders);
            db.SaveChanges();
            VeriListele();
            clearAll();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = db.TBLURUN.ToList();
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.ID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM
                                        }).ToList(); 
            //yukarda yotum satırında olan bu kod listeleme yaptıgımızda sonda birbiri arasında ilişkili olan bolumleride yazardı
            //ama yorum satırı icinde olmayan kod sayesinde onlar duzeni ve gorunuyu bozmuyolralar. Suan calıstırılırsa urun kısmında listelemede
            //gozukmez cunku biz neleri  listeye alacagına zaten karar verdik.
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = txtad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.FIYAT = decimal.Parse( txtfiyat.Text);
            t.KATEGORI = int.Parse(cmbktgr.SelectedValue.ToString());
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme kaydedildi");

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi.");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var urun = db.TBLURUN.Find(x);
            //altta tum hepsini yazıp guncelleme işlemini yapmadık ,yapadabilirdik.
            urun.URUNAD=txtad.Text;
            urun.STOK = short.Parse(txtstok.Text);
            urun.MARKA=txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.");

        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {x.ID,x.AD
                               }).ToList();
            cmbktgr.ValueMember = "ID";
            cmbktgr.DisplayMember = "AD";
            cmbktgr.DataSource = kategoriler;
        }
    }
}

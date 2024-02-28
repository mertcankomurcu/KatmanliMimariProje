using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using BusinessLayer;

namespace KatmanliMimariProje
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = TxtAd.Text;
            ent.Soyad=TxtSoyad.Text;
            ent.Numara=TxtNumara.Text;
            ent.Bolum=TxtBolum.Text;
            BLOgrenci.OgrenciEkleBL(ent);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            List<EntityOgrenci> ogrenciler = BLOgrenci.OgrenciListesiBL();
            dataGridView1.DataSource=ogrenciler;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int deger = int.Parse(TxtID.Text);
            EntityOgrenci ent = new EntityOgrenci();
            ent.OgrID = deger;
            BLOgrenci.OgrenciSilBL(ent.OgrID);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad=TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Bolum = TxtBolum.Text;
            ent.Numara= TxtNumara.Text;
            ent.OgrID = int.Parse(TxtID.Text);
            BLOgrenci.OgrenciGuncelleBL(ent);
        }
    }
}

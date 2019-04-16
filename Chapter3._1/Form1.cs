using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Chapter3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtTukar_Click(object sender, EventArgs e)
        {
            QRManager.TukarInfo(ref tbNamaPenerima, ref tbNamaPengirim);
            QRManager.TukarInfo(ref tbAlamatAsal, ref tbAlamatTujuan);
            QRManager.TukarInfo(ref tbHpPenerima, ref tbHpPengirim);
        }

        private void BtProses_Click(object sender, EventArgs e)
        {
            Bitmap qr;
            tbQrText.Text = QRManager.GenerateInfo(
            tbNamaPengirim.Text,
            tbAlamatAsal.Text,
            tbHpPengirim.Text,
            tbNamaPengirim.Text,
            tbAlamatTujuan.Text,
            tbHpPenerima.Text,
            out qr);
            pbQR.BackgroundImage = qr;
        }
    }
}
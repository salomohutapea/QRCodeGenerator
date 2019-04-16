using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
// Harus tambah reference pakai NuGet PM> Install-Package QRCoder
using QRCoder;

namespace Chapter3._1
{
    class QRManager
    {
        public static void TukarInfo(ref TextBox textBox1, ref TextBox textBox2)
        {
            string temp = textBox1.Text;
            textBox1.Text = textBox2.Text;
            textBox2.Text = temp;
        }
        public static string GenerateInfo(string namaAsal, string alamatAsal, string
        NoHpAsal,
        string namaTujuan, string alamatTujuan, string NoHpTujuan)
        {
            string result = "#" + namaAsal + "*" + alamatAsal + "*" + NoHpAsal +
            "*" + namaTujuan + "*" + alamatTujuan + "*" + NoHpTujuan;
            return result;
        }
        public static string GenerateInfo(string namaAsal, string alamatAsal, string
        NoHpAsal,
        string namaTujuan, string alamatTujuan, string NoHpTujuan, out Bitmap
        QrBitmap)
        {

            string text = GenerateInfo(namaAsal, alamatAsal, NoHpAsal, namaTujuan,
            alamatTujuan, NoHpTujuan);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text,
            QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            QrBitmap = qrCode.GetGraphic(4);
            return text;
        }
    }
}
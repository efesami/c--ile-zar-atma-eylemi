using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Zar_Atma_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start(); // butona basınca timer ı baslat
            button1.Enabled = false; // timer baslayınca(butona basınca) button1 adlı nesneyi pasif yap


        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Random random71 = new Random(); // random sınıfından random71 adında bir rastgele nesnesi ürettim.
            int zar1, zar2; // int türünde 2 adet zar isimli değişkenler ürettm.
            zar1 = random71.Next(0, 6); //  üretilecek olan sayı aralıgını belirttim. // next metodu üretebilecegimiz sayı aralığını belirtir.
            zar2 = random71.Next(0, 6);  //  üretilecek olan sayı aralıgını belirttim. // burada 0 dahil 6 dahil değildir. çünkü eklediğim resimler dizinin indexi seklinde sıralanır. indexler 0. ile basladıgı için 0-6 yaptım max 5 i üretir demek..
            pictureBox1.Image = ımageList1.Images[zar1]; // pıcturebox un imajına imagelistin ımageslerden birini rastgle atadık zar1 ve zar2 adındakı rastgele degiskenlerinden
            pictureBox2.Image = ımageList1.Images[zar2];

            sayac++;
            if (sayac==30)
            {
                button1.Enabled = true; // sayac zamanına ulasınca button1 adlı nesneyi aktif yap
                timer1.Stop(); // sayac zamanına ulasınca timeri durdur.
                sayac = 0; // sayacı sıfırla

            }
        }
    }
}

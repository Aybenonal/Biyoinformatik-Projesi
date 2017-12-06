using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double q = Convert.ToDouble(textBox1.Text);
                double p = Convert.ToDouble(textBox2.Text);
                if (q >= 0 && q <= 1 && p >= 0 && p <= 1)
                {
                    double hesapla = ((1.0 / 2.0) * Math.Log(1.0 / (1.0 - (2.0 * (double)p) - (double)q))) + ((1.0 / 4.0) * Math.Log(1.0 / (1.0 - (2.0 * (double)q))));
                    richTextBox1.SelectedText = "K Değeri = " + hesapla.ToString();
                    richTextBox1.SelectedText = Environment.NewLine + "Sonuç = İki Soyda " + Convert.ToInt32(hesapla * 100) + " yer degiştirme vardı. Sonuçta " + (Convert.ToInt32(p * 100 + q * 100)) + " fark oluştu";
                }
                else
                {
                    MessageBox.Show("Değerlerinizi kontrol ediniz. Transisyon=1 ise (0,01) yazınız. ");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Veriler hatalı kontrol edin.");
            }
        }
    }
}

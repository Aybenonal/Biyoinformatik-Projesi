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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            { 
                
               
                   double p = Convert.ToDouble(textBox1.Text);
                if (p >= 0 && p<=0.75)
                {
                    double hesapla = (((-1.0) * (3.0 / 4.0)) * Math.Log((1.0 - ((4.0 / 3.0) * (double)p))));
                    richTextBox1.SelectedText = Environment.NewLine + "K Değeri = " + hesapla.ToString();
                    richTextBox1.SelectedText = Environment.NewLine + "Sonuç = İki Soyda " + Convert.ToInt32(hesapla*100) + " yer degiştirme vardı. Sonuçta " + (Convert.ToInt32(p * 100)) + " fark oluştu";
                }
                else
                {
                    MessageBox.Show("Girilen değer 0-0.75 arasında olmalı.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Veriler hatalı kontrol edin.");
            }


        }
    }
}

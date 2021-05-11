using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, proje, NotOrtalama;
            vize  = Convert.ToDouble(textVize.Text);
            final = Convert.ToDouble(textFinal.Text);
            proje = Convert.ToDouble(textProje.Text);
            NotOrtalama = vize * 0.40 + final * 0.50 + proje * 0.10;
            if (NotOrtalama >= 40)
            {
                textSonuc.Text = NotOrtalama + "/"+"Geçti!";
            }
            else
                textSonuc.Text = NotOrtalama + "/" + "Kaldı!";
        }
    }
}

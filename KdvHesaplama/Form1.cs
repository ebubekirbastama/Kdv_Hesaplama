using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace KdvHesaplama
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<double> degerler = new List<double>();
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Hide();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            degerler.Add(Convert.ToDouble(txt_urnfyt.Text)); degerler.Add(Convert.ToDouble(nmr_kdv.Value));
            degerler.Add(Convert.ToDouble(degerler[0]+(degerler[0] * degerler[1] / 100)));
            metroTextBox1.Text = degerler[2].ToString();
            degerler.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.ebubekirbastama.com");
        }
    }
}

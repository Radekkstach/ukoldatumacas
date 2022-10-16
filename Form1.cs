using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukoldatumacas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] osoby = textBox1.Lines;
            string[] radek;
            string datum;
            int index = 0;
            int pomocna = 0;
            try
            {
                TimeSpan rozdil;
                int maximum = 0;
                foreach (string text in osoby)
                {
                    radek = text.Split(';');
                    datum = radek[2];
                    rozdil = DateTime.Now - DateTime.Parse(datum);
                    if(rozdil.Days >= maximum)
                    {
                        maximum = rozdil.Days;
                        pomocna = index;
                    }
                    index++;
                    
                }
                label1.Text = "Nejstarsi je: " + (osoby[pomocna]).Substring(0, (osoby[pomocna]).LastIndexOf(';')).Replace(';',' ') + " Je mu " + (maximum/365);

            }
            catch
            {
                MessageBox.Show("ne");
            }
        }
    }
}

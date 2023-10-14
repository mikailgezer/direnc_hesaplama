using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace direnc_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string renk1;
            string renk2;
            string carpanrenk;
            string toleransrenk;

            double  renk1deg = 0;
            double  renk2deg = 0;
            double  carpandeg =0;
            double  tolerans =0 ;

            renk1 = comboBox1.SelectedItem.ToString();
            renk2 = comboBox2.SelectedItem.ToString();
            carpanrenk  = comboBox3.SelectedItem.ToString();
            toleransrenk  = comboBox4.SelectedItem.ToString();

            double direncdeg = 0;
            double toldeg = 0;


            switch (renk1)
            {
                case "Siyah":
                    renk1deg = 0;
                    break;
                case "Kahverengi":
                    renk1deg = 1;
                    break;
                case "Kirmizi":
                    renk1deg = 2;
                    break;
                case "Turuncu":
                    renk1deg = 3;
                    break;
                case "Sari":
                    renk1deg = 4;
                    break;
                case "Yesil":
                    renk1deg = 5;
                    break;
                case "Mavi":
                    renk1deg = 6;
                    break;
                case "Mor":
                    renk1deg = 7;
                    break;
                case "Gri":
                    renk1deg = 8;
                    break;
                case "Beyaz":
                    renk1deg = 9;
                    break;
                default:
                    MessageBox.Show("İlk rengi giriniz.");
                    break;
            }

            switch (renk2)
            {
                case "Siyah":
                    renk2deg = 0;
                    break;
                case "Kahverengi":
                    renk2deg = 1;
                    break;
                case "Kirmizi":
                    renk2deg = 2;
                    break;
                case "Turuncu":
                    renk2deg = 3;
                    break;
                case "Sari":
                    renk2deg = 4;
                    break;
                case "Yesil":
                    renk2deg = 5;
                    break;
                case "Mavi":
                    renk2deg = 6;
                    break;
                case "Mor":
                    renk2deg = 7;
                    break;
                case "Gri":
                    renk2deg = 8;
                    break;
                case "Beyaz":
                    renk2deg = 9;
                    break;
                default:
                    MessageBox.Show("İkinci rengi giriniz.");
                    break;
            }

            switch (carpanrenk)
            {
                case "Siyah":
                    carpandeg = 0;
                    break;
                case "Kahverengi":
                    carpandeg = 1;
                    break;
                case "Kirmizi":
                    carpandeg = 2;
                    break;
                case "Turuncu":
                    carpandeg = 3;
                    break;
                case "Sari":
                    carpandeg = 4;
                    break;
                case "Yesil":
                    carpandeg = 5;
                    break;
                case "Mavi":
                    carpandeg = 6;
                    break;
                case "Mor":
                    carpandeg = 7;
                    break;
                case "Gri":
                    carpandeg = 8;
                    break;
                case "Beyaz":
                    carpandeg = 9;
                    break;
                default:
                    MessageBox.Show("Üçüncü rengi giriniz.");
                    break;
            }

            switch (toleransrenk )
            {
                case "Altin":
                    tolerans  = 5;
                    break;
                case "Gumus":
                    tolerans = 10;
                    break;
                default:
                    MessageBox.Show("Dördüncü rengi giriniz.");
                    break;
            }

            direncdeg = (renk1deg * 10 + renk2deg) * Math.Pow(10, carpandeg);

            lblSonuc.Text = direncdeg.ToString () + "Ω" + "  % " + tolerans .ToString() + "Ω";

            toldeg = direncdeg * (tolerans  / 100);
            lblTolDeger.Text = toldeg.ToString() + "Ω";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string renk1;
            renk1 = comboBox1.SelectedItem.ToString();

            switch (renk1)
            {
                case "Siyah":
                    button2.BackColor = Color.Black;
                    break;
                case "Kahverengi":
                    button2.BackColor = Color.Brown;
                    break;
                case "Kirmizi":
                    button2.BackColor = Color.Red;
                    break;
                case "Turuncu":
                    button2.BackColor = Color.OrangeRed;
                    break;
                case "Sari":
                    button2.BackColor = Color.Yellow;
                    break;
                case "Yesil":
                    button2.BackColor = Color.Green;
                    break;
                case "Mavi":
                    button2.BackColor = Color.Blue;
                    break;
                case "Mor":
                    button2.BackColor = Color.Purple;
                    break;
                case "Gri":
                    button2.BackColor = Color.Gray;
                    break;
                case "Beyaz":
                    button2.BackColor = Color.White;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string renk2;
            renk2 = comboBox2.SelectedItem.ToString();

            switch (renk2)
            {
                case "Siyah":
                    button3.BackColor = Color.Black;
                    break;
                case "Kahverengi":
                    button3.BackColor = Color.Brown;
                    break;
                case "Kirmizi":
                    button3.BackColor = Color.Red;
                    break;
                case "Turuncu":
                    button3.BackColor = Color.OrangeRed;
                    break;
                case "Sari":
                    button3.BackColor = Color.Yellow;
                    break;
                case "Yesil":
                    button3.BackColor = Color.Green;
                    break;
                case "Mavi":
                    button3.BackColor = Color.Blue;
                    break;
                case "Mor":
                    button3.BackColor = Color.Purple;
                    break;
                case "Gri":
                    button3.BackColor = Color.Gray;
                    break;
                case "Beyaz":
                    button3.BackColor = Color.White;
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carpanrenk;
            carpanrenk = comboBox3.SelectedItem.ToString();

            switch (carpanrenk )
            {
                case "Siyah":
                    button4.BackColor = Color.Black;
                    break;
                case "Kahverengi":
                    button4.BackColor = Color.Brown;
                    break;
                case "Kirmizi":
                    button4.BackColor = Color.Red;
                    break;
                case "Turuncu":
                    button4.BackColor = Color.OrangeRed;
                    break;
                case "Sari":
                    button4.BackColor = Color.Yellow;
                    break;
                case "Yesil":
                    button4.BackColor = Color.Green;
                    break;
                case "Mavi":
                    button4.BackColor = Color.Blue;
                    break;
                case "Mor":
                    button4.BackColor = Color.Purple;
                    break;
                case "Gri":
                    button4.BackColor = Color.Gray;
                    break;
                case "Beyaz":
                    button4.BackColor = Color.White;
                    break;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string toleransrenk;
            toleransrenk = comboBox4.SelectedItem.ToString();

            switch (toleransrenk)
            {
                case "Altin":
                    button5.BackColor = Color.Gold;
                    break;
                case "Gumus":
                    button5.BackColor = Color.Silver;
                    break;
            }
        }
    }
}

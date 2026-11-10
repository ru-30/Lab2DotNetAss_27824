using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2DotNetAss
{
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Lab2DotNetAss.LoginForm login = new Lab2DotNetAss.LoginForm();

            login.ShowDialog();




        }

        private void Bicycle_Load(object sender, EventArgs e)
        {

        }

        //private void fee_Click(object sender, EventArgs e)
        //{
            private void fee_Click(object sender, EventArgs e)
        {
            int start, end;

            // 1. Reba ko ari imibare yuzuye
            if (!int.TryParse(textstart.Text, out start) || !int.TryParse(textend.Text, out end))
            {
                MessageBox.Show("Andika imibare yuzuye gusa (nta decimal).");
                return;
            }

            // 2. Reba niba Start irenze End
            if (start > end)
            {
                MessageBox.Show("Ikosa: Start Hour ntishobora kurenza End Hour!");
                textstart.Clear();
                return;
            }

            // 3. Reba niba Start ingana na End
            if (start == end)
            {
                MessageBox.Show("Ikosa: Start Hour na End Hour ntibyareshya.");
                textend.Clear();
                return;
            }

            // 4. Reba ibyemewe (0-23 na 1-24)
            if (start < 0 || start > 23 || end < 1 || end > 24)
            {
                MessageBox.Show("Start iri hagati ya 0 na 23, End iri hagati ya 1 na 24.");
                textstart.Clear();
                return;
            }

            // 5. Kubara igiciro
            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7 || hour >= 21)
                    total += 500;
                else if (hour < 14 || hour >= 19)
                    total += 1000;
                else
                    total += 1500;
            }

            textfee.Text = total + " RWF";
        }
    }
    //}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2DotNetAss
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bicycle_Click(object sender, EventArgs e)
        {
            Lab2DotNetAss.Bicycle bicycle = new Lab2DotNetAss.Bicycle();
            
            bicycle.Show();
            
        }

        private void mushroom_Click(object sender, EventArgs e)
        {
            Lab2DotNetAss.mushroom mushroom = new Lab2DotNetAss.mushroom();
          
            mushroom.Show();
            
        }
    }
}

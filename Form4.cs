using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2DotNetAss
{
    public partial class mushroom : Form
    {
        public mushroom()
        {
            InitializeComponent();
        }

        // Shows the question with Yes / No buttons, returns true if Yes
        private bool Ask(string question)
        {
            DialogResult answer = MessageBox.Show(question, "Mushroom Question",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            return answer == DialogResult.Yes;
        }

        private void identify_Click(object sender, EventArgs e)
        {
            string result;
            textmushroom.Clear();

            // Question 1
            if (Ask("Does your mushroom have a convex cup?"))
            {
                // Agaric Jaunissant, Amanite tue-mouche, Pied bleu
                if (!Ask("Does your mushroom grow in a forest?"))
                {
                    result = "Agaric Jaunissant";
                }
                else if (Ask("Does your mushroom have a ring?"))
                {
                    result = "Amanite tue-mouche";
                }
                else
                {
                    result = "Pied bleu";
                }
            }
            else
            {
                // Cepe de Bordeaux, Coprin chevelu, Girolle
                if (!Ask("Does your mushroom have gills?"))
                {
                    result = "Cepe de Bordeaux";
                }
                else if (Ask("Does your mushroom grow in a forest?"))
                {
                    result = "Girolle";
                }
                else
                {
                    result = "Coprin chevelu";
                }
            }

            textmushroom.Text = result;   // the answer appears in the textbox
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Lab2DotNetAss.LoginForm login = new Lab2DotNetAss.LoginForm();
            login.ShowDialog();
        }

        private void mushroom_Load(object sender, EventArgs e)
        {

        }

        private void Identify_Click_1(object sender, EventArgs e)
        {
            identify_Click(sender, e);
        }
    }
}
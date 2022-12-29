using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame_Vit_Odehnal
{
    public partial class SelectForm : Form
    {
        int charSelected = 0; 

        public SelectForm()
        {
            InitializeComponent();
        }

        private void PBbulba_Click(object sender, EventArgs e)
        {
            charSelected = 1;
            CharChanged();
        }

        private void PBsquirt_Click(object sender, EventArgs e)
        {
            charSelected = 2;
            CharChanged();
        }

        private void PBchar_Click(object sender, EventArgs e)
        {
            charSelected = 3;
            CharChanged();
        }

        void CharChanged()
        {

            if (charSelected == 1) //Bulbasaur
            {
                PBbulba.BackColor = Color.LightGreen;
                PBsquirt.BackColor = Color.White;
                PBchar.BackColor = Color.White;
                PBbulba.BorderStyle = BorderStyle.Fixed3D;
                PBsquirt.BorderStyle = BorderStyle.FixedSingle;
                PBchar.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (charSelected == 2) //Squirtle
            {
                PBsquirt.BackColor = Color.LightSkyBlue;
                PBbulba.BackColor = Color.White;
                PBchar.BackColor = Color.White;
                PBsquirt.BorderStyle = BorderStyle.Fixed3D;
                PBbulba.BorderStyle = BorderStyle.FixedSingle;
                PBchar.BorderStyle = BorderStyle.FixedSingle;

            }
            else if (charSelected == 3) //Charmander
            {
                PBchar.BackColor = Color.IndianRed;
                PBbulba.BackColor= Color.White;
                PBsquirt.BackColor= Color.White;
                PBchar.BorderStyle= BorderStyle.Fixed3D;
                PBbulba.BorderStyle= BorderStyle.FixedSingle;
                PBsquirt.BorderStyle= BorderStyle.FixedSingle;

            }

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (charSelected == 0)
            {
                MessageBox.Show("Please choose your pokemon before starting the battle.", "Choose a Pokemon");
            }
            else

            {
                Battle battle = new Battle(charSelected);
                this.Hide();
                battle.Show();
            }
        }
    }
}

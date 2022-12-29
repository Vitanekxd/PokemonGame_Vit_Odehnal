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
    public partial class Battle : Form
    {
        int charSelected;




        character player;
        character enemy;
        character bulbasaur = new character("Bulbasaur", "Grass", 1, 20,40, "Vine Whip", "Razor Leaf");
        character squirtle = new character("Squirtle", "Water", 2, 35,25, "Water Gun" , "Water Pulse");
        character charmander = new character("Charmander", "Fire", 3, 40,20, "Ember", "Fire Wheel");
        private bool defending;

        public Battle(int choice)
        {
            InitializeComponent();
            charSelected = choice;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (charSelected == 1)
            {
                player = bulbasaur;
                enemy = squirtle;
                PBplayer.Image = Properties.Resources.bulbasaur;
                PBenemy.Image = Properties.Resources._007;
            }
            else if (charSelected == 2)
            {
                player = squirtle;
                enemy = charmander;
                PBplayer.Image = Properties.Resources._007;
                PBenemy.Image = Properties.Resources.charmander;
            }
            else if (charSelected == 3)
            {
                player = charmander;
                enemy = bulbasaur;
                PBplayer.Image = Properties.Resources.charmander;
                PBenemy.Image = Properties.Resources.bulbasaur;
            }

            LBplayer.Text = player.name;
            LBenemy.Text = enemy.name;
            BtnAtk1.Text = player.move1;
            BtnAtk2.Text = player.move2;
        }

        private void BtnAtk1_Click(object sender, EventArgs e)
        {
            LBinfo.Text = player.name + " used " + player.move1;
            LBinfo.Text += enemy.takeDamage(10, 5, player.atk, player.type);

            if (enemy.hp > 0)
            {
                ProgBarEnemy.Value = Convert.ToInt32(enemy.hp);
            }
            else
            {
                ProgBarEnemy.Value = 0;
                MessageBox.Show("The enemy" + enemy.name + " fainted" + Environment.NewLine + "You Won the battle!", "You Won!");

            }
            TimerEnAtk.Enabled = true;
            BtnAtk1.Enabled = false;
            BtnAtk2.Enabled = false;
            BtnDefend.Enabled = false;
        }

        private void BtnAtk2_Click(object sender, EventArgs e)
        {
            LBinfo.Text = player.name + " used " + player.move2;
            enemy.takeDamage(20, 11,player.atk, player.type);

            if (enemy.hp > 0)
            {
                ProgBarEnemy.Value = Convert.ToInt32(enemy.hp);
            }
            else
            {
                ProgBarEnemy.Value = 0;
                MessageBox.Show("The enemy" + enemy.name + " fainted" + Environment.NewLine + "You Won the battle!", "You Won!");
            }
            TimerEnAtk.Enabled = true;
            BtnAtk1.Enabled = false;
            BtnAtk2.Enabled = false;
            BtnDefend.Enabled = false;
        }

        private void TimerEnAtk_Tick(object sender, EventArgs e)
        {
            TimerEnAtk.Enabled = false;

            Random random = new Random();
            int roll = random.Next(1, 3);
             
            if (roll == 1)
            {
                LBinfo.Text = enemy.name + " used " + enemy.move1;
                if (defending == true)
                {
                    LBinfo.Text += Environment.NewLine + "But you Blocked it...";
                } 
                else
                {
                    LBinfo.Text += player.takeDamage(10, 5, enemy.atk, enemy.type);
                }
            }
            else if (roll == 2)
            {
                LBinfo.Text = enemy.name + " used " + enemy.move2;
                if (defending == true)
                {
                    LBinfo.Text += Environment.NewLine + "But you Blocked it...";
                }
                else
                {
                    LBinfo.Text += player.takeDamage(20, 11, enemy.atk, enemy.type);
                }
            }
            



            player.takeDamage(10, 5, enemy.atk, enemy.type);
            if (player.hp > 0)
            {
                ProgBarPlayer.Value = Convert.ToInt32(player.hp);
            }
            else
            {
                ProgBarPlayer.Value = 0;
                MessageBox.Show("Your" + player.name + " fainted." + Environment.NewLine + "You Lost the battle!", "You Lost!");
            }

            BtnAtk1.Enabled = true;
            BtnAtk2.Enabled = true;
            BtnDefend.Enabled = true;
        }

        private void BtnDefend_Click(object sender, EventArgs e)
        {
            defending = true;
            LBinfo.Text = player.name + "prepared to defend";
            TimerEnAtk.Enabled = true;
            BtnAtk1.Enabled = false;
            BtnAtk2.Enabled = false;
            BtnDefend.Enabled = false;
        }

    }
    public class character
    {
        //variables
    public string name;
    public string type;
    public int charNum;
    public double hp = 100;
    public double atk;
    public double def;
    public string move1;
    public string move2;

        //constructors
        public character()
        {

        }

        public character(string n, string t, int cN, int a, int d, string m1, string m2)
        {
            name = n;
            type = t;
            charNum = cN;
            atk = a;
            def = d;
            move1 = m1;
            move2 = m2;
        }

        //method
        public string takeDamage(int dam, int acc, double enAtk, string enType)
        {
            string result = "";
            Random rnd = new Random();
            int roll = rnd.Next(1, 21);
            double critMod = 1;
            double typeMod = 1;

            if (roll >= acc)
            {
                if (roll == 20)
                {
                    critMod = 1.5;
                    result += Environment.NewLine + "Critical Hit!";
                }

                if ((type == "Fire" && enType == "Water") || (type == "Grass" && enType == "Fire") || (type == "Water" && enType == "Grass"))
                {
                    typeMod = 0.8;
                    result += Environment.NewLine + "It wasn't very effective..";
                }
                else if ((type == "Water" && enType == "Fire") || (type == "Fire" && enType == "Grass") || (type == "Grass" && enType == "Water"))
                {
                    typeMod = 1.2;
                    result += Environment.NewLine + "It was Super Effective!";

                }
                    hp -= (enAtk / def) * dam * critMod * typeMod;

            } 

            else
            {
                result += Environment.NewLine + "It missed...";
            }
            return result;


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRollerForDnD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //user enters how many times the dice will be rolled
        //(or how many dices will be rolled)
        private void NumRolls_TextChanged(object sender, EventArgs e)
        {
            
            button1.Enabled = true;

        }

        //where user enters the number of sides the dice has
        private void NumSides_TextChanged(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
        }

        //roll the dice!!!!!!!!
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string rolls = NumRolls.Text;
            string sides = NumSides.Text;

            
            var numrolls = new HashSet<int> {1,2,3,4,5,6,7,8,9};
            //D20 is the highest number for DnD dices
            var numsides = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19,20};

            //converting strings to int
            int count = int.Parse(rolls);
            int faces = int.Parse(sides);

            int result = 0;
            string[] results = new string[count];



            for (int i = 0;i<count;i++)
            {
                int curr = rnd.Next(faces) + 1;
                result += curr;
                results[i] = curr.ToString();

            }
            //what will be shown in results textbox
            //total and numbers on dice
            Results.Text = $"{result}: {string.Join(", ", results)}";

        }


        //where results are output
        private void Results_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Results.ReadOnly = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Program: Rock Paper Scissors Lizard Spock V2
  Author: Kyle McBride A02609917
  Date: 03/27/2014
  Description: Program to allow user to play Rock Paper Scissors Lizard Spock against the computer.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***				*/

namespace Rock_Paper_Scissors_Lizard_Spock_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int generateRandom()
        {
            Random rand = new Random();
            return rand.Next(5) + 1;
        }

        private string computerChoice(int userInput)
        {
            generateRandom();
            if (generateRandom() == 1)
            {
                
            }
        }

        private void rockPB_Click(object sender, EventArgs e)
        {

        }
    }
}

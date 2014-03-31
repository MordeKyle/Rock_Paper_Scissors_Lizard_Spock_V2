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
        //declaring constant variables
        private const string rock =     "Rock";
        private const string paper =    "Paper";
        private const string scissors = "Scissors";
        private const string lizard =   "Lizard";
        private const string spock =    "Spock";
        private const string win =      "You Win!";
        private const string draw =     "Draw";
        private const string lose =     "You lose";

        public Form1()
        {
            InitializeComponent();
        }

        private int generateRandom()
        {
            //generating a random that will be assigned to a string to represent the computer's choice
            Random rand = new Random();
            return rand.Next(5) + 1; //random wil be 1, 2, 3, 4, or 5
        }

        private string getComputerChoice()
        {
            // assigning the reandomly generated number to a string to represent the computer's choice
            generateRandom();

            if (generateRandom() == 1)
            {
                return rock;
            }
            else if (generateRandom() == 2)
            {
                return paper;
            }
            else if (generateRandom() == 3)
            {
                return scissors;
            }
            else if (generateRandom() == 4)
            {
                return lizard;
            }
            else
            {
                return spock;
            }
        }

        private string getResults(string userInput, string computerChoice)
        {
            // taking the user's choice and comparing it to the randomly generated computer choice.
            if (userInput == computerChoice)
            {
                return draw;
            }
            else if (userInput == rock)
            {
                if (computerChoice == paper)
                {
                    return win;
                }
                else if (computerChoice == lizard)
                {
                    return win;
                }
                else
                {
                    return lose;
                }
            }
            else if (userInput == paper)
            {
                if (computerChoice == scissors)
                {
                    return win;
                }
                else if (computerChoice == spock)
                {
                    return win;
                }
                else
                {
                    return lose;
                }
            }
            else if (userInput == scissors)
            {
                if (computerChoice == paper)
                {
                    return win;
                }
                else if (computerChoice == lizard)
                {
                    return win;
                }
                else
                {
                    return lose;
                }
            }
            else if (userInput == lizard)
            {
                if (computerChoice == paper)
                {
                    return win;
                }
                else if (computerChoice == spock)
                {
                    return win;
                }
                else
                {
                    return lose;
                }
            }
            else
            {
                if (computerChoice == rock)
                {
                    return win;
                }
                else if (computerChoice == scissors)
                {
                    return win;
                }
                else
                {
                    return lose;
                }
            }
        }

        private void printResults(string computerChoice, string results) 
        {
            //printing the computer's choice and the results of the game
            computerChoiceLabel.Text = computerChoice;
            resultsLabel.Text = results;
        }

        private void rockPB_Click(object sender, EventArgs e) //user chose rock
        {
            //get the computers choice from a random generator and assignt it to a variable
            string computerChoice = getComputerChoice();
            //compare the user's choice to the computer's choice by passing in the user and computer choice
            //then assigning it to a variable
            string results = getResults(rock, computerChoice);
            //print the computer's choice and the results of the game passing in the preceding variables.
            printResults(computerChoice, results);
        }

        private void paperPB_Click(object sender, EventArgs e)
        {
            //get the computers choice from a random generator and assignt it to a variable
            string computerChoice = getComputerChoice();
            //compare the user's choice to the computer's choice by passing in the user and computer choice
            //then assigning it to a variable
            string results = getResults(paper, computerChoice);
            //print the computer's choice and the results of the game passing in the preceding variables.
            printResults(computerChoice, results);
        }

        private void scissorsPB_Click(object sender, EventArgs e)
        {
            //get the computers choice from a random generator and assignt it to a variable
            string computerChoice = getComputerChoice();
            //compare the user's choice to the computer's choice by passing in the user and computer choice
            //then assigning it to a variable
            string results = getResults(scissors, computerChoice);
            //print the computer's choice and the results of the game passing in the preceding variables.
            printResults(computerChoice, results);
        }

        private void lizardPB_Click(object sender, EventArgs e)
        {
            //get the computers choice from a random generator and assignt it to a variable
            string computerChoice = getComputerChoice();
            //compare the user's choice to the computer's choice by passing in the user and computer choice
            //then assigning it to a variable
            string results = getResults(lizard, computerChoice);
            //print the computer's choice and the results of the game passing in the preceding variables.
            printResults(computerChoice, results);
        }

        private void spockPB_Click(object sender, EventArgs e)
        {
            //get the computers choice from a random generator and assignt it to a variable
            string computerChoice = getComputerChoice();
            //compare the user's choice to the computer's choice by passing in the user and computer choice
            //then assigning it to a variable
            string results = getResults(spock, computerChoice);
            //print the computer's choice and the results of the game passing in the preceding variables.
            printResults(computerChoice, results);
        }
    }
}

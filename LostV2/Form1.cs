/// created by : 
/// date       : 
/// description: A basic text adventure game engine

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostV2
{
    public partial class Form1 : Form
    {
        int scene = 0;  // tracks what part of the game the user is at
        Random randGen = new Random(); // create random generator

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            outputLabel.Text = "You wake one morning and your clock says it's 7:10a.m.\nYou have to catch a plane to see your family for \nChristmas in ten minutes! Will you take a taxi or the \nsubway to get to the airport?";
            redLabel.Text = "Subway";
            blueLabel.Text = "Taxi";
        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.R)       //red button press
            {

                if (scene == 0)
                {
                    scene = 1;
                }

                else if (scene == 1)
                {
                    scene = 3;
                }

                else if (scene == 3)
                {
                    scene = 5;
                }

                else if (scene == 5 || scene == 4)
                {
                    int chance = randGen.Next(1, 11);

                    if (chance > 6)
                    {
                        scene = 8;
                    }
                    else
                    {
                        scene = 10;
                    }
                }

                else if (scene == 6)
                {
                    scene = 12;
                }

                else if (scene == 10)
                {
                    scene = 13;
                }

                else if (scene == 12)
                {
                    scene = 13;
                }

                else if (scene == 14)
                {
                    scene = 15;
                }

                else if (scene == 15)
                {
                    scene = 17;
                }

                else if (scene == 16)
                {
                    scene = 20;
                }

                if(scene == 21)
                {
                    scene = 15;
                }

            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 0)
                {
                    scene = 2;
                }

                else if (scene == 1)
                {
                    scene = 4;
                }

                else if (scene == 4)
                {
                    scene = 5;
                }

                else if (scene == 3)
                {
                    scene = 7;
                }

                else if (scene == 4)
                {
                    int chance = randGen.Next(1, 11);

                    if (chance > 6)
                    {
                        scene = 8;
                    }
                    else
                    {
                        scene = 10;
                    }
                }

                else if (scene == 5)
                {
                    scene = 9;
                }

                else if (scene == 6)
                {
                    scene = 11;
                }

                else if (scene == 10)
                {
                    scene = 14;
                }

                else if (scene == 12)
                {
                    scene = 14;
                }

                else if (scene == 14)
                {
                    scene = 16;
                }

                else if (scene == 15)
                {
                    scene = 19;
                }

                else if (scene == 16)
                {
                    scene = 21;
                }
                //scene 21?
            }
               else if (e.KeyCode == Keys.G)  //green button press
            {
                if (scene == 3)
                {
                    scene = 6;
                }

                else if (scene == 1)
                {
                    scene = 4;
                }

                else if (scene == 15)
                {
                    scene = 18;
                }
            }
            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0: //start scene
                    outputLabel.Text = "You wake one morning and your clock says it's 7:10a.m. You have to catch a plane to see your family for Christmas in ten minutes! Will you take a taxi or the subway to get to the airport?";
                    redLabel.Text = "Subway";
                    blueLabel.Text = "Taxi";
                    break;
                case 1:
                    outputLabel.Text = "Luckily you live near the subway. You grab your packed susitcase and sprint down the street. On your way you see a starbucks. Do you stop for a latte?";
                    redLabel.Text = "No";
                    blueLabel.Text = "Yes";
                    pictureBox.Image = Properties.Resources.suitcase;
                    break;
                case 2:
                    outputLabel.Text = "The taxi takes too long. You miss your plane and your family disowns you.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    pictureBox.Image = Properties.Resources.taxi;
                    break;
                case 3:
                    outputLabel.Text = "You don't get a drink. While daydreaming, you get lost. Should you keep going, turn back or ask for directions?";
                    redLabel.Text = "Keep Going";
                    blueLabel.Text = "Ask a stranger for directions";
                    greenLabel.Text = "Turn Back";
                    pictureBox.Image = Properties.Resources.dreamcloud;
                    break;
                case 4:
                    outputLabel.Text = "There are no customers inside. You quickly get a drink, and finally aproach the subway. You need to buy a ticket. Do you pay debit or get cash from the ATM?";
                    redLabel.Text = "Debit";
                    blueLabel.Text = "ATM";
                    greenLabel.Text = "";
                    pictureBox.Image = Properties.Resources.starbucks;
                    break;
                case 5:
                    outputLabel.Text = "You approach the subway. You need to buy a ticket. Do you pay debit or get cash from the ATM?";
                    redLabel.Text = "Debit";
                    blueLabel.Text = "ATM";
                    greenLabel.Text = "";
                    pictureBox.Image = Properties.Resources.subway;
                    break;
                case 6:
                    outputLabel.Text = "You've been here before. You change direction and find the subway.On your way you find $20. Do you use it to pay for your ticket or do you buy a gift for your family?";
                    redLabel.Text = "Buy a ticket";
                    blueLabel.Text = "Buy a present";
                    pictureBox.Image = Properties.Resources.money;
                    break;
                case 7:
                    outputLabel.Text = "A stranger leads you to a sketchy neighborhood. You end up witnessing a crime and are taken to the police staiton. You miss the plane.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    pictureBox.Image = Properties.Resources.jail;
                    break;
                case 8:
                    outputLabel.Text = "They don't have a debit machine and you can't get cash in time. You miss the plane because the subway station is stuck in the past.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    pictureBox.Image = Properties.Resources.debit;
                    break;
                case 9:
                    outputLabel.Text = "The line for the ATM takes to long and you miss the plane.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    pictureBox.Image = Properties.Resources.line;
                    break;
                case 10:
                    outputLabel.Text = "You buy your ticket with debit and get on the next train. You arrive at the airport, and you really need the washroom. Do you have time to go?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    pictureBox.Image = Properties.Resources.restroom;
                    break;
                case 11:
                    outputLabel.Text = "You buy your family a present, but now you have no cash. The line for the ATM takes to long and you miss the plane.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    break;
                case 12:
                    outputLabel.Text = "You find the subway and get on the next train. You arrive at the airport, and you really need the washroom. Do you have time to go?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "By the time you come back from the washroom you've missed the plane";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    break;
                case 14:
                    outputLabel.Text = "You decide to wait and run to your gate. The plane is boarding. You take your seat, but you can't find your phone. Do you try to find it or stay in your seat?";
                    redLabel.Text = "Stay in your seat";
                    blueLabel.Text = "Find your phone";
                    break;
                case 15:
                    outputLabel.Text = "The plane takes off. A flight attendant asks what kind of snacks you want. What do you pick?";
                    redLabel.Text = "Crackers";
                    blueLabel.Text = "Nothing";
                    greenLabel.Text = "Cookies";
                    break;
                case 16:
                    outputLabel.Text = "You get up and retrace your path looking for your phone. You can't find it anywhere and the plane is about to leave. Keep looking?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "The crackers aren't nut free. You have an allergic reaction and die.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    break;
                case 18:
                    outputLabel.Text = "The cookies make you forget about loosing your phone. You sleep the rest of the ride.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You win";
                    restartButton.Visible = true;
                    break;
                case 19:
                    outputLabel.Text = "You fall asleep for the rest of the ride";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You win";
                    restartButton.Visible = true;
                    break;
                case 20:
                    outputLabel.Text = "You miss the plane and your family disowns you.";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    loseLabel.Text = "You loose";
                    restartButton.Visible = true;
                    break;
                case 21:
                    outputLabel.Text = "";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    break;
                default:
                    break;
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            greenLabel.Text = "";
            scene = 0;
        }

        private void restartButton_MouseHover(object sender, EventArgs e)
        {
            restartButton.BackColor = Color.White;
        }

       private void greenLabel_Click(object sender, EventArgs e)
        {

        }
    }

}

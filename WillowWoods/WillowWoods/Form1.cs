﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillowWoods
{
    public partial class WillowWoodsForm : Form
    {
        public WillowWoodsForm()
        {
            InitializeComponent();
        }

        //Multiple buttons used to transition labels 
        private void firstNextbtn_Click(object sender, EventArgs e)
        {
            OnceUponlbl.Visible = false;
            storylbl.Visible = true;
            next2btn.Visible = true;
        }

        private void next2btn_Click_1(object sender, EventArgs e)
        {
            storylbl.Visible = false;
            firstNextbtn.Visible = false;
            willowWoodslbl.Visible = true;
            continuebtn.Visible = true;
        }

        private void continuebtn_Click_1(object sender, EventArgs e)
        {
            /*when continue button is clicked it will transition panel,
             continue button will not disappear until next button on intro panel
             is clicked*/
            IntroPanel.Visible = true; 
        }

        //Multiple buttons used to transition labels 
        private void nextOnebtn_Click(object sender, EventArgs e)
        {
            continuebtn.Visible = false;
            wispDialogOnelbl.Visible = false;
            youDialogOnelbl.Visible = true;
            nextTwobtn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextTwobtn.Visible = false;
            youDialogOnelbl.Visible = false;
            youDialog2lbl.Visible = true;
            next3btn.Visible = true;
        }

        private void next3btn_Click(object sender, EventArgs e)
        {
            next3btn.Visible = false;
            youDialog2lbl.Visible = false;
            youDialog3lbl.Visible = true;
            next4btn.Visible = true;
        }

        private void next4btn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
            youDialog3lbl.Visible = false;
            wispDialog2lbl.Visible = true;
            next5btn.Visible = true;
        }

        private void next5btn_Click(object sender, EventArgs e)
        {
            next4btn.Visible = false;
            mazePanel.Visible = true;  
        }
 
        private void Wall_MouseEnter(object sender, EventArgs e)
        {

            //makes mouse restart if user touches a green wall
            Point startPoint = mazePanel.Location;
            Cursor.Position = PointToScreen(startPoint);
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            /*on click transition panel, next button will not disappear until
             ok button is clicked on the maze panel*/
            nextMazebtn.Visible = true;
        }
        private void okbtn_Click(object sender, EventArgs e)
        {
            next5btn.Visible = false;
        }
        private void nextMazebtn_Click(object sender, EventArgs e)
        {
            swordPanel.BringToFront();
            swordPanel.Visible = true;
        }

        private void next1btn_Click(object sender, EventArgs e)
        {
            youDialog1lbl.Visible = false;
            youDialogTwolbl.Visible = true;
            nextsword2btn.Visible = true;
        }

        private void nextsword2btn_Click(object sender, EventArgs e)
        {
            youDialogTwolbl.Visible = false;
            next1btn.Visible = false;
            wispDialog1lbl.Visible = true;
            pickUpbtn.Visible = true;
        }

        private void pickUpbtn_Click(object sender, EventArgs e)
        {
            nextsword2btn.Visible = false;
            wispDialog1lbl.Visible = false;
            wisppic.Visible = false;
            swordDescriptionlbl.Visible = true;
            swordpic.Visible = true;
            continueSwordbtn.Visible = true;

        }

        //better way to transition with one button: counts number of clicks 
        private int a = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {
            /*first if-else statement is only excuted once
             depending on number generated it will execute the other if-else
             statement nested in the loop. Loop will end when user clicked hit button
             4 times*/
            a++;
            int min = 1;
            int max = 100;
            int chance;
            Random ranNumberGenerator = new Random();
            chance = ranNumberGenerator.Next(min, max);

            do
            {
                if (chance < 50)
                {
                    wispHit1lbl.Visible = true;

                    if (a == 2)
                    {
                        wispHit1lbl.Visible = false;
                        wispHit2lbl.Visible = true;

                    }
                    else if (a == 3)
                    {
                        wispHit2lbl.Visible = false;
                        monsterPic.Visible = false;
                        defeatlbl.Visible = true;
                        monsterContinuebtn.Visible = true;
                    }
                }
                else
                {
                    wispMisslbl.Visible = true;

                    if (a == 2)
                    {
                        wispMisslbl.Visible = false;
                        wispHit1lbl.Visible = true;
                    }
                    else if (a == 3)
                    {
                        wispHit1lbl.Visible = false;
                        monsterPic.Visible = false;
                        defeatlbl.Visible = true;
                        monsterContinuebtn.Visible = true;
                    }
                                 
                }
            } while (a > 3);

            //have to put in this code below or game will crash
            monsterPic.Visible = false;
            defeatlbl.Visible = true;
            monsterContinuebtn.Visible = true;
            //loop is semi-functioning properly 
            //it skips the nested if statement on the 3rd click :(
        }

        private void continueSwordbtn_Click(object sender, EventArgs e)
        {
            Monsterpanel.Visible = true;
            Monsterpanel.BringToFront();
            Monsterpanel.Show();
        }

        private void monsterContinuebtn_Click(object sender, EventArgs e)
        {
            /*this panel was supposed to have 2 doors and the user could
             choose which door they would like to enter, but we faced the problem
             with one of the panels refusing to show. So to compromise, we had
             to delete that option*/
            doorPanel.Visible = true;
            doorPanel.BringToFront();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
             endingpanel.Visible = true;
             endingpanel.BringToFront();
        }

        //used clicker counter to transition label text
        private int c = 1;
        private void nextEndbtn_Click(object sender, EventArgs e)
        {
            /*CAUTION: if user clicks too fast, it may appear that some text is
             missing*/
            c++;
            do
            {            
                if (c == 2)
                {
                    scene1lbl.Visible = false;
                    sunsetPicBox.Visible = true;
                }
                else if (c == 3)
                {
                    sunsetPicBox.Visible = false;
                    wispEndDialoglbl.Visible = true;
                    wispEndPic.Visible = true;
                }
                else if (c == 4)
                {
                    wispEndDialoglbl.Visible = false;
                    youEndDialoglbl.Visible = true;
                }
                else if (c == 5)
                {
                    youEndDialoglbl.Visible = false;
                    wispEndDialog2lbl.Visible = true;
                }
                else if (c == 6)
                {
                    wispEndDialog2lbl.Visible = false;
                    scene2lbl.Visible = true;
                }
                else if (c == 7)
                {
                    scene2lbl.Visible = false;
                    wispEndPic.Visible = false;
                    sunsetPicBox.Visible = true;
                }
                else if (c == 8)
                {
                    sunsetPicBox.Visible = false;
                    wispEndPic.Visible = true;
                    youEndDialog3lbl.Visible = true;
                }
                else if (c == 9)
                {
                    youEndDialog3lbl.Visible = false;
                    wispEndDialog3lbl.Visible = true;
                }
                else if ( c == 10)
                {
                    wispEndDialog3lbl.Visible = false;
                    youEndDialog4lbl.Visible = true;
                }
                else if (c == 11)
                {
                    youEndDialog4lbl.Visible = false;
                    wispEndDialog4lbl.Visible = true;
                }
                else if (c == 12)
                {
                    wispEndDialog4lbl.Visible = false;
                    scene3lbl.Visible = true;
                }
                else if (c == 13)
                {
                    scene3lbl.Visible = false;
                    wispEndDialog5lbl.Visible = true;
                } 
                else if (c == 14)
                {
                    wispEndDialog5lbl.Visible = false;
                    scene4lbl.Visible = true;
                }
                else if (c == 15)
                {
                    scene4lbl.Visible = false;
                    scene5lbl.Visible = true;
                }
                else if (c == 16)
                {
                    scene5lbl.Visible = false;
                    wispEndPic.Visible = false;
                    endlbl.Visible = true;        
                }
                
            } while (c > 16);

           
        }
    }
     
}

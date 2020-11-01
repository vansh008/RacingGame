using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingGame
{
    public partial class ZoombieForm : Form
    {
        //Punter class
        Punter[] myPunter = new Punter[3];
        //Class containing Ghosts. Referred to in the code as things.
        Thing[] myThing = new Thing[4];
        //Race information
        Race myRace = new Race();
        public ZoombieForm()
        {
            InitializeComponent();
            LoadData();
            Transparent();
            ResetGhosts();
        }
        private void LoadData()
        {
            for (int i = 0; i < 3; i++)
            {
                myPunter[i] = Factory.GetAPerson(i);
            }
            for (int i = 0; i < 4; i++)
            {
                myThing[i] = Factory.GetAThing(i);
            }
            numThingNumber.Minimum = 1;
            //assign variables to punters
            myRace.JerryCash = myPunter[0].cash;
            myRace.AlCash = myPunter[1].cash;
            myRace.TomCash = myPunter[2].cash;
        }
        //Assign transparency to moving ghosts
        private void Transparent()
        {
            Application.DoEvents();
            this.PointToScreen(PB1.Location);
            PB1.Parent = pbBackground;
            PB1.BackColor = Color.Transparent;
            this.PointToScreen(PB2.Location);
            PB2.Parent = pbBackground;
            PB2.BackColor = Color.Transparent;
           //
            this.PointToScreen(PB3.Location);
            PB3.Parent = pbBackground;
            PB3.BackColor = Color.Transparent;
            //
            this.PointToScreen(PB4.Location);
            PB4.Parent = pbBackground;
            PB4.BackColor = Color.Transparent;
        }
        private void allBetters_CheckedChanged(object sender, EventArgs e)
        {
            myRace.myRadioButton = (RadioButton) sender;
            if (myRace.myRadioButton.Checked == true)
            {
                int merino = Convert.ToInt16(myRace.myRadioButton.Tag);
                this.Text = myPunter[merino].name;
                txtMaxBet.Text = myPunter[merino].cash.ToString();
                //myPunter[merino].cash = myPunter[merino].cash - 5;
                int cash = myPunter[merino].cash;
                numBetAmount.Text = cash.ToString();
                numBetAmount.Maximum = cash;
            }
        }
        private void btnBet_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(myRace.myRadioButton.Tag.ToString());
            int numThingZeroStart = Convert.ToInt16(numThingNumber.Text) - 1;
            int person = Convert.ToInt16(myRace.myRadioButton.Tag);
            if (person == 0)
            {
                lblBetStatus1.Text = "Jerry has put $" + numBetAmount.Text + " on " +
                                     myThing[numThingZeroStart].thingName;
                myRace.JerryThing = myThing[numThingZeroStart].thingID;
                myRace.JerryBet = true;
                myRace.JerryAmount = Convert.ToInt16(numBetAmount.Text);
                //myRace.JerryAmount = Convert.ToInt16(numBetAmount);
            }
            else if (person == 1)
            {
                lblBetStatus2.Text = "Al has put $" + numBetAmount.Text + " on " +
                                     myThing[numThingZeroStart].thingName;
                myRace.AlBet = true;
                myRace.AlThing = myThing[numThingZeroStart].thingID;
                myRace.AlAmount = Convert.ToInt16(numBetAmount.Text);
                //myRace.AlAmount = Convert.ToInt16(numBetAmount);
            }
            else
            {
                lblBetStatus3.Text = "Tom has put $" + numBetAmount.Text + " on " +
                                     myThing[numThingZeroStart].thingName;
                myRace.TomBet = true;
                myRace.TomThing = myThing[numThingZeroStart].thingID;
                myRace.TomAmount = Convert.ToInt16(numBetAmount.Text);
                //myRace.TomAmount = Convert.ToInt16(numBetAmount);
            }
        }
        private void btnRace_Click(object sender, EventArgs e)
        {
            //check that Jerry, Al and Tom have made bets before racing
            if (myRace.JerryBet == true && myRace.AlBet == true && myRace.TomBet == true)
            {
                //code for moving the ghosts
                myRace.TrackLength = ZoombieForm.ActiveForm.Width - PB1.Width;
                while (PB1.Location.X < myRace.TrackLength && PB2.Location.X < myRace.TrackLength &&
                       PB3.Location.X < myRace.TrackLength && PB4.Location.X < myRace.TrackLength)
                {
                    PB1.Location = new Point(PB1.Location.X + Factory.Number(), PB1.Location.Y);
                    PB2.Location = new Point(PB2.Location.X + Factory.Number(), PB2.Location.Y);
                    PB3.Location = new Point(PB3.Location.X + Factory.Number(), PB3.Location.Y);
                    PB4.Location = new Point(PB4.Location.X + Factory.Number(), PB4.Location.Y);
                    Application.DoEvents();
                }
                //decide what to do upon winning
                if (PB1.Location.X >= myRace.TrackLength)
                {
                    //Place flag if winner is first ghost
                    MessageBox.Show("The Winner is " + myThing[0].thingName);
                    myRace.Winner = 1;
                }
                else if (PB2.Location.X >= myRace.TrackLength)
                {
                    //Place flag if winner is second ghost
                    MessageBox.Show("The Winner is " + myThing[1].thingName);
                    myRace.Winner = 2;
                }
                else if (PB3.Location.X >= myRace.TrackLength)
                {
                    //Place flag if winner is third ghost
                    MessageBox.Show("The Winner is " + myThing[2].thingName);
                    myRace.Winner = 3;
                }
                else
                {
                    //Place flag if winner is fourth ghost
                    MessageBox.Show("The Winner is " + myThing[3].thingName);
                    myRace.Winner = 4;
                }

                //Whoever wins is awarded cash
                if (myRace.JerryThing == myRace.Winner)
                {
                    lblBetStatus1.Text = "Jerry Wins $" + myRace.JerryAmount;
                    myRace.JerryCash = myRace.JerryCash + myRace.JerryAmount;
                }
                else
                {
                    lblBetStatus1.Text = "Jerry Loses $" + myRace.JerryAmount;
                    myRace.JerryCash = myRace.JerryCash - myRace.JerryAmount;
                }
                if (myRace.AlThing == myRace.Winner)
                {
                    lblBetStatus2.Text = "Al Wins $" + myRace.AlAmount;
                    myRace.AlCash = myRace.AlCash + myRace.AlAmount;
                }
                else
                {
                    lblBetStatus2.Text = "Al Loses $" + myRace.AlAmount;
                    myRace.AlCash = myRace.AlCash - myRace.AlAmount;
                }
                if (myRace.TomThing == myRace.Winner)
                {
                    lblBetStatus3.Text = "Tom Wins $" + myRace.TomAmount;
                    myRace.TomCash = myRace.TomCash + myRace.TomAmount;
                }
                else
                {
                    lblBetStatus3.Text = "Tom Loses $" + myRace.TomAmount;
                    myRace.TomCash = myRace.TomCash - myRace.TomAmount;
                }

                //
                myPunter[0].cash = myRace.JerryCash;
                myPunter[1].cash = myRace.AlCash;
                myPunter[2].cash = myRace.TomCash;
                ResetAll();
                //If everyone is out of money
                if (myRace.TomCash <= 0 && myRace.AlCash <= 0 && myRace.JerryCash <= 0)
                {
                    MessageBox.Show("Everyone is broke. Go Home!");
                    btnBet.Enabled = false;
                    myRace.JerryBet = false;
                }
            }
            else
            {
                MessageBox.Show("You cannot do that at this time.");
            }
        }
        //Reset Ghosts to initial positions
        public void ResetGhosts()
        {
            PB1.Location = new Point(50, 50);
            PB2.Location = new Point(50, 100);
            PB3.Location = new Point(50, 150);
            PB4.Location = new Point(50, 200);

        }
        //reset everything
        public void ResetAll()
        {
            ResetGhosts();
            if (myRace.JerryCash <= 0)
            {
                JerryButton.Enabled = false;
                myRace.JerryBet = true;
                lblBetStatus1.Text = "Busted";
                myRace.TomAmount = 0;
            }
            else
            {
                myRace.JerryBet = false;
            }
            if (myRace.AlCash <= 0)
            {
                alButton.Enabled = false;
                myRace.AlBet = true;
                lblBetStatus2.Text = "Busted";
                myRace.AlAmount = 0;
            }
            else
            {
                myRace.AlBet = false;
            }
            if (myRace.TomCash <= 0)
            {
                TomButton.Enabled = false;
                myRace.TomBet = true;
                lblBetStatus3.Text = "Busted";
                myRace.JerryAmount = 0;
            }
            else
            {
                myRace.TomBet = false;
            }
            JerryButton.Checked = false;
            alButton.Checked = false;
            TomButton.Checked = false;
        }
    }
}

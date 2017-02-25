using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }
        public FinalForm()
        {
            InitializeComponent();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            /*
            *setting the text boxes to their related abilites  
            */
            StrengthTextBox.Text = Program.Abilities.Strength;
            DexterityTextBox.Text = Program.Abilities.Dexterity;
            EnduranceTextBox.Text = Program.Abilities.Endurance;
            IntelligenceTextBox.Text = Program.Abilities.Intelligence;
            PerceptionTextBox.Text = Program.Abilities.Perception;
            CharismaTextBox.Text = Program.Abilities.Charisma;
            HealthPointsTextBox.Text = Program.Abilities.HealthPoints;
            JobTextBox.Text = Program.Abilities.Job;
            RaceTextBox.Text = Program.Abilities.Race;
           /*
           *setting the picture box image based off of the racetextbox text
           */
            if (RaceTextBox.Text == "Human")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Human1;
            }
            if(RaceTextBox.Text == "Elf")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            }
            if (RaceTextBox.Text == "Halfling")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            }
            if (RaceTextBox.Text == "Dwarf")
            {
                CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * closing the form
             */
            exitForm();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             *showing the font dialog 
             */
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * print message
             */
            MessageBox.Show("Preparing to Print, please wait...");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
             * making and showing the about box
             */
            AboutBox aboutBox = new AboutBox();

            aboutBox.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            /*
             * calling the exit form
             */
            exitForm();
        }

        private void exitForm()
        {
            /*
             * exiting the application
             */
            Application.Exit();
        }
    }
}

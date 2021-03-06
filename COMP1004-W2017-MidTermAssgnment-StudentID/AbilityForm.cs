﻿/*
 * scot mclean
 * 200332937
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();

        public AbilityForm()
        {
            InitializeComponent();
            NextButton.Enabled = false;
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }
        /*
         * setting the abilities with the roll3d10 method
         */
        private void RollButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Roll3D10().ToString());
            STRTextBox.Text = Roll3D10().ToString();
            DEXTextBox.Text = Roll3D10().ToString();
            ENDTextBox.Text = Roll3D10().ToString();
            INTTextBox.Text = Roll3D10().ToString();
            PERTextBox.Text = Roll3D10().ToString();
            CHATextBox.Text = Roll3D10().ToString();
            NextButton.Enabled = true;
        }
        /*
         * next button handler setting the textbox texts to their related ability values
         */
        private void NextButton_Click(object sender, EventArgs e)
        {
            
            Abilities abilities = Program.Abilities;

            abilities.Strength = STRTextBox.Text;
            abilities.Dexterity = DEXTextBox.Text;
            abilities.Endurance = ENDTextBox.Text;
            abilities.Charisma = CHATextBox.Text;
            abilities.Perception = PERTextBox.Text;
            abilities.Intelligence = INTTextBox.Text;
         /*
         * hiding this form and sending us to the raceform
         */
            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }
    }
}

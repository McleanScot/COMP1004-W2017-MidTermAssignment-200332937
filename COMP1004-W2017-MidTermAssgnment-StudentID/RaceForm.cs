/*
* scot mclean
* 200332937
*/
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
    public partial class RaceForm : Form
    {
        public AbilityForm previousForm;
        /*
         * getting the abilities from before and converting them to ints
         */
        private int _strenghtOriginal = Convert.ToInt32(Program.Abilities.Strength);
        private int _dexterityOriginal = Convert.ToInt32(Program.Abilities.Dexterity);
        private int _enduranceOriginal = Convert.ToInt32(Program.Abilities.Endurance);
        private int _intelligenceOriginal = Convert.ToInt32(Program.Abilities.Intelligence);
        private int _charismaOriginal = Convert.ToInt32(Program.Abilities.Charisma);
        private int _perceptionOriginal = Convert.ToInt32(Program.Abilities.Perception);

        private int _strenght = 0;
        private int _dexterity = 0;
        private int _endurance = 0;
        private int _intelligence = 0;
        private int _charisma = 0;
        private int _perception = 0;


        private string _racePicked;


        public RaceForm()
        {
         /*
         *disabling the next button until the checkbox is selected 
         */
            InitializeComponent();
            NextButton.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Abilities abilities = Program.Abilities;
         /*
         * converting the abilities to strings
         */
            abilities.Strength = _strenght.ToString();
            abilities.Dexterity = _dexterity.ToString();
            abilities.Endurance = _endurance.ToString();
            abilities.Intelligence = _intelligence.ToString();
            abilities.Charisma = _charisma.ToString();
            abilities.Perception = _perception.ToString();
            abilities.Race = _racePicked;

            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();

            
        }

        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
         /*
         *changing the picture box based of the selected race
         * enabling the next button when the checkbox is selected 
         */
            NextButton.Enabled = true;
            CharacterPictureBox.Image = Properties.Resources.M_Human1;

            RacialBonusTextBox.Text = "All abilities +5";
         /*
         *adding 5 to all the abilities when the user selects human 
         */
            _strenght = _strenghtOriginal + 5;
            _dexterity = _dexterityOriginal + 5;
            _endurance = _enduranceOriginal + 5;
            _intelligence = _intelligenceOriginal + 5;
            _charisma = _charismaOriginal + 5;
            _perception = _perceptionOriginal + 5;

            _racePicked = HumanRadioButton.Text;



        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;

            RacialBonusTextBox.Text = "Strength and Perception +20, Charisma -10";
         /*
         *adding bonuses and negatives based on race 
         */
            _strenght = _strenghtOriginal + 20;
            _perception = _perceptionOriginal + 20;
            _charisma = _charismaOriginal - 10;

            _racePicked = DwarfRadioButton.Text;

        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;

            RacialBonusTextBox.Text = "Dexterity and Charisma +15";
         /*
         *adding bonuses and negatives based on race 
         */
            _dexterity = _dexterityOriginal + 15;
            _charisma = _charismaOriginal + 15;

            _racePicked = ElfRadioButton.Text;
        }

        private void HaflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;

            RacialBonusTextBox.Text = "Dexterity and Intelligence +20, Strength -10";
         /*
         *adding bonuses and negatives based on race 
         */
            _dexterity = _dexterityOriginal + 20;
            _intelligence = _intelligenceOriginal + 20;
            _strenght = _strenghtOriginal - 10;

            _racePicked = HaflingRadioButton.Text;
        }
    }
}

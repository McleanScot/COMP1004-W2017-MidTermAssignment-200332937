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

        private int _strenghtChange = Convert.ToInt32(Program.Abilities.Strength);
        private int _DexterityChange = Convert.ToInt32(Program.Abilities.Dexterity);
        private int _EnduranceChange = Convert.ToInt32(Program.Abilities.Endurance);
        private int _intelligenceChange = Convert.ToInt32(Program.Abilities.Intelligence);
        private int _charismaChange = Convert.ToInt32(Program.Abilities.Charisma);
        private int _PerceptionChange = Convert.ToInt32(Program.Abilities.Perception);


        public RaceForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Abilities abilities = Program.Abilities;

            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;

            RacialBonusTextBox.Text = "All abilities +5";

            _strenghtChange = _strenghtChange + 5;
            _DexterityChange = _DexterityChange + 5;
            _EnduranceChange = _EnduranceChange + 5;
            _intelligenceChange = _intelligenceChange + 5;
            _charismaChange = _charismaChange + 5;
            _PerceptionChange = _PerceptionChange + 5;

            
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;

            RacialBonusTextBox.Text = "Strength and Perception +20, Charisma -10";

            _strenghtChange = _strenghtChange + 20;
            _PerceptionChange = _PerceptionChange + 20;
            _charismaChange = _charismaChange + 10;

        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;

            RacialBonusTextBox.Text = "Dexterity and Charisma +15";

            _DexterityChange = _DexterityChange + 15;
            _charismaChange = _charismaChange + 15;
        }

        private void HaflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;

            RacialBonusTextBox.Text = "Dexterity and Intelligence +20, Strength -10";

            _DexterityChange = _DexterityChange + 20;
            _intelligenceChange = _intelligenceChange + 20;
            _strenghtChange = _strenghtChange - 10;
        }
    }
}

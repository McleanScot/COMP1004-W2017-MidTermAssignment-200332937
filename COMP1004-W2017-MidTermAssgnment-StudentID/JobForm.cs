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
    public partial class JobForm : Form
    {
        public RaceForm previousForm;

        private int _enduranceHealthChange = Convert.ToInt32(Program.Abilities.Endurance);
        private int _dexterityHealthChange = Convert.ToInt32(Program.Abilities.Dexterity);
        private int _intelligenceHealthChange = Convert.ToInt32(Program.Abilities.Intelligence);
        private int _charismaHealthChange = Convert.ToInt32(Program.Abilities.Charisma);
        private string _jobPicked;
        private string _healthPoints;
        

        public JobForm()
        {
            InitializeComponent();
            NextButton.Enabled = false;
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            NextButton.Enabled = true;
            _healthPoints = (_enduranceHealthChange).ToString();

            HealthPointsTextBox.Text = _healthPoints;

            _jobPicked = SoldierRadioButton.Text;
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;

            _healthPoints = (_dexterityHealthChange + 28).ToString();

            HealthPointsTextBox.Text = _healthPoints;

            _jobPicked = RogueRadioButton.Text;
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;

            _healthPoints = (_intelligenceHealthChange + 15).ToString();

            HealthPointsTextBox.Text = _healthPoints;

            _jobPicked = MagickerRadioButton.Text;
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;

            _healthPoints = (_charismaHealthChange + 24).ToString();

            HealthPointsTextBox.Text = _healthPoints;

            _jobPicked = CultistRadioButton.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Abilities abilities = Program.Abilities;

            abilities.HealthPoints = _healthPoints;

            abilities.Job = _jobPicked;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }

        
    }
}

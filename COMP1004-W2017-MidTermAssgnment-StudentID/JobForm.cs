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

        public JobForm()
        {
            InitializeComponent();
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsTextBox.Text = (_enduranceHealthChange).ToString();
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsTextBox.Text = (_dexterityHealthChange + 28).ToString();
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsTextBox.Text = (_intelligenceHealthChange + 15).ToString();
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HealthPointsTextBox.Text = (_charismaHealthChange + 24).ToString();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Abilities abilities = Program.Abilities;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }
    }
}

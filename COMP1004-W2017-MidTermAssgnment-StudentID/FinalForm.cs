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
            StrengthTextBox.Text = Program.Abilities.Strength;
            DexterityTextBox.Text = Program.Abilities.Dexterity;
            EnduranceTextBox.Text = Program.Abilities.Endurance;
            IntelligenceTextBox.Text = Program.Abilities.Intelligence;
            PerceptionTextBox.Text = Program.Abilities.Perception;
            CharismaTextBox.Text = Program.Abilities.Charisma;
        }
    }
}

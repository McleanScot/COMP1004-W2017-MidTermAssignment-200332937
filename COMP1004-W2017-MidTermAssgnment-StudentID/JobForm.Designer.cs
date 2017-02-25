namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class JobForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.CharacterJobGroupBox = new System.Windows.Forms.GroupBox();
            this.CultistRadioButton = new System.Windows.Forms.RadioButton();
            this.MagickerRadioButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.SoldierRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthPointsLabel = new System.Windows.Forms.Label();
            this.HealthPointsTextBox = new System.Windows.Forms.TextBox();
            this.CharacterJobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CharacterJobGroupBox
            // 
            this.CharacterJobGroupBox.Controls.Add(this.CultistRadioButton);
            this.CharacterJobGroupBox.Controls.Add(this.MagickerRadioButton);
            this.CharacterJobGroupBox.Controls.Add(this.RogueRadioButton);
            this.CharacterJobGroupBox.Controls.Add(this.SoldierRadioButton);
            this.CharacterJobGroupBox.Location = new System.Drawing.Point(13, 13);
            this.CharacterJobGroupBox.Name = "CharacterJobGroupBox";
            this.CharacterJobGroupBox.Size = new System.Drawing.Size(97, 118);
            this.CharacterJobGroupBox.TabIndex = 3;
            this.CharacterJobGroupBox.TabStop = false;
            this.CharacterJobGroupBox.Text = "Character\'s Job";
            // 
            // CultistRadioButton
            // 
            this.CultistRadioButton.AutoSize = true;
            this.CultistRadioButton.Location = new System.Drawing.Point(7, 89);
            this.CultistRadioButton.Name = "CultistRadioButton";
            this.CultistRadioButton.Size = new System.Drawing.Size(53, 17);
            this.CultistRadioButton.TabIndex = 3;
            this.CultistRadioButton.TabStop = true;
            this.CultistRadioButton.Text = "Cultist";
            this.CultistRadioButton.UseVisualStyleBackColor = true;
            this.CultistRadioButton.CheckedChanged += new System.EventHandler(this.CultistRadioButton_CheckedChanged);
            // 
            // MagickerRadioButton
            // 
            this.MagickerRadioButton.AutoSize = true;
            this.MagickerRadioButton.Location = new System.Drawing.Point(6, 66);
            this.MagickerRadioButton.Name = "MagickerRadioButton";
            this.MagickerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.MagickerRadioButton.TabIndex = 2;
            this.MagickerRadioButton.TabStop = true;
            this.MagickerRadioButton.Text = "Magicker";
            this.MagickerRadioButton.UseVisualStyleBackColor = true;
            this.MagickerRadioButton.CheckedChanged += new System.EventHandler(this.MagickerRadioButton_CheckedChanged);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Location = new System.Drawing.Point(7, 43);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(57, 17);
            this.RogueRadioButton.TabIndex = 1;
            this.RogueRadioButton.TabStop = true;
            this.RogueRadioButton.Text = "Rogue";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this.RogueRadioButton_CheckedChanged);
            // 
            // SoldierRadioButton
            // 
            this.SoldierRadioButton.AutoSize = true;
            this.SoldierRadioButton.Location = new System.Drawing.Point(7, 20);
            this.SoldierRadioButton.Name = "SoldierRadioButton";
            this.SoldierRadioButton.Size = new System.Drawing.Size(57, 17);
            this.SoldierRadioButton.TabIndex = 0;
            this.SoldierRadioButton.TabStop = true;
            this.SoldierRadioButton.Text = "Soldier";
            this.SoldierRadioButton.UseVisualStyleBackColor = true;
            this.SoldierRadioButton.CheckedChanged += new System.EventHandler(this.SoldierRadioButton_CheckedChanged);
            // 
            // HealthPointsLabel
            // 
            this.HealthPointsLabel.AutoSize = true;
            this.HealthPointsLabel.Location = new System.Drawing.Point(164, 60);
            this.HealthPointsLabel.Name = "HealthPointsLabel";
            this.HealthPointsLabel.Size = new System.Drawing.Size(70, 13);
            this.HealthPointsLabel.TabIndex = 0;
            this.HealthPointsLabel.Text = "Health Points";
            // 
            // HealthPointsTextBox
            // 
            this.HealthPointsTextBox.Location = new System.Drawing.Point(240, 57);
            this.HealthPointsTextBox.Name = "HealthPointsTextBox";
            this.HealthPointsTextBox.ReadOnly = true;
            this.HealthPointsTextBox.Size = new System.Drawing.Size(100, 20);
            this.HealthPointsTextBox.TabIndex = 3;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.HealthPointsTextBox);
            this.Controls.Add(this.HealthPointsLabel);
            this.Controls.Add(this.CharacterJobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.CharacterJobGroupBox.ResumeLayout(false);
            this.CharacterJobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox CharacterJobGroupBox;
        private System.Windows.Forms.RadioButton CultistRadioButton;
        private System.Windows.Forms.RadioButton MagickerRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton SoldierRadioButton;
        private System.Windows.Forms.Label HealthPointsLabel;
        private System.Windows.Forms.TextBox HealthPointsTextBox;
    }
}
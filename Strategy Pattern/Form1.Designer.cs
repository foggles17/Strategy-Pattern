namespace Strategy_Pattern
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rockHealthLabel = new System.Windows.Forms.Label();
            this.rockMagicLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paperMagicLabel = new System.Windows.Forms.Label();
            this.paperHealthLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.scissorsMagicLabel = new System.Windows.Forms.Label();
            this.scissorsHealthLabel = new System.Windows.Forms.Label();
            this.fighterComboBox = new System.Windows.Forms.ComboBox();
            this.strongAttackButton = new System.Windows.Forms.Button();
            this.weakAttackButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rockLevelLabel = new System.Windows.Forms.Label();
            this.paperLevelLabel = new System.Windows.Forms.Label();
            this.scissorsLevelLabel = new System.Windows.Forms.Label();
            this.doNothingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Magic";
            // 
            // rockHealthLabel
            // 
            this.rockHealthLabel.AutoSize = true;
            this.rockHealthLabel.Location = new System.Drawing.Point(62, 311);
            this.rockHealthLabel.Name = "rockHealthLabel";
            this.rockHealthLabel.Size = new System.Drawing.Size(35, 13);
            this.rockHealthLabel.TabIndex = 3;
            this.rockHealthLabel.Text = "label4";
            // 
            // rockMagicLabel
            // 
            this.rockMagicLabel.AutoSize = true;
            this.rockMagicLabel.Location = new System.Drawing.Point(62, 340);
            this.rockMagicLabel.Name = "rockMagicLabel";
            this.rockMagicLabel.Size = new System.Drawing.Size(35, 13);
            this.rockMagicLabel.TabIndex = 4;
            this.rockMagicLabel.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rock";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Paper";
            // 
            // paperMagicLabel
            // 
            this.paperMagicLabel.AutoSize = true;
            this.paperMagicLabel.Location = new System.Drawing.Point(112, 340);
            this.paperMagicLabel.Name = "paperMagicLabel";
            this.paperMagicLabel.Size = new System.Drawing.Size(35, 13);
            this.paperMagicLabel.TabIndex = 7;
            this.paperMagicLabel.Text = "label8";
            // 
            // paperHealthLabel
            // 
            this.paperHealthLabel.AutoSize = true;
            this.paperHealthLabel.Location = new System.Drawing.Point(112, 311);
            this.paperHealthLabel.Name = "paperHealthLabel";
            this.paperHealthLabel.Size = new System.Drawing.Size(35, 13);
            this.paperHealthLabel.TabIndex = 6;
            this.paperHealthLabel.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(162, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Scissors";
            // 
            // scissorsMagicLabel
            // 
            this.scissorsMagicLabel.AutoSize = true;
            this.scissorsMagicLabel.Location = new System.Drawing.Point(162, 340);
            this.scissorsMagicLabel.Name = "scissorsMagicLabel";
            this.scissorsMagicLabel.Size = new System.Drawing.Size(41, 13);
            this.scissorsMagicLabel.TabIndex = 10;
            this.scissorsMagicLabel.Text = "label11";
            // 
            // scissorsHealthLabel
            // 
            this.scissorsHealthLabel.AutoSize = true;
            this.scissorsHealthLabel.Location = new System.Drawing.Point(162, 311);
            this.scissorsHealthLabel.Name = "scissorsHealthLabel";
            this.scissorsHealthLabel.Size = new System.Drawing.Size(41, 13);
            this.scissorsHealthLabel.TabIndex = 9;
            this.scissorsHealthLabel.Text = "label12";
            // 
            // fighterComboBox
            // 
            this.fighterComboBox.FormattingEnabled = true;
            this.fighterComboBox.Location = new System.Drawing.Point(241, 279);
            this.fighterComboBox.Name = "fighterComboBox";
            this.fighterComboBox.Size = new System.Drawing.Size(121, 21);
            this.fighterComboBox.TabIndex = 12;
            // 
            // strongAttackButton
            // 
            this.strongAttackButton.Location = new System.Drawing.Point(368, 306);
            this.strongAttackButton.Name = "strongAttackButton";
            this.strongAttackButton.Size = new System.Drawing.Size(121, 23);
            this.strongAttackButton.TabIndex = 13;
            this.strongAttackButton.Text = "Strong Attack (20 MP)";
            this.strongAttackButton.UseVisualStyleBackColor = true;
            this.strongAttackButton.Click += new System.EventHandler(this.strongAttackButton_Click);
            // 
            // weakAttackButton
            // 
            this.weakAttackButton.Location = new System.Drawing.Point(368, 277);
            this.weakAttackButton.Name = "weakAttackButton";
            this.weakAttackButton.Size = new System.Drawing.Size(121, 23);
            this.weakAttackButton.TabIndex = 14;
            this.weakAttackButton.Text = "Weak Attack (10 MP)";
            this.weakAttackButton.UseVisualStyleBackColor = true;
            this.weakAttackButton.Click += new System.EventHandler(this.weakAttackButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.Location = new System.Drawing.Point(368, 335);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(121, 23);
            this.autoButton.TabIndex = 15;
            this.autoButton.Text = "Choose for Me";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(13, 13);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(476, 231);
            this.outputTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Level";
            // 
            // rockLevelLabel
            // 
            this.rockLevelLabel.AutoSize = true;
            this.rockLevelLabel.Location = new System.Drawing.Point(62, 282);
            this.rockLevelLabel.Name = "rockLevelLabel";
            this.rockLevelLabel.Size = new System.Drawing.Size(35, 13);
            this.rockLevelLabel.TabIndex = 18;
            this.rockLevelLabel.Text = "label5";
            // 
            // paperLevelLabel
            // 
            this.paperLevelLabel.AutoSize = true;
            this.paperLevelLabel.Location = new System.Drawing.Point(112, 282);
            this.paperLevelLabel.Name = "paperLevelLabel";
            this.paperLevelLabel.Size = new System.Drawing.Size(35, 13);
            this.paperLevelLabel.TabIndex = 19;
            this.paperLevelLabel.Text = "label8";
            // 
            // scissorsLevelLabel
            // 
            this.scissorsLevelLabel.AutoSize = true;
            this.scissorsLevelLabel.Location = new System.Drawing.Point(162, 282);
            this.scissorsLevelLabel.Name = "scissorsLevelLabel";
            this.scissorsLevelLabel.Size = new System.Drawing.Size(35, 13);
            this.scissorsLevelLabel.TabIndex = 20;
            this.scissorsLevelLabel.Text = "label9";
            // 
            // doNothingButton
            // 
            this.doNothingButton.Location = new System.Drawing.Point(241, 306);
            this.doNothingButton.Name = "doNothingButton";
            this.doNothingButton.Size = new System.Drawing.Size(121, 52);
            this.doNothingButton.TabIndex = 21;
            this.doNothingButton.Text = "Do Nothing";
            this.doNothingButton.UseVisualStyleBackColor = true;
            this.doNothingButton.Click += new System.EventHandler(this.doNothingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 368);
            this.Controls.Add(this.doNothingButton);
            this.Controls.Add(this.scissorsLevelLabel);
            this.Controls.Add(this.paperLevelLabel);
            this.Controls.Add(this.rockLevelLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.weakAttackButton);
            this.Controls.Add(this.strongAttackButton);
            this.Controls.Add(this.fighterComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.scissorsMagicLabel);
            this.Controls.Add(this.scissorsHealthLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.paperMagicLabel);
            this.Controls.Add(this.paperHealthLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rockMagicLabel);
            this.Controls.Add(this.rockHealthLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Extreme RPS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rockHealthLabel;
        private System.Windows.Forms.Label rockMagicLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label paperMagicLabel;
        private System.Windows.Forms.Label paperHealthLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label scissorsMagicLabel;
        private System.Windows.Forms.Label scissorsHealthLabel;
        private System.Windows.Forms.ComboBox fighterComboBox;
        private System.Windows.Forms.Button strongAttackButton;
        private System.Windows.Forms.Button weakAttackButton;
        private System.Windows.Forms.Button autoButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rockLevelLabel;
        private System.Windows.Forms.Label paperLevelLabel;
        private System.Windows.Forms.Label scissorsLevelLabel;
        private System.Windows.Forms.Button doNothingButton;
    }
}


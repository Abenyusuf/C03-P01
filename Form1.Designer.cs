namespace WindowsFormsApp1
{
    partial class BIgCats
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
            this.Lionlabel = new System.Windows.Forms.Label();
            this.Tigerlabel = new System.Windows.Forms.Label();
            this.LionInput = new System.Windows.Forms.TextBox();
            this.TigerInput = new System.Windows.Forms.TextBox();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.OutputLions = new System.Windows.Forms.Label();
            this.TotalCatsDisplay = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.PercentLions = new System.Windows.Forms.Label();
            this.PercentTigers = new System.Windows.Forms.Label();
            this.OutputTigers = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lionlabel
            // 
            this.Lionlabel.AutoSize = true;
            this.Lionlabel.Location = new System.Drawing.Point(135, 48);
            this.Lionlabel.Name = "Lionlabel";
            this.Lionlabel.Size = new System.Drawing.Size(191, 20);
            this.Lionlabel.TabIndex = 0;
            this.Lionlabel.Text = "Enter the number of lions ";
            this.Lionlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tigerlabel
            // 
            this.Tigerlabel.AutoSize = true;
            this.Tigerlabel.Location = new System.Drawing.Point(135, 104);
            this.Tigerlabel.Name = "Tigerlabel";
            this.Tigerlabel.Size = new System.Drawing.Size(198, 20);
            this.Tigerlabel.TabIndex = 1;
            this.Tigerlabel.Text = "Enter the number of tigers ";
            // 
            // LionInput
            // 
            this.LionInput.Location = new System.Drawing.Point(350, 48);
            this.LionInput.Name = "LionInput";
            this.LionInput.Size = new System.Drawing.Size(100, 26);
            this.LionInput.TabIndex = 2;
            this.LionInput.TextChanged += new System.EventHandler(this.LionInput_TextChanged_1);
            // 
            // TigerInput
            // 
            this.TigerInput.Location = new System.Drawing.Point(350, 104);
            this.TigerInput.Name = "TigerInput";
            this.TigerInput.Size = new System.Drawing.Size(100, 26);
            this.TigerInput.TabIndex = 3;
            this.TigerInput.TextChanged += new System.EventHandler(this.Tigerinput_TextChanged);
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(358, 274);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(92, 46);
            this.Calculatebutton.TabIndex = 4;
            this.Calculatebutton.Text = "Calculate";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.Calculatebutton_Click);
            // 
            // OutputLions
            // 
            this.OutputLions.AutoSize = true;
            this.OutputLions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLions.Location = new System.Drawing.Point(345, 148);
            this.OutputLions.Name = "OutputLions";
            this.OutputLions.Size = new System.Drawing.Size(111, 22);
            this.OutputLions.TabIndex = 5;
            this.OutputLions.Text = "                         ";
            this.OutputLions.Click += new System.EventHandler(this.OutputDisplay_Click_1);
            // 
            // TotalCatsDisplay
            // 
            this.TotalCatsDisplay.AutoSize = true;
            this.TotalCatsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalCatsDisplay.Location = new System.Drawing.Point(345, 186);
            this.TotalCatsDisplay.Name = "TotalCatsDisplay";
            this.TotalCatsDisplay.Size = new System.Drawing.Size(111, 22);
            this.TotalCatsDisplay.TabIndex = 6;
            this.TotalCatsDisplay.Text = "                         ";
            this.TotalCatsDisplay.Click += new System.EventHandler(this.TotalCatsDisplay_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(245, 188);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(81, 20);
            this.TotalLabel.TabIndex = 7;
            this.TotalLabel.Text = "Total Cats";
            this.TotalLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PercentLions
            // 
            this.PercentLions.AutoSize = true;
            this.PercentLions.Location = new System.Drawing.Point(242, 150);
            this.PercentLions.Name = "PercentLions";
            this.PercentLions.Size = new System.Drawing.Size(83, 20);
            this.PercentLions.TabIndex = 8;
            this.PercentLions.Text = "% of Lions";
            this.PercentLions.Click += new System.EventHandler(this.label2_Click);
            // 
            // PercentTigers
            // 
            this.PercentTigers.AutoSize = true;
            this.PercentTigers.Location = new System.Drawing.Point(482, 150);
            this.PercentTigers.Name = "PercentTigers";
            this.PercentTigers.Size = new System.Drawing.Size(88, 20);
            this.PercentTigers.TabIndex = 10;
            this.PercentTigers.Text = "% of Tigers";
            this.PercentTigers.Click += new System.EventHandler(this.label3_Click);
            // 
            // OutputTigers
            // 
            this.OutputTigers.AutoSize = true;
            this.OutputTigers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputTigers.Location = new System.Drawing.Point(585, 148);
            this.OutputTigers.Name = "OutputTigers";
            this.OutputTigers.Size = new System.Drawing.Size(111, 22);
            this.OutputTigers.TabIndex = 9;
            this.OutputTigers.Text = "                         ";
            this.OutputTigers.Click += new System.EventHandler(this.OutputTigers_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(358, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(92, 46);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BIgCats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PercentTigers);
            this.Controls.Add(this.OutputTigers);
            this.Controls.Add(this.PercentLions);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalCatsDisplay);
            this.Controls.Add(this.OutputLions);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.TigerInput);
            this.Controls.Add(this.LionInput);
            this.Controls.Add(this.Tigerlabel);
            this.Controls.Add(this.Lionlabel);
            this.Name = "BIgCats";
            this.Text = "Big Cats Exhibit";
            this.Load += new System.EventHandler(this.BIgCats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lionlabel;
        private System.Windows.Forms.Label Tigerlabel;
        private System.Windows.Forms.TextBox LionInput;
        private System.Windows.Forms.TextBox TigerInput;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Label OutputLions;
        private System.Windows.Forms.Label TotalCatsDisplay;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PercentLions;
        private System.Windows.Forms.Label PercentTigers;
        private System.Windows.Forms.Label OutputTigers;
        private System.Windows.Forms.Button ExitButton;
    }
}


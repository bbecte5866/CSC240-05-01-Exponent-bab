﻿namespace Exponents
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
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.UxInputLabel = new System.Windows.Forms.Label();
            this.UxOutputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Location = new System.Drawing.Point(215, 100);
            this.UxInputTextBox.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(228, 35);
            this.UxInputTextBox.TabIndex = 0;
            // 
            // UxInputLabel
            // 
            this.UxInputLabel.AutoSize = true;
            this.UxInputLabel.Location = new System.Drawing.Point(215, 60);
            this.UxInputLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.UxInputLabel.Name = "UxInputLabel";
            this.UxInputLabel.Size = new System.Drawing.Size(189, 29);
            this.UxInputLabel.TabIndex = 3;
            this.UxInputLabel.Text = "Enter an integer:";
            // 
            // UxOutputLabel
            // 
            this.UxOutputLabel.AutoSize = true;
            this.UxOutputLabel.Location = new System.Drawing.Point(238, 404);
            this.UxOutputLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.UxOutputLabel.Name = "UxOutputLabel";
            this.UxOutputLabel.Size = new System.Drawing.Size(0, 29);
            this.UxOutputLabel.TabIndex = 4;
            // 
            // UxGoButton
            // 
            this.UxGoButton.Location = new System.Drawing.Point(245, 214);
            this.UxGoButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(175, 149);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.Text = "Go!";
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // UxResetButton
            // 
            this.UxResetButton.Location = new System.Drawing.Point(245, 473);
            this.UxResetButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(175, 51);
            this.UxResetButton.TabIndex = 7;
            this.UxResetButton.Text = "Reset";
            this.UxResetButton.UseVisualStyleBackColor = true;
            this.UxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 584);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.UxOutputLabel);
            this.Controls.Add(this.UxInputLabel);
            this.Controls.Add(this.UxInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exponents Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label UxInputLabel;
        private System.Windows.Forms.Label UxOutputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button UxResetButton;
    }
}


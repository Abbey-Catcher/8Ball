﻿namespace _8Ball
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
            this.ballButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ballButton
            // 
            this.ballButton.BackgroundImage = global::_8Ball.Properties.Resources.clickBall;
            this.ballButton.FlatAppearance.BorderSize = 0;
            this.ballButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ballButton.Location = new System.Drawing.Point(2, 70);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(623, 534);
            this.ballButton.TabIndex = 0;
            this.ballButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.questionLabel.Location = new System.Drawing.Point(203, 23);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(225, 35);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Think of a question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 616);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.ballButton);
            this.Name = "Form1";
            this.Text = "Magic 8 Ball";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Label questionLabel;
    }
}

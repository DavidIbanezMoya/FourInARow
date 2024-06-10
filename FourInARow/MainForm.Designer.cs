using System.Windows.Forms;
using System.Windows;
using System;

namespace FourInARow
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button startButton;

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
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(315, 204);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 35);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start new game";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Name = "MainForm";
            this.Text = "Four in row";
            this.ResumeLayout(false);

        }


        //Displaying the gameScreen
        private void startButton_Click(object sender, EventArgs e)
        {
            GameScreen gs = new GameScreen();
            this.Visible = false;
            gs.Visible = true;
            Show(gs);
        }
        #endregion
    }
}
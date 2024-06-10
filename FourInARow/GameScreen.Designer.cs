using System.Windows.Forms;
using System;

namespace FourInARow
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button goBackButton{get;set;}

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

        //todo Need to implement the button
        private void InitializeComponent()
        {
            goBackButton = new Button();
            this.SuspendLayout();
            
            // 
            // GameScreen
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "GameScreen";
            this.ResumeLayout(false);

        }
    }
}
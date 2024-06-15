using System.Windows.Forms;
using System;
using System.Drawing;

namespace FourInARow
{
    partial class GameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button goBackButton;

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
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(12, 12);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(100, 40);
            this.goBackButton.TabIndex = 0;
            this.goBackButton.Text = "<---";
            Color blueColor = Color.FromArgb(60, 110, 245); 
            this.BackColor = blueColor;


            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // GameScreen
            // 
            this.ClientSize = new System.Drawing.Size(948, 559);
            this.Controls.Add(this.goBackButton);


            this.Name = "GameScreen";
            this.ResumeLayout(false);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Drawing the rectangle
            System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Color.Black);
            Graphics formGraphics = this.CreateGraphics();

            //Should make this sizes proportional
            Rectangle boardBorder = new Rectangle();
            boardBorder.Height = this.Height - 200;
            boardBorder.Width = this.Width - 200;
            boardBorder.Location = new System.Drawing.Point(100,100);

            formGraphics.DrawRectangle(pen, boardBorder);
            pen.Dispose();
            formGraphics.Dispose();

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Visible = true;
            this.Visible = false;
            Show(mf);
            Hide();
        }
    }
}
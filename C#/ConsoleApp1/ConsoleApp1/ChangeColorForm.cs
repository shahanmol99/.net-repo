using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeColorApp
{
    class ChangeColorForm : Form
    {
        public ChangeColorForm()
        {
            this.Text = "ChangeColor";
            Button redButton = new Button();
            redButton.Text = "Red";
            redButton.AutoSize = true;
            redButton.Location = new Point(100, 100);

            Button blueButton = new Button();
            blueButton.Text = "Blue";
            blueButton.AutoSize = true;
            blueButton.Location = new Point(100, 200);

            redButton.Click += ChangeColor;
            blueButton.Click += ChangeColor;

            this.Controls.Add(redButton);
            this.Controls.Add(blueButton);


        }

        private void ChangeColor(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn.Text.Equals("Red"))
            {
                this.BackColor = System.Drawing.Color.Red;
                return;
            }
            this.BackColor = System.Drawing.Color.Blue;
        }
    }
}

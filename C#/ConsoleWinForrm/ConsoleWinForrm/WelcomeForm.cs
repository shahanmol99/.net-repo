using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsoleWinForrm
{
    class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            this.Text = "Swabhav";
            Button RedButton = new Button();
            RedButton.Text = "Red";
            RedButton.AutoSize = true;
            RedButton.Location = new Point(100, 100);
            RedButton.Click += (sender, e) => { BackColor = System.Drawing.Color.Red; };

            this.Controls.Add(RedButton);

        }
    }
}

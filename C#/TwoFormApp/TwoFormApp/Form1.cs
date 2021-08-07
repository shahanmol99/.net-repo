using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFormApp
{
    class Form1 : Form
    {
        MaskedTextBox textBox;
        public Form1()
        {
            Label textBoxLabel = new Label();
            textBoxLabel.Text = "Enter Your Name";
            textBoxLabel.Location = new Point(80, 50);

            textBox = new MaskedTextBox();
            textBox.Location = new Point(40, 100);
            textBox.Height = 40;
            textBox.Width = 200;

            Button btn = new Button();
            btn.Text = "Next";
            btn.Location = new Point(100, 150);
            btn.Click += changeForm;

            Controls.Add(btn);
            Controls.Add(textBox);
            Controls.Add(textBoxLabel);
        }

        private void changeForm(object sender, EventArgs e)
        {
            this.Hide();
            var f2 = new Form2(textBox.Text);
            f2.ShowDialog();
        }
    }
}

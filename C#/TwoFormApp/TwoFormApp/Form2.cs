using System.Windows.Forms;

namespace TwoFormApp
{
    class Form2 : Form
    {
        public Form2(string text)
        {
            var l1 = new Label();

            l1.Text = "Hello " + text;
            Controls.Add(l1);
        }
    }
}
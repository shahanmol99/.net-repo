using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsLibrary.Data;

namespace ContactsDisplayForm
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            DataAccess contactsSqlDB = new ContactsSqlDB();
            string name = this.nameTextbox.Text;
            string number = this.numTextbox.Text;
            string address = this.addressTextbox.Text;
            string street = this.streetTextbox.Text;
            string city = this.cityTextbox.Text;
            string pincode = this.pinTextbox.Text;

            bool result = contactsSqlDB.AddContacts(name, number, address, street, city, pincode);

            if(result)
            {
                MessageBox.Show("Successfully Addeed");
                this.Hide();
                return;
            }

            MessageBox.Show("Errr!!! Something Went Wrong Pls Try Again");

        }
    }
}

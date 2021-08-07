using ContactsLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsDisplayForm
{
    public partial class AddAddressForm : Form
    {
        private string _id;
        private string _name;
        private string _number;
        public AddAddressForm(string id, string name, string number)
        {
            _id = id;
            _name = name;
            _number = number;
            InitializeComponent();
        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            DataAccess contactsSqlDB = new ContactsSqlDB();

            string address = this.addressTextbox.Text;
            string street = this.streetTextbox.Text;
            string city = this.cityTextbox.Text;
            string pin = this.pinTextbox.Text;

            bool result = contactsSqlDB.AddAddress(_id, address, street, city, pin);

            if(result)
            {
                MessageBox.Show("Sucessfully Added");
                this.Hide();
                return;
            }
            MessageBox.Show("Errr!!! Something Went Wrong Pls Try Again");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

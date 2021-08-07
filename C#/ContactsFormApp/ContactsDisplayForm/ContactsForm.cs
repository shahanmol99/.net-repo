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
using ContactsLibrary.Model;

namespace ContactsDisplayForm
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void DisplayContacts(object sender, EventArgs e)
        {
            DataAccess contactDB = new ContactsSqlDB();
            List<Contact> contacts = contactDB.GetContacts();
            this.dataGridView1.DataSource = contacts;
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            new AddContactForm().Show();
        }

        private void showAddress_Click(object sender, EventArgs e)
        {
            DataAccess contactDB = new ContactsSqlDB();
            List<ContactsWithAddress> contacts = contactDB.GetContactAndAddress();

            this.dataGridView1.DataSource = contacts;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // var obj = (DataGridView) sender;
            //var args = e.R;

            string id = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            string name = (dataGridView1.Rows[e.RowIndex].Cells[1].Value).ToString();
            string num = (dataGridView1.Rows[e.RowIndex].Cells[2].Value).ToString();
            new AddAddressForm(id, name, num).Show();

        }
    }
}

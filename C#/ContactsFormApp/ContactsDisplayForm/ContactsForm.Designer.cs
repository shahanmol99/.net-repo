
namespace ContactsDisplayForm
{
    partial class ContactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.showContacts = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addContact = new System.Windows.Forms.Button();
            this.showAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showContacts
            // 
            this.showContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showContacts.Location = new System.Drawing.Point(49, 48);
            this.showContacts.Name = "showContacts";
            this.showContacts.Size = new System.Drawing.Size(170, 60);
            this.showContacts.TabIndex = 0;
            this.showContacts.Text = "Show Contacts";
            this.showContacts.UseVisualStyleBackColor = true;
            this.showContacts.Click += new System.EventHandler(this.DisplayContacts);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 337);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addContact
            // 
            this.addContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContact.Location = new System.Drawing.Point(338, 48);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(170, 60);
            this.addContact.TabIndex = 2;
            this.addContact.Text = "Add Contact";
            this.addContact.UseVisualStyleBackColor = true;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // showAddress
            // 
            this.showAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAddress.Location = new System.Drawing.Point(638, 48);
            this.showAddress.Name = "showAddress";
            this.showAddress.Size = new System.Drawing.Size(170, 60);
            this.showAddress.TabIndex = 3;
            this.showAddress.Text = "Show Address";
            this.showAddress.UseVisualStyleBackColor = true;
            this.showAddress.Click += new System.EventHandler(this.showAddress_Click);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 538);
            this.Controls.Add(this.showAddress);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showContacts);
            this.Name = "ContactsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showContacts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addContact;
        private System.Windows.Forms.Button showAddress;
    }
}



using System.Windows.Forms;

namespace ContactsDisplayForm
{
    partial class AddAddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TextBox nameTextbox;
        private TextBox numTextbox;
        private TextBox addressTextbox;
        private TextBox cityTextbox;
        private TextBox pinTextbox;
        private TextBox streetTextbox;
        private Button addAddress;
        private Label nameLabel;
        private Label addressLabel;
        private Label numberLabel;
        private Label cityLabel;
        private Label pinLabel;
        private Label streetLabel;

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
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.numTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.pinTextbox = new System.Windows.Forms.TextBox();
            this.streetTextbox = new System.Windows.Forms.TextBox();
            this.addAddress = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextbox.Location = new System.Drawing.Point(86, 104);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Text = _name;
            this.nameTextbox.Size = new System.Drawing.Size(242, 36);
            this.nameTextbox.TabIndex = 0;
            // 
            // numTextbox
            // 
            this.numTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTextbox.Location = new System.Drawing.Point(454, 104);
            this.numTextbox.Name = "numTextbox";
            this.numTextbox.Text = _number;
            this.numTextbox.Size = new System.Drawing.Size(242, 36);
            this.numTextbox.TabIndex = 1;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextbox.Location = new System.Drawing.Point(86, 210);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(402, 36);
            this.addressTextbox.TabIndex = 2;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextbox.Location = new System.Drawing.Point(86, 313);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(242, 36);
            this.cityTextbox.TabIndex = 3;
            // 
            // pinTextbox
            // 
            this.pinTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextbox.Location = new System.Drawing.Point(454, 313);
            this.pinTextbox.Name = "pinTextbox";
            this.pinTextbox.Size = new System.Drawing.Size(242, 36);
            this.pinTextbox.TabIndex = 4;
            // 
            // streetTextbox
            // 
            this.streetTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetTextbox.Location = new System.Drawing.Point(564, 210);
            this.streetTextbox.Name = "streetTextbox";
            this.streetTextbox.Size = new System.Drawing.Size(242, 36);
            this.streetTextbox.TabIndex = 5;
            // 
            // addAddress
            // 
            this.addAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAddress.Location = new System.Drawing.Point(604, 401);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(168, 55);
            this.addAddress.TabIndex = 6;
            this.addAddress.Text = "Add";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.addAddress_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(165, 60);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(90, 32);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(165, 166);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(119, 32);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(510, 60);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(115, 32);
            this.numberLabel.TabIndex = 9;
            this.numberLabel.Text = "Number";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(165, 269);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(64, 32);
            this.cityLabel.TabIndex = 10;
            this.cityLabel.Text = "City";
            // 
            // pinLabel
            // 
            this.pinLabel.AutoSize = true;
            this.pinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinLabel.Location = new System.Drawing.Point(510, 269);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(119, 32);
            this.pinLabel.TabIndex = 11;
            this.pinLabel.Text = "Pincode";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetLabel.Location = new System.Drawing.Point(587, 166);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(91, 32);
            this.streetLabel.TabIndex = 12;
            this.streetLabel.Text = "Street";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(393, 401);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(168, 55);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.streetTextbox);
            this.Controls.Add(this.pinTextbox);
            this.Controls.Add(this.cityTextbox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.numTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Name = "AddAddressForm";
            this.Text = "yyy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancelButton;
    }
}
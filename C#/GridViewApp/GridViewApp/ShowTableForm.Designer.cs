
namespace GridViewApp
{
    partial class ShowTableForm
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
            this.showEmp = new System.Windows.Forms.Button();
            this.showDept = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showEmp
            // 
            this.showEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEmp.Location = new System.Drawing.Point(133, 70);
            this.showEmp.Name = "showEmp";
            this.showEmp.Size = new System.Drawing.Size(200, 60);
            this.showEmp.TabIndex = 0;
            this.showEmp.Text = "Show Emp";
            this.showEmp.UseVisualStyleBackColor = true;
            this.showEmp.Click += new System.EventHandler(this.ShowTable);
            // 
            // showDept
            // 
            this.showDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDept.Location = new System.Drawing.Point(471, 70);
            this.showDept.Name = "showDept";
            this.showDept.Size = new System.Drawing.Size(200, 60);
            this.showDept.TabIndex = 1;
            this.showDept.Text = "Show Dept";
            this.showDept.UseVisualStyleBackColor = true;
            this.showDept.Click += new System.EventHandler(this.ShowTable);

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 255);
            this.dataGridView1.TabIndex = 2;
            // 
            // ShowTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showDept);
            this.Controls.Add(this.showEmp);
            this.Name = "ShowTableForm";
            this.Text = "ShowTableForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showEmp;
        private System.Windows.Forms.Button showDept;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
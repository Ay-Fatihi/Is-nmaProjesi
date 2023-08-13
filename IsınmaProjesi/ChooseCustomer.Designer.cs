namespace IsınmaProjesi
{
    partial class ChooseCustomer
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            BTNMusteriSec = new Button();
            GridCustomers = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridCustomers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(BTNMusteriSec);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 72);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 6;
            label1.Text = "Müşteri Adı ve Soyadı :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 5;
            // 
            // BTNMusteriSec
            // 
            BTNMusteriSec.Location = new Point(296, 27);
            BTNMusteriSec.Name = "BTNMusteriSec";
            BTNMusteriSec.Size = new Size(75, 23);
            BTNMusteriSec.TabIndex = 4;
            BTNMusteriSec.Text = "Ara";
            BTNMusteriSec.UseVisualStyleBackColor = true;
            // 
            // GridCustomers
            // 
            GridCustomers.AllowUserToAddRows = false;
            GridCustomers.AllowUserToDeleteRows = false;
            GridCustomers.AllowUserToResizeColumns = false;
            GridCustomers.AllowUserToResizeRows = false;
            GridCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridCustomers.Dock = DockStyle.Fill;
            GridCustomers.Location = new Point(0, 72);
            GridCustomers.Name = "GridCustomers";
            GridCustomers.ReadOnly = true;
            GridCustomers.RowHeadersVisible = false;
            GridCustomers.RowTemplate.Height = 25;
            GridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridCustomers.Size = new Size(800, 378);
            GridCustomers.TabIndex = 6;
            // 
            // ChooseCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridCustomers);
            Controls.Add(groupBox1);
            Name = "ChooseCustomer";
            Text = "ChooseCustomer";
            Load += ChooseCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Button BTNMusteriSec;
        private DataGridView GridCustomers;
    }
}
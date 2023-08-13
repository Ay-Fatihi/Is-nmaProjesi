namespace IsınmaProjesi
{
    partial class ChooseProducts
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
            btnSearch = new Button();
            textBoxMA = new TextBox();
            textBoxGUrun = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            gridProductChoose = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductChoose).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(textBoxMA);
            groupBox1.Controls.Add(textBoxGUrun);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Seç";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(713, 38);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxMA
            // 
            textBoxMA.Location = new Point(124, 39);
            textBoxMA.Name = "textBoxMA";
            textBoxMA.Size = new Size(163, 23);
            textBoxMA.TabIndex = 4;
            // 
            // textBoxGUrun
            // 
            textBoxGUrun.Location = new Point(452, 39);
            textBoxGUrun.Name = "textBoxGUrun";
            textBoxGUrun.Size = new Size(150, 23);
            textBoxGUrun.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(374, 42);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Gelen Ürün :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Adı Soyadı :";
            // 
            // button1
            // 
            button1.Location = new Point(852, 34);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            // 
            // gridProductChoose
            // 
            gridProductChoose.AllowUserToAddRows = false;
            gridProductChoose.AllowUserToDeleteRows = false;
            gridProductChoose.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridProductChoose.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProductChoose.Dock = DockStyle.Fill;
            gridProductChoose.Location = new Point(0, 100);
            gridProductChoose.Name = "gridProductChoose";
            gridProductChoose.ReadOnly = true;
            gridProductChoose.RowHeadersVisible = false;
            gridProductChoose.RowTemplate.Height = 25;
            gridProductChoose.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridProductChoose.Size = new Size(800, 350);
            gridProductChoose.TabIndex = 3;
            // 
            // ChooseProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridProductChoose);
            Controls.Add(groupBox1);
            Name = "ChooseProducts";
            Text = "ChooseProducts";
            Load += ChooseProducts_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProductChoose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxMA;
        private TextBox textBoxGUrun;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button btnSearch;
        public DataGridView gridProductChoose;
    }
}

namespace UI
{
    partial class IssueBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dgwIssueBooks = new System.Windows.Forms.DataGridView();
            this.lblBookId = new System.Windows.Forms.Label();
            this.btnBackToHomeFromIssueBooks = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateIssueBook = new System.Windows.Forms.Button();
            this.btnAddIssueBook = new System.Windows.Forms.Button();
            this.cbBookNameIB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStudentNameIB = new System.Windows.Forms.ComboBox();
            this.cbFilterIssueBooks = new System.Windows.Forms.ComboBox();
            this.tbxSearchIssueBooks = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIssueBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 99);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1060, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(453, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISSUE BOOKS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(210, 330);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(208, 23);
            this.dtpIssueDate.TabIndex = 85;
            this.dtpIssueDate.Value = new System.DateTime(2021, 5, 1, 0, 0, 0, 0);
            // 
            // dgwIssueBooks
            // 
            this.dgwIssueBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIssueBooks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwIssueBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwIssueBooks.ColumnHeadersHeight = 30;
            this.dgwIssueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwIssueBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwIssueBooks.EnableHeadersVisualStyles = false;
            this.dgwIssueBooks.Location = new System.Drawing.Point(510, 180);
            this.dgwIssueBooks.Name = "dgwIssueBooks";
            this.dgwIssueBooks.RowTemplate.Height = 25;
            this.dgwIssueBooks.Size = new System.Drawing.Size(560, 500);
            this.dgwIssueBooks.TabIndex = 78;
            this.dgwIssueBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIssueBooks_CellClick);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.Location = new System.Drawing.Point(25, 290);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(116, 22);
            this.lblBookId.TabIndex = 72;
            this.lblBookId.Text = "Book Name";
            // 
            // btnBackToHomeFromIssueBooks
            // 
            this.btnBackToHomeFromIssueBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackToHomeFromIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnBackToHomeFromIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHomeFromIssueBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToHomeFromIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnBackToHomeFromIssueBooks.Location = new System.Drawing.Point(116, 444);
            this.btnBackToHomeFromIssueBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackToHomeFromIssueBooks.Name = "btnBackToHomeFromIssueBooks";
            this.btnBackToHomeFromIssueBooks.Size = new System.Drawing.Size(200, 42);
            this.btnBackToHomeFromIssueBooks.TabIndex = 77;
            this.btnBackToHomeFromIssueBooks.Text = "Back to home";
            this.btnBackToHomeFromIssueBooks.UseVisualStyleBackColor = false;
            this.btnBackToHomeFromIssueBooks.Click += new System.EventHandler(this.btnBackToHomeFromIssueBooks_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(25, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 73;
            this.label5.Text = "Issue Date";
            // 
            // btnUpdateIssueBook
            // 
            this.btnUpdateIssueBook.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateIssueBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateIssueBook.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateIssueBook.Location = new System.Drawing.Point(171, 387);
            this.btnUpdateIssueBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateIssueBook.Name = "btnUpdateIssueBook";
            this.btnUpdateIssueBook.Size = new System.Drawing.Size(110, 42);
            this.btnUpdateIssueBook.TabIndex = 76;
            this.btnUpdateIssueBook.Text = "Update";
            this.btnUpdateIssueBook.UseVisualStyleBackColor = false;
            this.btnUpdateIssueBook.Click += new System.EventHandler(this.btnUpdateIssueBook_Click);
            // 
            // btnAddIssueBook
            // 
            this.btnAddIssueBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddIssueBook.FlatAppearance.BorderSize = 0;
            this.btnAddIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIssueBook.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnAddIssueBook.Location = new System.Drawing.Point(25, 387);
            this.btnAddIssueBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddIssueBook.Name = "btnAddIssueBook";
            this.btnAddIssueBook.Size = new System.Drawing.Size(116, 42);
            this.btnAddIssueBook.TabIndex = 74;
            this.btnAddIssueBook.Text = "Issue Book";
            this.btnAddIssueBook.UseVisualStyleBackColor = false;
            this.btnAddIssueBook.Click += new System.EventHandler(this.btnAddIssueBook_Click);
            // 
            // cbBookNameIB
            // 
            this.cbBookNameIB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBookNameIB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBookNameIB.FormattingEnabled = true;
            this.cbBookNameIB.Location = new System.Drawing.Point(210, 290);
            this.cbBookNameIB.Name = "cbBookNameIB";
            this.cbBookNameIB.Size = new System.Drawing.Size(206, 23);
            this.cbBookNameIB.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(25, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 88;
            this.label7.Text = "Student Name";
            // 
            // cbStudentNameIB
            // 
            this.cbStudentNameIB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStudentNameIB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStudentNameIB.FormattingEnabled = true;
            this.cbStudentNameIB.Location = new System.Drawing.Point(210, 250);
            this.cbStudentNameIB.Name = "cbStudentNameIB";
            this.cbStudentNameIB.Size = new System.Drawing.Size(206, 23);
            this.cbStudentNameIB.TabIndex = 90;
            // 
            // cbFilterIssueBooks
            // 
            this.cbFilterIssueBooks.FormattingEnabled = true;
            this.cbFilterIssueBooks.Items.AddRange(new object[] {
            "Search by Student Name",
            "Search by Book Name"});
            this.cbFilterIssueBooks.Location = new System.Drawing.Point(510, 145);
            this.cbFilterIssueBooks.Name = "cbFilterIssueBooks";
            this.cbFilterIssueBooks.Size = new System.Drawing.Size(260, 23);
            this.cbFilterIssueBooks.TabIndex = 95;
            // 
            // tbxSearchIssueBooks
            // 
            this.tbxSearchIssueBooks.Location = new System.Drawing.Point(810, 145);
            this.tbxSearchIssueBooks.Name = "tbxSearchIssueBooks";
            this.tbxSearchIssueBooks.Size = new System.Drawing.Size(260, 23);
            this.tbxSearchIssueBooks.TabIndex = 96;
            this.tbxSearchIssueBooks.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(308, 387);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 42);
            this.btnReset.TabIndex = 113;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxSearchIssueBooks);
            this.Controls.Add(this.cbFilterIssueBooks);
            this.Controls.Add(this.cbStudentNameIB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBookNameIB);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dgwIssueBooks);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.btnBackToHomeFromIssueBooks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateIssueBook);
            this.Controls.Add(this.btnAddIssueBook);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBookForm";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIssueBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DataGridView dgwIssueBooks;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnBackToHomeFromIssueBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateIssueBook;
        private System.Windows.Forms.Button btnAddIssueBook;
        private System.Windows.Forms.ComboBox cbBookNameIB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStudentNameIB;
        private System.Windows.Forms.ComboBox cbFilterIssueBooks;
        private System.Windows.Forms.TextBox tbxSearchIssueBooks;
        private System.Windows.Forms.Button btnReset;
    }
}

namespace UI
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudentNameRB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBookNameRB = new System.Windows.Forms.ComboBox();
            this.dtpIssueDateRB = new System.Windows.Forms.DateTimePicker();
            this.lblBookId = new System.Windows.Forms.Label();
            this.btnBackToHomeFromIssueBooks = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateReturnBook = new System.Windows.Forms.Button();
            this.btnReturnIssueBook = new System.Windows.Forms.Button();
            this.tbxSearchIssueBooks = new System.Windows.Forms.TextBox();
            this.cbFilterIssueBooks = new System.Windows.Forms.ComboBox();
            this.dgwIssueBooksRB = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgwReturnBooks = new System.Windows.Forms.DataGridView();
            this.dtpReturnDateRB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxFine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculateFine = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIssueBooksRB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReturnBooks)).BeginInit();
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
            this.panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1060, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            this.label2.Size = new System.Drawing.Size(216, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "RETURN BOOKS";
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
            // cbStudentNameRB
            // 
            this.cbStudentNameRB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStudentNameRB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStudentNameRB.FormattingEnabled = true;
            this.cbStudentNameRB.Location = new System.Drawing.Point(217, 200);
            this.cbStudentNameRB.Name = "cbStudentNameRB";
            this.cbStudentNameRB.Size = new System.Drawing.Size(206, 23);
            this.cbStudentNameRB.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(32, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 99;
            this.label7.Text = "Student Name";
            // 
            // cbBookNameRB
            // 
            this.cbBookNameRB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBookNameRB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBookNameRB.FormattingEnabled = true;
            this.cbBookNameRB.Location = new System.Drawing.Point(217, 240);
            this.cbBookNameRB.Name = "cbBookNameRB";
            this.cbBookNameRB.Size = new System.Drawing.Size(206, 23);
            this.cbBookNameRB.TabIndex = 98;
            // 
            // dtpIssueDateRB
            // 
            this.dtpIssueDateRB.Location = new System.Drawing.Point(217, 280);
            this.dtpIssueDateRB.Name = "dtpIssueDateRB";
            this.dtpIssueDateRB.Size = new System.Drawing.Size(208, 23);
            this.dtpIssueDateRB.TabIndex = 97;
            this.dtpIssueDateRB.Value = new System.DateTime(2020, 2, 21, 18, 46, 0, 0);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.Location = new System.Drawing.Point(32, 240);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(116, 22);
            this.lblBookId.TabIndex = 91;
            this.lblBookId.Text = "Book Name";
            // 
            // btnBackToHomeFromIssueBooks
            // 
            this.btnBackToHomeFromIssueBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackToHomeFromIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnBackToHomeFromIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHomeFromIssueBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToHomeFromIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnBackToHomeFromIssueBooks.Location = new System.Drawing.Point(117, 506);
            this.btnBackToHomeFromIssueBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackToHomeFromIssueBooks.Name = "btnBackToHomeFromIssueBooks";
            this.btnBackToHomeFromIssueBooks.Size = new System.Drawing.Size(200, 42);
            this.btnBackToHomeFromIssueBooks.TabIndex = 96;
            this.btnBackToHomeFromIssueBooks.Text = "Back to home";
            this.btnBackToHomeFromIssueBooks.UseVisualStyleBackColor = false;
            this.btnBackToHomeFromIssueBooks.Click += new System.EventHandler(this.btnBackToHomeFromIssueBooks_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 92;
            this.label5.Text = "Issue Date";
            // 
            // btnUpdateReturnBook
            // 
            this.btnUpdateReturnBook.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateReturnBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateReturnBook.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateReturnBook.Location = new System.Drawing.Point(262, 449);
            this.btnUpdateReturnBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateReturnBook.Name = "btnUpdateReturnBook";
            this.btnUpdateReturnBook.Size = new System.Drawing.Size(110, 42);
            this.btnUpdateReturnBook.TabIndex = 95;
            this.btnUpdateReturnBook.Text = "Update";
            this.btnUpdateReturnBook.UseVisualStyleBackColor = false;
            this.btnUpdateReturnBook.Click += new System.EventHandler(this.btnUpdateReturnBook_Click);
            // 
            // btnReturnIssueBook
            // 
            this.btnReturnIssueBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnReturnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnReturnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnIssueBook.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnIssueBook.Location = new System.Drawing.Point(77, 449);
            this.btnReturnIssueBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReturnIssueBook.Name = "btnReturnIssueBook";
            this.btnReturnIssueBook.Size = new System.Drawing.Size(116, 42);
            this.btnReturnIssueBook.TabIndex = 93;
            this.btnReturnIssueBook.Text = "Return Book";
            this.btnReturnIssueBook.UseVisualStyleBackColor = false;
            this.btnReturnIssueBook.Click += new System.EventHandler(this.btnReturnIssueBook_Click);
            // 
            // tbxSearchIssueBooks
            // 
            this.tbxSearchIssueBooks.Location = new System.Drawing.Point(827, 125);
            this.tbxSearchIssueBooks.Name = "tbxSearchIssueBooks";
            this.tbxSearchIssueBooks.Size = new System.Drawing.Size(260, 23);
            this.tbxSearchIssueBooks.TabIndex = 103;
            // 
            // cbFilterIssueBooks
            // 
            this.cbFilterIssueBooks.FormattingEnabled = true;
            this.cbFilterIssueBooks.Items.AddRange(new object[] {
            "Search by Student Name",
            "Search by Book Name"});
            this.cbFilterIssueBooks.Location = new System.Drawing.Point(527, 125);
            this.cbFilterIssueBooks.Name = "cbFilterIssueBooks";
            this.cbFilterIssueBooks.Size = new System.Drawing.Size(260, 23);
            this.cbFilterIssueBooks.TabIndex = 102;
            // 
            // dgwIssueBooksRB
            // 
            this.dgwIssueBooksRB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIssueBooksRB.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwIssueBooksRB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwIssueBooksRB.ColumnHeadersHeight = 30;
            this.dgwIssueBooksRB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwIssueBooksRB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwIssueBooksRB.EnableHeadersVisualStyles = false;
            this.dgwIssueBooksRB.Location = new System.Drawing.Point(527, 180);
            this.dgwIssueBooksRB.Name = "dgwIssueBooksRB";
            this.dgwIssueBooksRB.RowTemplate.Height = 25;
            this.dgwIssueBooksRB.Size = new System.Drawing.Size(560, 224);
            this.dgwIssueBooksRB.TabIndex = 101;
            this.dgwIssueBooksRB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIssueBooksRB_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(734, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 104;
            this.label3.Text = "Book Issued";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(734, 421);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 106;
            this.label4.Text = "Book Returned";
            // 
            // dgwReturnBooks
            // 
            this.dgwReturnBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwReturnBooks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwReturnBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwReturnBooks.ColumnHeadersHeight = 30;
            this.dgwReturnBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwReturnBooks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwReturnBooks.EnableHeadersVisualStyles = false;
            this.dgwReturnBooks.Location = new System.Drawing.Point(528, 449);
            this.dgwReturnBooks.Name = "dgwReturnBooks";
            this.dgwReturnBooks.RowTemplate.Height = 25;
            this.dgwReturnBooks.Size = new System.Drawing.Size(560, 249);
            this.dgwReturnBooks.TabIndex = 105;
            this.dgwReturnBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwReturnBooks_CellClick);
            // 
            // dtpReturnDateRB
            // 
            this.dtpReturnDateRB.Location = new System.Drawing.Point(217, 320);
            this.dtpReturnDateRB.Name = "dtpReturnDateRB";
            this.dtpReturnDateRB.Size = new System.Drawing.Size(208, 23);
            this.dtpReturnDateRB.TabIndex = 108;
            this.dtpReturnDateRB.Value = new System.DateTime(2020, 2, 21, 18, 46, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 107;
            this.label6.Text = "Return Date";
            // 
            // tbxFine
            // 
            this.tbxFine.Location = new System.Drawing.Point(217, 362);
            this.tbxFine.Name = "tbxFine";
            this.tbxFine.Size = new System.Drawing.Size(206, 23);
            this.tbxFine.TabIndex = 109;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(32, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 110;
            this.label8.Text = "Fine";
            // 
            // btnCalculateFine
            // 
            this.btnCalculateFine.BackColor = System.Drawing.Color.DimGray;
            this.btnCalculateFine.FlatAppearance.BorderSize = 0;
            this.btnCalculateFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateFine.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculateFine.ForeColor = System.Drawing.Color.White;
            this.btnCalculateFine.Location = new System.Drawing.Point(315, 391);
            this.btnCalculateFine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCalculateFine.Name = "btnCalculateFine";
            this.btnCalculateFine.Size = new System.Drawing.Size(110, 27);
            this.btnCalculateFine.TabIndex = 111;
            this.btnCalculateFine.Text = "Calculate";
            this.btnCalculateFine.UseVisualStyleBackColor = false;
            this.btnCalculateFine.Click += new System.EventHandler(this.btnCalculateFine_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btnCalculateFine);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxFine);
            this.Controls.Add(this.dtpReturnDateRB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgwReturnBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSearchIssueBooks);
            this.Controls.Add(this.cbFilterIssueBooks);
            this.Controls.Add(this.dgwIssueBooksRB);
            this.Controls.Add(this.cbStudentNameRB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBookNameRB);
            this.Controls.Add(this.dtpIssueDateRB);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.btnBackToHomeFromIssueBooks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateReturnBook);
            this.Controls.Add(this.btnReturnIssueBook);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIssueBooksRB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReturnBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudentNameRB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBookNameRB;
        private System.Windows.Forms.DateTimePicker dtpIssueDateRB;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnBackToHomeFromIssueBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateReturnBook;
        private System.Windows.Forms.Button btnReturnIssueBook;
        private System.Windows.Forms.TextBox tbxSearchIssueBooks;
        private System.Windows.Forms.ComboBox cbFilterIssueBooks;
        private System.Windows.Forms.DataGridView dgwIssueBooksRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgwReturnBooks;
        private System.Windows.Forms.DateTimePicker dtpReturnDateRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculateFine;
    }
}

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.dgwIssueBooks = new System.Windows.Forms.DataGridView();
            this.lblBookId = new System.Windows.Forms.Label();
            this.btnBackToHomeFromIssueBooks = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateIssueBook = new System.Windows.Forms.Button();
            this.btnAddIssueBook = new System.Windows.Forms.Button();
            this.btnDeleteIssueBook = new System.Windows.Forms.Button();
            this.cbBookId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStudentId = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIssueBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 99);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(936, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1098, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(429, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISSUE BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(194, 343);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(197, 23);
            this.dtpIssueDate.TabIndex = 85;
            this.dtpIssueDate.Value = new System.DateTime(2020, 2, 21, 18, 46, 0, 0);
            // 
            // dgwIssueBooks
            // 
            this.dgwIssueBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwIssueBooks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwIssueBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwIssueBooks.ColumnHeadersHeight = 30;
            this.dgwIssueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwIssueBooks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwIssueBooks.EnableHeadersVisualStyles = false;
            this.dgwIssueBooks.Location = new System.Drawing.Point(429, 157);
            this.dgwIssueBooks.Name = "dgwIssueBooks";
            this.dgwIssueBooks.RowTemplate.Height = 25;
            this.dgwIssueBooks.Size = new System.Drawing.Size(510, 436);
            this.dgwIssueBooks.TabIndex = 78;
            this.dgwIssueBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIssueBooks_CellClick);
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookId.ForeColor = System.Drawing.Color.Black;
            this.lblBookId.Location = new System.Drawing.Point(47, 295);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(78, 22);
            this.lblBookId.TabIndex = 72;
            this.lblBookId.Text = "Book Id";
            // 
            // btnBackToHomeFromIssueBooks
            // 
            this.btnBackToHomeFromIssueBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackToHomeFromIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnBackToHomeFromIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHomeFromIssueBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToHomeFromIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnBackToHomeFromIssueBooks.Location = new System.Drawing.Point(113, 469);
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
            this.label5.Location = new System.Drawing.Point(49, 343);
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
            this.btnUpdateIssueBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateIssueBook.Location = new System.Drawing.Point(157, 410);
            this.btnUpdateIssueBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateIssueBook.Name = "btnUpdateIssueBook";
            this.btnUpdateIssueBook.Size = new System.Drawing.Size(108, 42);
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
            this.btnAddIssueBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnAddIssueBook.Location = new System.Drawing.Point(47, 410);
            this.btnAddIssueBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddIssueBook.Name = "btnAddIssueBook";
            this.btnAddIssueBook.Size = new System.Drawing.Size(88, 42);
            this.btnAddIssueBook.TabIndex = 74;
            this.btnAddIssueBook.Text = "Add";
            this.btnAddIssueBook.UseVisualStyleBackColor = false;
            this.btnAddIssueBook.Click += new System.EventHandler(this.btnAddIssueBook_Click);
            // 
            // btnDeleteIssueBook
            // 
            this.btnDeleteIssueBook.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteIssueBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIssueBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteIssueBook.Location = new System.Drawing.Point(287, 410);
            this.btnDeleteIssueBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteIssueBook.Name = "btnDeleteIssueBook";
            this.btnDeleteIssueBook.Size = new System.Drawing.Size(102, 42);
            this.btnDeleteIssueBook.TabIndex = 75;
            this.btnDeleteIssueBook.Text = "Delete";
            this.btnDeleteIssueBook.UseVisualStyleBackColor = false;
            this.btnDeleteIssueBook.Click += new System.EventHandler(this.btnDeleteIssueBook_Click);
            // 
            // cbBookId
            // 
            this.cbBookId.FormattingEnabled = true;
            this.cbBookId.Location = new System.Drawing.Point(194, 294);
            this.cbBookId.Name = "cbBookId";
            this.cbBookId.Size = new System.Drawing.Size(195, 23);
            this.cbBookId.TabIndex = 87;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(47, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 88;
            this.label7.Text = "Student Id";
            // 
            // cbStudentId
            // 
            this.cbStudentId.FormattingEnabled = true;
            this.cbStudentId.Location = new System.Drawing.Point(194, 246);
            this.cbStudentId.Name = "cbStudentId";
            this.cbStudentId.Size = new System.Drawing.Size(195, 23);
            this.cbStudentId.TabIndex = 96;
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(976, 647);
            this.Controls.Add(this.cbStudentId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBookId);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.dgwIssueBooks);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.btnBackToHomeFromIssueBooks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateIssueBook);
            this.Controls.Add(this.btnAddIssueBook);
            this.Controls.Add(this.btnDeleteIssueBook);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBookForm";
            this.Load += new System.EventHandler(this.IssueBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIssueBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.DataGridView dgwIssueBooks;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnBackToHomeFromIssueBooks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdateIssueBook;
        private System.Windows.Forms.Button btnAddIssueBook;
        private System.Windows.Forms.Button btnDeleteIssueBook;
        private System.Windows.Forms.ComboBox cbBookId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStudentId;
    }
}
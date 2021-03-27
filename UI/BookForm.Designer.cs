
namespace UI
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAuthor = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.btnBackToHomeFromBooks = new System.Windows.Forms.Button();
            this.btnUpdateLBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.tbxSearchBooks = new System.Windows.Forms.TextBox();
            this.cbFilterBooks = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
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
            this.panel1.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(496, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // tbxAuthor
            // 
            this.tbxAuthor.Location = new System.Drawing.Point(177, 237);
            this.tbxAuthor.Name = "tbxAuthor";
            this.tbxAuthor.Size = new System.Drawing.Size(197, 23);
            this.tbxAuthor.TabIndex = 64;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(177, 189);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(197, 23);
            this.tbxName.TabIndex = 63;
            // 
            // dgwBooks
            // 
            this.dgwBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBooks.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwBooks.ColumnHeadersHeight = 30;
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBooks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgwBooks.EnableHeadersVisualStyles = false;
            this.dgwBooks.Location = new System.Drawing.Point(510, 180);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowTemplate.Height = 25;
            this.dgwBooks.Size = new System.Drawing.Size(560, 500);
            this.dgwBooks.TabIndex = 62;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // btnBackToHomeFromBooks
            // 
            this.btnBackToHomeFromBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackToHomeFromBooks.FlatAppearance.BorderSize = 0;
            this.btnBackToHomeFromBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHomeFromBooks.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToHomeFromBooks.ForeColor = System.Drawing.Color.White;
            this.btnBackToHomeFromBooks.Location = new System.Drawing.Point(98, 485);
            this.btnBackToHomeFromBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackToHomeFromBooks.Name = "btnBackToHomeFromBooks";
            this.btnBackToHomeFromBooks.Size = new System.Drawing.Size(200, 42);
            this.btnBackToHomeFromBooks.TabIndex = 61;
            this.btnBackToHomeFromBooks.Text = "Back to home";
            this.btnBackToHomeFromBooks.UseVisualStyleBackColor = false;
            this.btnBackToHomeFromBooks.Click += new System.EventHandler(this.btnBackToHomeFromBooks_Click);
            // 
            // btnUpdateLBook
            // 
            this.btnUpdateLBook.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateLBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateLBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateLBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLBook.Location = new System.Drawing.Point(142, 426);
            this.btnUpdateLBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateLBook.Name = "btnUpdateLBook";
            this.btnUpdateLBook.Size = new System.Drawing.Size(108, 42);
            this.btnUpdateLBook.TabIndex = 60;
            this.btnUpdateLBook.Text = "Update";
            this.btnUpdateLBook.UseVisualStyleBackColor = false;
            this.btnUpdateLBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteBook.FlatAppearance.BorderSize = 0;
            this.btnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBook.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBook.Location = new System.Drawing.Point(272, 426);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(102, 42);
            this.btnDeleteBook.TabIndex = 59;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Location = new System.Drawing.Point(32, 426);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(88, 42);
            this.btnAddBook.TabIndex = 58;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(32, 282);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Publish Date";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(30, 234);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(74, 22);
            this.lblStudentName.TabIndex = 56;
            this.lblStudentName.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Name";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(177, 375);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(197, 23);
            this.tbxQuantity.TabIndex = 69;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(177, 332);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(197, 23);
            this.tbxPrice.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(32, 329);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(32, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "Quantity";
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Location = new System.Drawing.Point(177, 282);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(197, 23);
            this.dtpPublishDate.TabIndex = 70;
            this.dtpPublishDate.Value = new System.DateTime(2020, 2, 21, 18, 46, 0, 0);
            // 
            // tbxSearchBooks
            // 
            this.tbxSearchBooks.Location = new System.Drawing.Point(810, 145);
            this.tbxSearchBooks.Name = "tbxSearchBooks";
            this.tbxSearchBooks.Size = new System.Drawing.Size(260, 23);
            this.tbxSearchBooks.TabIndex = 98;
            this.tbxSearchBooks.TextChanged += new System.EventHandler(this.tbxSearchBooks_TextChanged);
            // 
            // cbFilterBooks
            // 
            this.cbFilterBooks.FormattingEnabled = true;
            this.cbFilterBooks.Items.AddRange(new object[] {
            "Search by Name",
            "Search by Author"});
            this.cbFilterBooks.Location = new System.Drawing.Point(510, 145);
            this.cbFilterBooks.Name = "cbFilterBooks";
            this.cbFilterBooks.Size = new System.Drawing.Size(260, 23);
            this.cbFilterBooks.TabIndex = 97;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tbxSearchBooks);
            this.Controls.Add(this.cbFilterBooks);
            this.Controls.Add(this.dtpPublishDate);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxAuthor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgwBooks);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnBackToHomeFromBooks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateLBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnDeleteBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAuthor;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgwBooks;
        private System.Windows.Forms.Button btnBackToHomeFromBooks;
        private System.Windows.Forms.Button btnUpdateLBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.TextBox tbxSearchBooks;
        private System.Windows.Forms.ComboBox cbFilterBooks;
    }
}
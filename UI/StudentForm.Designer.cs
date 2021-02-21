
namespace UI
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCourse = new System.Windows.Forms.TextBox();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dgwStudents = new System.Windows.Forms.DataGridView();
            this.btnBackToHomeFromLibrarians = new System.Windows.Forms.Button();
            this.btnUpdateLibrarian = new System.Windows.Forms.Button();
            this.btnDeleteLibrarian = new System.Windows.Forms.Button();
            this.btnAddLibrarian = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).BeginInit();
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
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(936, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
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
            this.label2.Location = new System.Drawing.Point(423, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "STUDENTS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // tbxCourse
            // 
            this.tbxCourse.Location = new System.Drawing.Point(186, 257);
            this.tbxCourse.Name = "tbxCourse";
            this.tbxCourse.Size = new System.Drawing.Size(197, 23);
            this.tbxCourse.TabIndex = 65;
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.Location = new System.Drawing.Point(186, 209);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.Size = new System.Drawing.Size(197, 23);
            this.tbxDepartment.TabIndex = 64;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(186, 161);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(197, 23);
            this.tbxName.TabIndex = 63;
            // 
            // dgwStudents
            // 
            this.dgwStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgwStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudents.Location = new System.Drawing.Point(432, 145);
            this.dgwStudents.Name = "dgwStudents";
            this.dgwStudents.RowTemplate.Height = 25;
            this.dgwStudents.Size = new System.Drawing.Size(510, 436);
            this.dgwStudents.TabIndex = 62;
            this.dgwStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwStudents_CellClick);
            // 
            // btnBackToHomeFromLibrarians
            // 
            this.btnBackToHomeFromLibrarians.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackToHomeFromLibrarians.FlatAppearance.BorderSize = 0;
            this.btnBackToHomeFromLibrarians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHomeFromLibrarians.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackToHomeFromLibrarians.ForeColor = System.Drawing.Color.White;
            this.btnBackToHomeFromLibrarians.Location = new System.Drawing.Point(107, 441);
            this.btnBackToHomeFromLibrarians.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBackToHomeFromLibrarians.Name = "btnBackToHomeFromLibrarians";
            this.btnBackToHomeFromLibrarians.Size = new System.Drawing.Size(200, 42);
            this.btnBackToHomeFromLibrarians.TabIndex = 61;
            this.btnBackToHomeFromLibrarians.Text = "Back to home";
            this.btnBackToHomeFromLibrarians.UseVisualStyleBackColor = false;
            this.btnBackToHomeFromLibrarians.Click += new System.EventHandler(this.btnBackToHomeFromLibrarians_Click);
            // 
            // btnUpdateLibrarian
            // 
            this.btnUpdateLibrarian.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateLibrarian.FlatAppearance.BorderSize = 0;
            this.btnUpdateLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLibrarian.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateLibrarian.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLibrarian.Location = new System.Drawing.Point(151, 382);
            this.btnUpdateLibrarian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateLibrarian.Name = "btnUpdateLibrarian";
            this.btnUpdateLibrarian.Size = new System.Drawing.Size(108, 42);
            this.btnUpdateLibrarian.TabIndex = 60;
            this.btnUpdateLibrarian.Text = "Update";
            this.btnUpdateLibrarian.UseVisualStyleBackColor = false;
            this.btnUpdateLibrarian.Click += new System.EventHandler(this.btnUpdateLibrarian_Click);
            // 
            // btnDeleteLibrarian
            // 
            this.btnDeleteLibrarian.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteLibrarian.FlatAppearance.BorderSize = 0;
            this.btnDeleteLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLibrarian.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteLibrarian.ForeColor = System.Drawing.Color.White;
            this.btnDeleteLibrarian.Location = new System.Drawing.Point(281, 382);
            this.btnDeleteLibrarian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteLibrarian.Name = "btnDeleteLibrarian";
            this.btnDeleteLibrarian.Size = new System.Drawing.Size(102, 42);
            this.btnDeleteLibrarian.TabIndex = 59;
            this.btnDeleteLibrarian.Text = "Delete";
            this.btnDeleteLibrarian.UseVisualStyleBackColor = false;
            this.btnDeleteLibrarian.Click += new System.EventHandler(this.btnDeleteLibrarian_Click);
            // 
            // btnAddLibrarian
            // 
            this.btnAddLibrarian.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddLibrarian.FlatAppearance.BorderSize = 0;
            this.btnAddLibrarian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLibrarian.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLibrarian.ForeColor = System.Drawing.Color.White;
            this.btnAddLibrarian.Location = new System.Drawing.Point(41, 382);
            this.btnAddLibrarian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddLibrarian.Name = "btnAddLibrarian";
            this.btnAddLibrarian.Size = new System.Drawing.Size(88, 42);
            this.btnAddLibrarian.TabIndex = 58;
            this.btnAddLibrarian.Text = "Add";
            this.btnAddLibrarian.UseVisualStyleBackColor = false;
            this.btnAddLibrarian.Click += new System.EventHandler(this.btnAddLibrarian_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Course";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(39, 206);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(123, 22);
            this.lblStudentName.TabIndex = 56;
            this.lblStudentName.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Name";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(186, 300);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(197, 23);
            this.tbxPhone.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(41, 301);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Phone";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(976, 647);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxCourse);
            this.Controls.Add(this.tbxDepartment);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.dgwStudents);
            this.Controls.Add(this.btnBackToHomeFromLibrarians);
            this.Controls.Add(this.btnUpdateLibrarian);
            this.Controls.Add(this.btnDeleteLibrarian);
            this.Controls.Add(this.btnAddLibrarian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCourse;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgwStudents;
        private System.Windows.Forms.Button btnBackToHomeFromLibrarians;
        private System.Windows.Forms.Button btnUpdateLibrarian;
        private System.Windows.Forms.Button btnDeleteLibrarian;
        private System.Windows.Forms.Button btnAddLibrarian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
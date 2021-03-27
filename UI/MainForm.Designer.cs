
namespace UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.btnLibrarians = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelNavbar.Controls.Add(this.pictureBox1);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(1100, 46);
            this.panelNavbar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1062, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelFooter.Controls.Add(this.button8);
            this.panelFooter.Controls.Add(this.button7);
            this.panelFooter.Controls.Add(this.button6);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 635);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1100, 65);
            this.panelFooter.TabIndex = 1;
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(684, 0);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(348, 65);
            this.button8.TabIndex = 2;
            this.button8.Text = "Tips";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(342, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(344, 65);
            this.button7.TabIndex = 1;
            this.button7.Text = "Dashboard";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(344, 65);
            this.button6.TabIndex = 0;
            this.button6.Text = "About";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "ASOIU Library";
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.Location = new System.Drawing.Point(684, 63);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(99, 39);
            this.btnStudents.TabIndex = 4;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click_1);
            // 
            // btnBooks
            // 
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.Location = new System.Drawing.Point(776, 63);
            this.btnBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(82, 39);
            this.btnBooks.TabIndex = 5;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.FlatAppearance.BorderSize = 0;
            this.btnIssueBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIssueBooks.ForeColor = System.Drawing.Color.White;
            this.btnIssueBooks.Location = new System.Drawing.Point(857, 63);
            this.btnIssueBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(118, 39);
            this.btnIssueBooks.TabIndex = 6;
            this.btnIssueBooks.Text = "Issue Books";
            this.btnIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
            // 
            // btnLibrarians
            // 
            this.btnLibrarians.FlatAppearance.BorderSize = 0;
            this.btnLibrarians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrarians.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLibrarians.ForeColor = System.Drawing.Color.White;
            this.btnLibrarians.Location = new System.Drawing.Point(975, 63);
            this.btnLibrarians.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLibrarians.Name = "btnLibrarians";
            this.btnLibrarians.Size = new System.Drawing.Size(108, 39);
            this.btnLibrarians.TabIndex = 8;
            this.btnLibrarians.Text = "Librarians";
            this.btnLibrarians.UseVisualStyleBackColor = true;
            this.btnLibrarians.Click += new System.EventHandler(this.btnLibrarians_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(28, 63);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 116);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1100, 520);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLibrarians);
            this.Controls.Add(this.btnIssueBooks);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelNavbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Button btnLibrarians;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
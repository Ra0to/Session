using System.ComponentModel;

namespace SessionForms
{
	partial class AddRow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			this.CourseText = new System.Windows.Forms.Label();
			this.Course = new System.Windows.Forms.TextBox();
			this.Group = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Document = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Lesson = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Mark = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CourseText
			// 
			this.CourseText.Location = new System.Drawing.Point(12, 33);
			this.CourseText.Name = "CourseText";
			this.CourseText.Size = new System.Drawing.Size(100, 23);
			this.CourseText.TabIndex = 0;
			this.CourseText.Text = "Course";
			// 
			// Course
			// 
			this.Course.Location = new System.Drawing.Point(76, 30);
			this.Course.Name = "Course";
			this.Course.Size = new System.Drawing.Size(100, 20);
			this.Course.TabIndex = 1;
			// 
			// Group
			// 
			this.Group.Location = new System.Drawing.Point(76, 59);
			this.Group.Name = "Group";
			this.Group.Size = new System.Drawing.Size(100, 20);
			this.Group.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Group";
			// 
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(76, 88);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(100, 20);
			this.LastName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Last name";
			// 
			// Document
			// 
			this.Document.Location = new System.Drawing.Point(76, 117);
			this.Document.Name = "Document";
			this.Document.Size = new System.Drawing.Size(100, 20);
			this.Document.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Document";
			// 
			// Lesson
			// 
			this.Lesson.Location = new System.Drawing.Point(76, 146);
			this.Lesson.Name = "Lesson";
			this.Lesson.Size = new System.Drawing.Size(100, 20);
			this.Lesson.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Lesson";
			// 
			// Mark
			// 
			this.Mark.Location = new System.Drawing.Point(76, 172);
			this.Mark.Name = "Mark";
			this.Mark.Size = new System.Drawing.Size(100, 20);
			this.Mark.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 175);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Mark";
			// 
			// Add
			// 
			this.Add.Location = new System.Drawing.Point(76, 214);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(75, 23);
			this.Add.TabIndex = 12;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// AddRow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(204, 261);
			this.Controls.Add(this.Add);
			this.Controls.Add(this.Mark);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Lesson);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Document);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Group);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Course);
			this.Controls.Add(this.CourseText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddRow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddRow";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button Add;
		public System.Windows.Forms.TextBox Course;
		private System.Windows.Forms.Label CourseText;
		public System.Windows.Forms.TextBox Document;
		public System.Windows.Forms.TextBox Group;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox LastName;
		public System.Windows.Forms.TextBox Lesson;
		public System.Windows.Forms.TextBox Mark;

		#endregion
	}
}
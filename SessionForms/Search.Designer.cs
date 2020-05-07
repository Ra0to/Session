using System.ComponentModel;

namespace SessionForms
{
	partial class Search
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
			this.Input = new System.Windows.Forms.TextBox();
			this.Text = new System.Windows.Forms.Label();
			this.Button = new System.Windows.Forms.Button();
			this.DropDown = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Input
			// 
			this.Input.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.Input.Location = new System.Drawing.Point(152, 86);
			this.Input.Name = "Input";
			this.Input.Size = new System.Drawing.Size(186, 20);
			this.Input.TabIndex = 0;
			// 
			// Text
			// 
			this.Text.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.Text.Location = new System.Drawing.Point(0, 34);
			this.Text.Name = "Text";
			this.Text.Size = new System.Drawing.Size(384, 33);
			this.Text.TabIndex = 1;
			this.Text.Text = "Search:";
			this.Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Button
			// 
			this.Button.Location = new System.Drawing.Point(152, 126);
			this.Button.Name = "Button";
			this.Button.Size = new System.Drawing.Size(75, 23);
			this.Button.TabIndex = 2;
			this.Button.Text = "Go!";
			this.Button.UseVisualStyleBackColor = true;
			this.Button.Click += new System.EventHandler(this.FindButton_Click);
			// 
			// DropDown
			// 
			this.DropDown.FormattingEnabled = true;
			this.DropDown.Location = new System.Drawing.Point(53, 86);
			this.DropDown.Name = "DropDown";
			this.DropDown.Size = new System.Drawing.Size(93, 21);
			this.DropDown.TabIndex = 3;
			// 
			// Search
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.DropDown);
			this.Controls.Add(this.Button);
			this.Controls.Add(this.Text);
			this.Controls.Add(this.Input);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Search";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		public System.Windows.Forms.Button Button;
		public System.Windows.Forms.ComboBox DropDown;
		public System.Windows.Forms.TextBox Input;
		public System.Windows.Forms.Label Text;

		#endregion
	}
}
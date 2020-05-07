using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SessionForms
{
	public partial class Search : Form
	{
		public Search()
		{
			InitializeComponent();
			DropDown.DataSource = new List<string>
				{
					"All",
					"Course",
					"Group",
					"LastName",
					"Document",
					"Lesson",
					"Mark"
				};
		}

		private void FindButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
using System;
using System.Windows.Forms;

namespace SessionForms
{
	public partial class AddRow : Form
	{
		public bool ShouldAdd;
		public AddRow()
		{
			InitializeComponent();
			ShouldAdd = false;
		}

		public void Clear()
		{
			Course.Text = "";
			Group.Text = "";
			LastName.Text = "";
			Document.Text = "";
			Lesson.Text = "";
			Mark.Text = "";
		}

		protected override void OnShown(EventArgs e)
		{
			ShouldAdd = false;
			base.OnShown(e);
		}

		private void Add_Click(object sender, EventArgs e)
		{
			ShouldAdd = true;
			Close();
		}
	}
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SessionForms
{
	public partial class MainWindow : Form
	{
		private bool IsFileOpened => FilePath.Text == "No file";
		private bool _isClicked;
		private Point _lastPosition;
		private List<string> _dropDown = new List<string>
		{
			"All",
			"Course",
			"Group",
			"LastName",
			"Document",
			"Lesson",
			"Mark"
		};
		
		private IEnumerable<XElement> _data;
		private IEnumerable<XElement> _originalData;
		
		private Search _search;
		private AddRow _addRow;

		public MainWindow()
		{
			InitializeComponent();
			
			_search = new Search();
			_addRow = new AddRow();
			
			MouseMove += OnMouseMove;
			FilePath.MouseMove += OnMouseMove;
			MouseDown += OnMouseDown;
			FilePath.MouseDown += OnMouseDown;
			MouseUp += OnMouseUp;
			FilePath.MouseUp += OnMouseUp;
		}

		//Window move methods
		private void OnMouseUp(object sender, MouseEventArgs e)
		{
			_isClicked = false;
		}

		private void OnMouseDown(object sender, MouseEventArgs e)
		{
			_isClicked = true;
			_lastPosition = Cursor.Position;
		}

		private void OnMouseMove(object sender, MouseEventArgs e)
		{
			if (!_isClicked)
				return;
			
			this.Left += Cursor.Position.X - _lastPosition.X;
			this.Top += Cursor.Position.Y - _lastPosition.Y;
			_lastPosition = Cursor.Position;
		}

		private void UpdateData()
		{
			// Data.Text = _data.ToString();
			Data.Text =  $"{"Course".PadLeft(8)}  |  {"Group".PadLeft(10)}  |   Last name  |    Document  |  Lesson  |  Mark  \n";
			Data.Text += "-".PadLeft(Data.Text.Length, '-') + "\n";
			foreach (var ekzam in _data)
			{
				Data.Text += $"{ekzam.Element("Course").Value.PadLeft(8)}  |" +
				             $"{ekzam.Element("Group").Value.PadLeft(12)}  |" +
				             $"{ekzam.Element("LastName").Value.PadLeft(12)}  |" +
				             $"{ekzam.Element("Document").Value.PadLeft(12)}  |" +
				             $"{ekzam.Element("Lesson").Value.PadLeft(12)}  |" +
				             $"{ekzam.Element("Mark").Value.PadLeft(6)}  \n";
			}
		}

		//Window control buttons
		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Minimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void MaximizeButton_Click(object sender, EventArgs e)
		{
			switch (this.WindowState)
			{
				case FormWindowState.Maximized:
					this.WindowState = FormWindowState.Normal;
					break;
				case FormWindowState.Normal:
					this.WindowState = FormWindowState.Maximized;
					break;
			}
		}
		
		private void OpenButton_Click(object sender, EventArgs e)
		{
			var filePath = ChooseFile();
			if (filePath == string.Empty) 
				return;
			
			FilePath.Text = filePath;
			
			_data = XElement.Load(filePath).Descendants("Ekzam");
			_originalData = _data;
			UpdateData();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			var element = new XElement("Session", _originalData);
			OnDataSaved();
			element.Save(FilePath.Text);
		}

		private void FilterButton_Click(object sender, EventArgs e)
		{
			_search.Text.Text = "Search:";
			_search.ShowDialog();
			var searchText = _search.Input.Text;
			IEnumerable<XElement> filteredData;
			if (_dropDown[_search.DropDown.SelectedIndex] == "All")
				filteredData = 
					_originalData.Where(x => x.Value.Contains(searchText));
			else 
				filteredData = 
					_originalData.Where(x => x.Element(_dropDown[_search.DropDown.SelectedIndex]).Value.Contains(searchText));
			
			_data = filteredData;
			UpdateData();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			if (IsFileOpened)
			{
				MessageBox.Show("Open file, first!");
				return;
			}

			OnDataChanged();
			_addRow.Clear();
			_addRow.ShowDialog();
			if (_addRow.ShouldAdd)
			{
				_originalData = _originalData.Concat(
					new [] {
						new XElement("Ekzam", 
							new XElement("Course", _addRow.Course.Text),
							new XElement("Group", _addRow.Group.Text),
							new XElement("LastName", _addRow.LastName.Text),
							new XElement("Document", _addRow.Document.Text),
							new XElement("Lesson", _addRow.Lesson.Text),
							new XElement("Mark", _addRow.Mark.Text)
					)
				});
			}

			_data = _originalData;
			UpdateData();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			_search.Text.Text = "Delete:";
			_search.ShowDialog();
			var searchText = _search.Input.Text;
			IEnumerable<XElement> filteredData;
			if (_dropDown[_search.DropDown.SelectedIndex] == "All")
				filteredData = 
					_originalData.Where(x => !x.Value.Contains(searchText));
			else 
				filteredData = 
					_originalData.Where(x => !x.Element(_dropDown[_search.DropDown.SelectedIndex]).Value.Contains(searchText));

			_originalData = filteredData;
			_data = _originalData;
			UpdateData();
		}

		private string ChooseFile()
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "XML files (*.xml)|*.xml|All files|*.*", 
				FilterIndex = 1,
				RestoreDirectory = true
			};

			return openFileDialog.ShowDialog() == DialogResult.OK ? openFileDialog.FileName : string.Empty;
		}

		private void OnDataChanged()
		{
			FilePath.Font = new Font(FilePath.Font, FontStyle.Italic);
			if (!FilePath.Text.EndsWith("*"))
				FilePath.Text += "*";
		}

		private void OnDataSaved()
		{
			FilePath.Font = new Font(FilePath.Font, FontStyle.Regular);
			if (FilePath.Text.EndsWith("*"))
				FilePath.Text = FilePath.Text.Substring(0, FilePath.Text.Length - 1);
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			_data = _originalData;
			UpdateData();
		}

		private void AverageButton_Click(object sender, EventArgs e)
		{
			_search.Text.Text = "Calculate average:";
			_search.ShowDialog();
			var searchText = _search.Input.Text;
			IEnumerable<XElement> filteredData;
			if (_dropDown[_search.DropDown.SelectedIndex] == "All")
				filteredData = 
					_originalData.Where(x => x.Value.Contains(searchText));
			else 
				filteredData = 
					_originalData.Where(x => x.Element(_dropDown[_search.DropDown.SelectedIndex]).Value.Contains(searchText));
			var average = 0d;
			if (filteredData.Count() != 0)
				average = filteredData.Select(x => int.Parse(x.Element("Mark").Value)).Average();
			MessageBox.Show($"Average on {searchText}|{_dropDown[_search.DropDown.SelectedIndex]} is {average}");
		}
	}
}
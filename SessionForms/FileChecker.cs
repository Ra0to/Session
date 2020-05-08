using System.Text.RegularExpressions;

namespace SessionForms
{
	public static class FileChecker
	{
		public static bool CheckMark(string text)
		{
			return Regex.IsMatch(text, "^[2-5]$");
		}
		
		public static bool CheckCourse(string text)
		{
			return Regex.IsMatch(text, "^[0-9]+$");
		}
		
		public static bool CheckGroup(string text)
		{
			return Regex.IsMatch(text, "^[0-9]+/[0-9]+$");
		}
		
		public static bool CheckLastName(string text)
		{
			return Regex.IsMatch(text, "^[a-zA-Z]+$");
		}
		
		public static bool CheckDocument(string text)
		{
			return Regex.IsMatch(text, "^[0-9]+$");
		}
		
		public static bool CheckLesson(string text)
		{
			return Regex.IsMatch(text, "^[a-zA-Z ]+$");
		}
	}
}
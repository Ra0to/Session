using Microsoft.VisualStudio.TestTools.UnitTesting;
using SessionForms;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var res = FileChecker.CheckCourse("31");
			Assert.AreEqual(res, true);
		}
	}
}
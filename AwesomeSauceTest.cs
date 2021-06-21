using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssentialTraining;
using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTrainingTest
{
	[TestClass]
	public class AwesomeSauceTest
	{
		[TestMethod]
		public void IsSauceAwesomeTest()
		{
			var testInstance = new AwesomeSauce();
			testInstance.Sauces.Add("Tobasco");
			testInstance.Sauces.Add("Cholula");
			testInstance.Sauces.Add("Trailer Trash"); //actual bbq sauce

			//all tests should pass
			//expect true
			Assert.IsTrue(testInstance.IsSauceAwesome("Trailer Trash"));

			//all tests should pass
			//expect false
			Assert.IsFalse(testInstance.IsSauceAwesome("Ketchup"));
		}
	}
}

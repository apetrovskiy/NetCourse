namespace GenericMethods.ObjectModel
{
	using System;

	public class Cat
	{
		public void Feed(Food dosage)
		{
			Console.WriteLine("I'm fed with {0} gramms of food", dosage.Weight);
		}
	}
}
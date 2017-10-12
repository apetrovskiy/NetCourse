namespace GenericMethods.ObjectModel.Exceptions
{
	using System;

	public class AnimalIsSickException : Exception
	{
		public AnimalIsSickException(string exceptionMessage) : base(exceptionMessage)
		{
			Console.WriteLine(exceptionMessage);
		}
	}
}
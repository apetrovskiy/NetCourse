﻿namespace GenericMethods.ObjectModel.Animals
{
	using System;
	using Materials;

	public class Skunk
	{
		public Fecals Fecals { get; set; }

		public void Feed(Food dosage)
		{
			Console.WriteLine("I'm fed with {0} gramms of food", dosage.Weight);
		}
	}
}
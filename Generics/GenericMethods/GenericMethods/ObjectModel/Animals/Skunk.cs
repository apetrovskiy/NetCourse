namespace GenericMethods.ObjectModel.Animals
{
	using System;
	using Abstract;
	using Exceptions;
	using Materials;

	public class Skunk
	{
		public Fecals Fecals { get; set; }

		public void Feed(Food dosage)
		{
			Console.WriteLine("I'm fed with {0} gramms of food", dosage.Weight);
		}

		public FecalColors AnalyseHealthByColor(Fecals fecals, Bucket bucket, Umbrella umbrella)
		{
			if (FecalColors.Red == fecals.Color || FecalColors.Green == fecals.Color)
				throw new AnimalIsSickException("Your animal is in danger!");
			return fecals.Color;
		}

		public FecalConsistency AnalyseHealthByConsistency(Fecals fecals, Bucket bucket, Umbrella umbrella)
		{
			if (FecalConsistency.Liquid == fecals.Consistency)
				throw new AnimalIsSickException("Your animal is in danger!");
			return fecals.Consistency;
		}
	}
}
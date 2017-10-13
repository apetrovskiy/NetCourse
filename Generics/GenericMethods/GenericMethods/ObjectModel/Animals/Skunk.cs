namespace GenericMethods.ObjectModel.Animals
{
	using System;
	using Abstract;
	using Exceptions;
	using Helpers;
	using Materials;

	public class Skunk : IDrinking
	{
		public Fecals Fecals { get; set; }

		public void Feed(Food dosage)
		{
			Console.WriteLine(DescriptionConstants.SkunkFedWith, dosage.Weight);
		}

		public FecalColors AnalyseHealthByColor(Fecals fecals, Bucket bucket, Umbrella umbrella)
		{
			if (FecalColors.Red == fecals.Color || FecalColors.Green == fecals.Color)
				ExceptionThrower.GenerateAnimalIsSickException(ExceptionConstants.SkunkInDangerWarning);
			return fecals.Color;
		}

		public FecalConsistency AnalyseHealthByConsistency(Fecals fecals, Bucket bucket, Umbrella umbrella)
		{
			// any type of fecals is good for the skunk
			return fecals.Consistency;
		}

		public void DrinkWater(Water water)
		{
			Console.WriteLine(DescriptionConstants.SkunkDrank, water.Volume);
		}
	}
}
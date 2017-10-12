namespace GenericMethods.ObjectModel.Animals
{
	using System;
	using Abstract;
	using Exceptions;
	using Helpers;
	using Materials;

	public class Skunk
	{
		public Fecals Fecals { get; set; }

		public void Feed(Food dosage)
		{
			Console.WriteLine(DescriptionConstants.ImFedWith, dosage.Weight);
		}

		public FecalColors AnalyseHealthByColor(Fecals fecals, Bucket bucket, Umbrella umbrella)
		{
			if (FecalColors.Red == fecals.Color || FecalColors.Green == fecals.Color)
				ExceptionThrower.GenerateAnimalIsSickException();
			return fecals.Color;
		}

		public FecalConsistency AnalyseHealthByConsistency(Fecals fecals, Bucket bucket, Umbrella umbrella)
		{
			if (FecalConsistency.Liquid == fecals.Consistency)
				ExceptionThrower.GenerateAnimalIsSickException();
			return fecals.Consistency;
		}
	}
}
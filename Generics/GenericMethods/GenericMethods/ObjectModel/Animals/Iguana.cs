namespace GenericMethods.ObjectModel.Animals
{
	using System;
	using Abstract;
	using Helpers;
	using Materials;

	public class Iguana : IDrinking
	{
		public Fecals Fecals { get; set; }

		public void Feed(Food dosage)
		{
			Console.WriteLine(DescriptionConstants.IguanaFedWith, dosage.Weight);
		}

		public FecalColors AnalyseHealthByColor(Fecals fecals)
		{
			if (FecalColors.Red == fecals.Color || FecalColors.Green == fecals.Color)
				ExceptionThrower.GenerateAnimalIsSickException(ExceptionConstants.IguanaInDangerWarning);
			return fecals.Color;
		}

		public FecalConsistency AnalyseHealthByConsistency(Fecals fecals)
		{
			if (FecalConsistency.Liquid == fecals.Consistency)
				ExceptionThrower.GenerateAnimalIsSickException(ExceptionConstants.IguanaInDangerWarning);
			return fecals.Consistency;
		}

		public void DrinkWater(Water water)
		{
			Console.WriteLine(DescriptionConstants.IguanaDrank, water.Volume);
		}
	}
}
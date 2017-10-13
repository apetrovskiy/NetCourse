namespace GenericMethods.ObjectModel.Animals
{
	using System;
	using Abstract;
	using Exceptions;
	using Helpers;
	using Materials;

	public class Cat
	{
		public Fecals Fecals { get; set; }

		public void Feed(Food dosage)
		{
			Console.WriteLine(DescriptionConstants.CatFedWith, dosage.Weight);
		}

		public FecalColors AnalyseHealthByColor(Fecals fecals)
		{
			if (FecalColors.Red == fecals.Color || FecalColors.Green == fecals.Color)
				ExceptionThrower.GenerateAnimalIsSickException(ExceptionConstants.CatInDangerWarning);
			return fecals.Color;
		}

		public FecalConsistency AnalyseHealthByConsistency(Fecals fecals)
		{
			if (FecalConsistency.Liquid == fecals.Consistency)
				ExceptionThrower.GenerateAnimalIsSickException(ExceptionConstants.CatInDangerWarning);
			return fecals.Consistency;
		}
	}
}
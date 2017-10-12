namespace GenericMethods
{
	using System;
	using ObjectModel;
	using ObjectModel.Abstract;
	using ObjectModel.Animals;
	using ObjectModel.Materials;

	class Program
	{
		static void Main(string[] args)
		{
			var servant = new Servant();
			servant.FeedCat(new Cat());
			servant.FeedDog(new Dog());
			servant.FeedRacoon(new Racoon());
			servant.FeedSkunk(new Skunk());

			var dog = new Dog{ Fecals = new Fecals{ Color = FecalColors.Brown, Consistency = FecalConsistency.Hard }};
			servant.AnalyseHealthOfAnimalByFecalColor(dog);
			servant.AnalyseHealthOfAnimalByFecalConsistency(dog);

			var cat = new Cat { Fecals = new Fecals { Color = FecalColors.Green, Consistency = FecalConsistency.Liquid } };
			servant.AnalyseHealthOfAnimalByFecalColor(cat);
			servant.AnalyseHealthOfAnimalByFecalConsistency(cat);

			var racoon = new Racoon {Fecals = new Fecals {Color = FecalColors.Red, Consistency = FecalConsistency.Hard}};
			servant.AnalyseHealthOfAnimalByFecalColor(racoon);
			servant.AnalyseHealthOfAnimalByFecalConsistency(racoon);

			var skunk = new Skunk{ Fecals = new Fecals{ Color = FecalColors.Yellow, Consistency = FecalConsistency.Liquid }};
			servant.AnalyseHealthOfAnimalByFecalColor(skunk, new Bucket(), new Umbrella());
			servant.AnalyseHealthOfAnimalByFecalConsistency(skunk, new Bucket(), new Umbrella());

			Console.ReadKey();
		}
	}
}

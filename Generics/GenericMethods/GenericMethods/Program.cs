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
            servant.FeedUndulate(new Undulate());
			servant.FeedIguana(new Iguana());

			servant.GiveWaterToAnimal(new Cat(), new Water{ Volume = 0.2 });
			servant.GiveWaterToAnimal(new Dog(), new Water { Volume = 0.5 });
			servant.GiveWaterToAnimal(new Racoon(), new Water { Volume = 0.4 });
			servant.GiveWaterToAnimal(new Skunk(), new Water { Volume = 0.8 });
			servant.GiveWaterToAnimal(new Undulate(), new Water { Volume = 0.01 });
			servant.GiveWaterToAnimal(new Iguana(), new Water { Volume = 0.1 });

			var dog = new Dog{ Fecals = new Fecals{ Color = FecalColors.Brown, Consistency = FecalConsistency.Hard }};
            try
            {
                servant.AnalyseHealthOfAnimalByFecalColor(dog);
                servant.AnalyseHealthOfAnimalByFecalConsistency(dog);
            }
            catch { }

			var cat = new Cat { Fecals = new Fecals { Color = FecalColors.Green, Consistency = FecalConsistency.Liquid } };
            try
            {
                servant.AnalyseHealthOfAnimalByFecalColor(cat);
                servant.AnalyseHealthOfAnimalByFecalConsistency(cat);
            }
            catch { }

			var racoon = new Racoon {Fecals = new Fecals {Color = FecalColors.Red, Consistency = FecalConsistency.Hard}};
            try
            {
                servant.AnalyseHealthOfAnimalByFecalColor(racoon);
                servant.AnalyseHealthOfAnimalByFecalConsistency(racoon);
            }
            catch { }

			var skunk = new Skunk{ Fecals = new Fecals{ Color = FecalColors.Yellow, Consistency = FecalConsistency.Liquid }};
            try
            {
                servant.AnalyseHealthOfAnimalByFecalColor(skunk, new Bucket(), new Umbrella());
                servant.AnalyseHealthOfAnimalByFecalConsistency(skunk, new Bucket(), new Umbrella());
            }
            catch { }

            var birdie = new Undulate { Fecals = new Fecals { Color = FecalColors.Yellow, Consistency = FecalConsistency.Liquid } };
            try
            {
                servant.AnalyseHealthOfAnimalByFecalColor(birdie);
                servant.AnalyseHealthOfAnimalByFecalConsistency(birdie);
            }
            catch { }

			Console.ReadKey();
		}
	}
}

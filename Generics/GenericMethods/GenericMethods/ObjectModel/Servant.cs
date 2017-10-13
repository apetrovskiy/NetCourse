namespace GenericMethods.ObjectModel
{
	using Abstract;
	using Animals;
	using Materials;

	public class Servant
	{
		public void FeedDog(Dog dog)
		{
			dog.Feed(new Food{ Weight = 500, Name = "a bone" });
		}

		public void FeedCat(Cat cat)
		{
			cat.Feed(new Food { Weight = 200, Name = "milk" });
		}

		public void FeedSkunk(Skunk skunk)
		{
			skunk.Feed(new Food { Weight = 300, Name = "grass" });
		}

		public void FeedRacoon(Racoon racoon)
		{
			racoon.Feed(new Food { Weight = 50, Name = "sweets" });
		}

        public void FeedUndulate(Undulate undulate)
        {
            undulate.Feed(new Food { PiecesCount = 1, Name = "the stick" });
        }

		public void FeedIguana(Iguana iguana)
		{
			iguana.Feed(new Food{ PiecesCount = 3 });
		}

		public void GiveWaterToAnimal(IDrinking drinkingAnimal, Water water)
		{
			drinkingAnimal.DrinkWater(water);
		}

        public FecalColors AnalyseHealthOfAnimalByFecalColor(Dog dog)
		{
			return dog.AnalyseHealthByColor(dog.Fecals);
		}

		public FecalConsistency AnalyseHealthOfAnimalByFecalConsistency(Dog dog)
		{
			return dog.AnalyseHealthByConsistency(dog.Fecals);
		}

		public FecalColors AnalyseHealthOfAnimalByFecalColor(Cat cat)
		{
			return cat.AnalyseHealthByColor(cat.Fecals);
		}

		public FecalConsistency AnalyseHealthOfAnimalByFecalConsistency(Cat cat)
		{
			return cat.AnalyseHealthByConsistency(cat.Fecals);
		}

		public FecalColors AnalyseHealthOfAnimalByFecalColor(Racoon racoon)
		{
			return racoon.AnalyseHealthByColor(racoon.Fecals);
		}

		public FecalConsistency AnalyseHealthOfAnimalByFecalConsistency(Racoon racoon)
		{
			return racoon.AnalyseHealthByConsistency(racoon.Fecals);
		}

		public FecalColors AnalyseHealthOfAnimalByFecalColor(Skunk skunk, Bucket bucket, Umbrella umbrella)
		{
			return skunk.AnalyseHealthByColor(skunk.Fecals, bucket, umbrella);
		}

		public FecalConsistency AnalyseHealthOfAnimalByFecalConsistency(Skunk skunk, Bucket bucket, Umbrella umbrella)
		{
			return skunk.AnalyseHealthByConsistency(skunk.Fecals, bucket, umbrella);
		}

        public FecalColors AnalyseHealthOfAnimalByFecalColor(Undulate undulate)
        {
            return undulate.AnalyseHealthByColor(undulate.Fecals);
        }

        public FecalConsistency AnalyseHealthOfAnimalByFecalConsistency(Undulate undulate)
        {
            return undulate.AnalyseHealthByConsistency(undulate.Fecals);
        }
	}
}
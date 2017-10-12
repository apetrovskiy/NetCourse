namespace GenericMethods.ObjectModel
{
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
	}
}
namespace GenericMethods.ObjectModel
{
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
	}
}
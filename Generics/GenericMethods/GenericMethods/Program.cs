namespace GenericMethods
{
	using System;
	using ObjectModel;
	using ObjectModel.Animals;

	class Program
	{
		static void Main(string[] args)
		{
			var servant = new Servant();
			servant.FeedCat(new Cat());
			servant.FeedDog(new Dog());
			servant.FeedRacoon(new Racoon());
			servant.FeedSkunk(new Skunk());

			Console.ReadKey();
		}
	}
}

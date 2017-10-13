namespace GenericMethods.ObjectModel.Helpers
{
	using Abstract;
	using Exceptions;

	public class ExceptionThrower
	{
		public static void GenerateAnimalIsSickException(string warningMessage)
		{
			throw new AnimalIsSickException(warningMessage);
		}
	}
}
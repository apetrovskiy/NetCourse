namespace GenericMethods.ObjectModel.Helpers
{
	using Abstract;
	using Exceptions;

	public class ExceptionThrower
	{
		public static void GenerateAnimalIsSickException()
		{
			throw new AnimalIsSickException(ExceptionConstants.InDangerWarning);
		}
	}
}
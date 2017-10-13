using GenericMethods.ObjectModel.Abstract;
using GenericMethods.ObjectModel.Helpers;
using GenericMethods.ObjectModel.Materials;
using System;

namespace GenericMethods.ObjectModel.Animals
{
    public class Undulate
    {
        public Fecals Fecals { get; set; }

        public void Feed(Food dosage)
        {
            Console.WriteLine(DescriptionConstants.UndulateFedWith, dosage.PiecesCount);
        }

        public FecalColors AnalyseHealthByColor(Fecals fecals)
        {
            // there's no analysis by color
            return fecals.Color;
        }

        public FecalConsistency AnalyseHealthByConsistency(Fecals fecals)
        {
            if (FecalConsistency.Liquid == fecals.Consistency)
                ExceptionThrower.GenerateAnimalIsSickException(ExceptionConstants.UndulateInDangerWarning);
            return fecals.Consistency;
        }
    }
}

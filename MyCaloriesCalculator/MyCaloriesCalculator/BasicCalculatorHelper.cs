using System;

namespace MyCaloriesCalculator
{
    public class BasicCalculatorHelper : ICaloriesCalculable
    {
        private const double OPTIMAL_COEFFICIENT_OF_PROTEIN_PER_KG = 1.8;
        private const double MY_COEFFICIENT_FOR_IT_NORMAL_TRAINING = 1.3;

        private readonly double _weightInKG;
        private readonly int _heightInCm;
        private readonly int _age;

        public ushort ProteinInGrams { get; private set; }
        public ushort FatsInGrams { get; private set; }
        public ushort CarbsInGrams { get; private set; }
        public ushort ProteinInCalories { get; private set; }
        public ushort FatsInInCalories { get; private set; }
        public ushort CarbsInInCalories { get; private set; }
        public double BRM { get; private set; }
        public ushort TotalCalories { get; private set; }

        public BasicCalculatorHelper(double weightInKG, int heightInCentimeters, int age, bool isMale, short programCaloriesAdding)
        {
            _weightInKG = weightInKG;
            _heightInCm = heightInCentimeters;
            _age = age;
            BRM = isMale == true ? 66 + (13.7 * _weightInKG) + (5 * _heightInCm) - (6.8 * _age) :
                                    655 + (9.6 * _weightInKG) + (1.8 * _heightInCm) - (4.7 * _age);

            BRM = Math.Ceiling(BRM);


            TotalCalories = (ushort)(Math.Ceiling(BRM * MY_COEFFICIENT_FOR_IT_NORMAL_TRAINING + programCaloriesAdding));
        }

        public void CalculateMacroNutrients()
        {
            //optimal  protein 1.8 per kg (0.82 per Lbs)
            ProteinInGrams = (ushort)Math.Ceiling(OPTIMAL_COEFFICIENT_OF_PROTEIN_PER_KG * _weightInKG);
            ProteinInCalories = (ushort)(ProteinInGrams * 4);

            //25 % calories from Fats
            FatsInInCalories = (ushort)Math.Ceiling(0.275 * TotalCalories);
            FatsInGrams = (ushort)Math.Ceiling(FatsInInCalories / 9.0);

            //rest for Carbs
            CarbsInInCalories = (ushort)(TotalCalories - ProteinInCalories - FatsInInCalories);
            CarbsInGrams = (ushort)Math.Ceiling(CarbsInInCalories / 4.0);
        }

    }
}

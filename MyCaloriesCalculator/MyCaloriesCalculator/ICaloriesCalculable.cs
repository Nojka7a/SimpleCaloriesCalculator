
namespace MyCaloriesCalculator
{
    public interface ICaloriesCalculable
    {
        ushort ProteinInGrams { get; }
        ushort FatsInGrams { get; }
        ushort CarbsInGrams { get; }

        ushort ProteinInCalories { get; }
        ushort FatsInInCalories { get; }
        ushort CarbsInInCalories { get; }


        ushort TotalCalories { get; }

        double BRM { get; }

        void CalculateMacroNutrients();

    }
}

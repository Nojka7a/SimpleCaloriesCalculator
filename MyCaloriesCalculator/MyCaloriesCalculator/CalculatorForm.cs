using System;
using System.Windows.Forms;

namespace MyCaloriesCalculator
{
    public partial class calculatorForm : Form
    {
        public calculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isMale = rbMale.Checked;
           
            ICaloriesCalculable calculator = new BasicCalculatorHelper(
                Convert.ToDouble(txtWeight.Text), 
                Int16.Parse(txtHeight.Text), 
                Int16.Parse(txtAge.Text),
                isMale,
                ComputeProgramCaloriesToAdd()
                );

            calculator.CalculateMacroNutrients();

            PopulateFiled(calculator);
        }

        private short ComputeProgramCaloriesToAdd()
        {
            if (rbCleanBulk.Checked)
                return (short)ProgramCaloriesEnum.LEAN_BULK_ADDITIONAL_CALORIES;
            else if (rbCutting.Checked)
                return (short)ProgramCaloriesEnum.CUTTING_REMOVAL_CALORIES;
            else
                return 0;
        }

        private void ValidateInputs()
        {
            throw new NotImplementedException();            
        }

        private void PopulateFiled(ICaloriesCalculable calc)
        {
            lblProteinResult.Text = ((int)calc.ProteinInGrams).ToString();
            lblProteinResultInCalories.Text = string.Format(" ({0} cals)", calc.ProteinInCalories);

            lblCarbsResult.Text = calc.CarbsInGrams.ToString();
            lblCarbsResultInCalories.Text = string.Format(" ({0} cals)", calc.CarbsInInCalories);

            lblFatsResult.Text = calc.FatsInGrams.ToString();
            lblFatsResultInCalories.Text = string.Format(" ({0} cals)", calc.FatsInInCalories);

            lblTotalCaloriesResult.Text = calc.TotalCalories.ToString();

            lblBRMResult.Text = String.Format("BRM: {0} cals", calc.BRM);
        }

        private void gbProgram_Enter(object sender, EventArgs e)
        {

        }
    }
}

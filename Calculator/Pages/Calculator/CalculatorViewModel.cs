using Calculator.Feature.Addition;
using Calculator.Feature.Division;
using Calculator.Feature.Multiplication;
using Calculator.Feature.Subtraction;
using Calculator.Shared.ViewModels;

namespace Calculator.Pages.Calculator
{
    public class CalculatorViewModel : ViewModelBase
    {
        public AdditionFormViewModel AdditionFormViewModel { get; }
        public SubtractionFormViewModel SubtractionFormViewModel { get; }
        public DivisionFormViewModel DivisionFormViewModel { get; }
        public MultiplicationFormViewModel MultiplicationFormViewModel { get; }

        public CalculatorViewModel(
            AdditionFormViewModel additionFormViewModel, SubtractionFormViewModel subtractionFormViewModel,
            DivisionFormViewModel divisionFormViewModel, MultiplicationFormViewModel multiplicationFormViewModel)
        {
            AdditionFormViewModel = additionFormViewModel;
            SubtractionFormViewModel = subtractionFormViewModel;
            DivisionFormViewModel = divisionFormViewModel;
            MultiplicationFormViewModel = multiplicationFormViewModel;

        }
    }
}

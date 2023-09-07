using Calculator.Shared.ViewModels;
using System.Windows.Input;

namespace Calculator.Feature.Subtraction
{
    public class SubtractionFormViewModel : ViewModelBase
    {
        private int _num1;
        public int Num1
        {
            get
            {
                return _num1;
            }
            set
            {
                _num1 = value;
                OnPropertyChanged(nameof(Num1));
            }
        }

        private int _num2;
        public int Num2
        {
            get
            {
                return _num2;
            }
            set
            {
                _num2 = value;
                OnPropertyChanged(nameof(Num2));
            }
        }

        public ICommand SubtractionCommand { get; }

        public SubtractionFormViewModel()
        {
            SubtractionCommand = new SubtractionCommand(this);
        }
    }
}

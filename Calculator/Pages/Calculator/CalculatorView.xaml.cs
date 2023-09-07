namespace Calculator.Pages.Calculator;

public partial class CalculatorView : ContentPage
{
    public CalculatorView(object bindigContext)
    {
        InitializeComponent();

        BindingContext = bindigContext;
    }
}
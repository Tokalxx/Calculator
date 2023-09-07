using Calculator.Shared.Commands;

namespace Calculator.Feature.Subtraction
{
    public class SubtractionCommand : AsyncCommandBase
    {
        private readonly SubtractionFormViewModel _viewModel;

        public SubtractionCommand(SubtractionFormViewModel viewModel)
        {
            _viewModel = viewModel;
        }


        protected override async Task ExecuteAsync(object parameter)
        {
            await Application.Current.MainPage.DisplayAlert("Success", $"Answer: {_viewModel.Num1 - _viewModel.Num2}", "Ok");
        }
    }
}

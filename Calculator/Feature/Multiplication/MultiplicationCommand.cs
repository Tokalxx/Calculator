using Calculator.Shared.Commands;

namespace Calculator.Feature.Multiplication
{
    public class MultiplicationCommand : AsyncCommandBase
    {
        private readonly MultiplicationFormViewModel _viewModel;

        public MultiplicationCommand(MultiplicationFormViewModel viewModel)
        {
            _viewModel = viewModel;
        }


        protected override async Task ExecuteAsync(object parameter)
        {
            await Application.Current.MainPage.DisplayAlert("Success", $"Answer: {_viewModel.Num1 * _viewModel.Num2}", "Ok");
        }
    }
}

using Calculator.Shared.Commands;

namespace Calculator.Feature.Addition
{
    public class AdditionCommand : AsyncCommandBase
    {
        private readonly AdditionFormViewModel _viewModel;

        public AdditionCommand(AdditionFormViewModel viewModel)
        {
            _viewModel = viewModel;
        }


        protected override async Task ExecuteAsync(object parameter)
        {
            await Application.Current.MainPage.DisplayAlert("Success", $"Answer: {_viewModel.Num1 + _viewModel.Num2}", "Ok");
        }
    }
}

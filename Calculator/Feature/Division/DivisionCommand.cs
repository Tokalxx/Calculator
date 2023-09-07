using Calculator.Shared.Commands;

namespace Calculator.Feature.Division
{
    public class DivisionCommand : AsyncCommandBase
    {
        private readonly DivisionFormViewModel _viewModel;

        public DivisionCommand(DivisionFormViewModel divisionFormViewModel)
        {
            _viewModel = divisionFormViewModel;
        }


        protected override async Task ExecuteAsync(object parameter)
        {
            await Application.Current.MainPage.DisplayAlert("Success", $"Answer: {_viewModel.Num1 / _viewModel.Num2}", "Ok");
        }
    }
}

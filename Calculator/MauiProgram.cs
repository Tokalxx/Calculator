using Calculator.Feature.Addition;
using Calculator.Feature.Division;
using Calculator.Feature.Multiplication;
using Calculator.Feature.Subtraction;
using Calculator.Pages.Calculator;
using Microsoft.Extensions.Logging;

namespace Calculator
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<AdditionFormViewModel>();
            builder.Services.AddTransient<MultiplicationFormViewModel>();
            builder.Services.AddTransient<SubtractionFormViewModel>();
            builder.Services.AddTransient<DivisionFormViewModel>();
            builder.Services.AddTransient<CalculatorViewModel>();
            builder.Services.AddTransient<CalculatorView>(
                s => new CalculatorView(s.GetRequiredService<CalculatorViewModel>()));


            return builder.Build();
        }
    }
}
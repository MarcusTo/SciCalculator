using Microsoft.Maui.Controls;
using SciCalculator.ViewModels;

namespace SciCalculator.Views;

public partial class CalculatorPage : ContentPage
{
    public CalculatorPage()
    {
        InitializeComponent();

        //Init the view model
        this.BindingContext = new CalculatorPageViewModel();
    }
}
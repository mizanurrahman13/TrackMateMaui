using TrackMateMaui.ViewModels;

namespace TrackMateMaui.Views;

public partial class CreateTaskPage : ContentPage
{
    //public CreateTaskPage()
    //{
    //    InitializeComponent();
    //}
    public CreateTaskPage(CreateTaskViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

using TrackMateMaui.ViewModels;

namespace TrackMateMaui.Views;

public partial class ListOfTaskPage : ContentPage
{
    //public ListOfTaskPage()
    //{
    //    InitializeComponent();
    //}
    public ListOfTaskPage(ListOfTaskViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

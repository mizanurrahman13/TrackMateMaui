namespace TrackMateMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCreateTaskClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("/CreateTaskPage");

        }
    }
}

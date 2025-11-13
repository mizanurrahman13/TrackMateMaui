using TrackMateMaui.Views;

namespace TrackMateMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CreateTaskPage), typeof(CreateTaskPage));
            Routing.RegisterRoute(nameof(ListOfTaskPage), typeof(ListOfTaskPage));
        }
    }
}

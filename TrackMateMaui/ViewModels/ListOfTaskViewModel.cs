using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using TrackMateMaui.Models;
using TrackMateMaui.Services;

namespace TrackMateMaui.ViewModels;

public partial class ListOfTaskViewModel : ObservableObject
{
    public ObservableCollection<TaskModel> Tasks { get; }
    //public ListOfTaskViewModel()
    //{

    //}
    //public ListOfTaskViewModel(TaskStore store)
    //{
    //    Tasks = store.Tasks;
    //}
    public ListOfTaskViewModel(TaskStore store)
    {
        Tasks = store.Tasks;

        // TEMP: Add a test task to verify UI
        Tasks.Add(new TaskModel
        {
            Name = "Test Task",
            Description = "This is a test",
            Category = "Debug",
            Priority = "High",
            Status = "Open",
            StartedAt = DateTime.Now.ToString("yyyy-MM-dd"),
            EndAt = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd")
        });
    }

}

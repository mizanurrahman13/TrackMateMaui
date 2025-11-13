using System.Collections.ObjectModel;
using TrackMateMaui.Models;

namespace TrackMateMaui.Services;

public class TaskStore
{
    public ObservableCollection<TaskModel> Tasks { get; } = new();

    public void AddTask(TaskModel task)
    {
        Tasks.Add(task);
    }
}

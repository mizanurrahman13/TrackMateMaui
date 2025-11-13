using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using TrackMateMaui.Models;
using TrackMateMaui.Services;

namespace TrackMateMaui.ViewModels;

public partial class CreateTaskViewModel : ObservableObject
{
    private readonly TaskStore taskStore;

    //public CreateTaskViewModel()
    //{
        
    //}

    public CreateTaskViewModel(TaskStore store)
    {
        taskStore = store;
    }

    [ObservableProperty] private string name;
    [ObservableProperty] private string description;
    [ObservableProperty] private string category;
    [ObservableProperty] private string priority;
    [ObservableProperty] private string status;
    [ObservableProperty] private DateTime? startedAt;
    [ObservableProperty] private DateTime? endAt;

    [RelayCommand]
    private async Task SaveTaskAsync()
    {
        var task = new TaskModel
        {
            Name = name,
            Description = description,
            Category = category,
            Priority = priority,
            Status = status,
            StartedAt = startedAt?.ToString("yyyy-MM-dd"),
            EndAt = endAt?.ToString("yyyy-MM-dd")
        };

        taskStore.AddTask(task);
        await Shell.Current.GoToAsync("/ListOfTaskPage");
    }
}

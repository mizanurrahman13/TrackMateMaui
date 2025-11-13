namespace TrackMateMaui.Models;

public class TaskModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty; // "Work", "Study", "Fitness"
    public string Priority { get; set; } = string.Empty; // "High", "Medium", "Low"
    public string Status { get; set; } = string.Empty;   // "Yet to start", "In Progress", "Completed"

    public string? StartedAt { get; set; }
    public string? EndAt { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Description}";
    }
}



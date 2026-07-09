using ScheduleTracker.Domain.Enums;

namespace ScheduleTracker.Domain.Entities;
public class Schedule
{
    public int Id {get; set;}
    public required string Name {get; set;}
    public required DateTime StartTime {get; set;}
    public DateTime? EndTime {get; set;}
    public List<Session> Sessions {get; set;} = [];
}

public class Session
{
    public int Id {get; set;}
    public int ScheduleId {get; set;}
    public Schedule? Schedule {get; set;}
    public required DateTime Date {get; set;} 
    public required string TimeOfDay {get; set;}
    public List<SessionExercise> SessionExercises {get; set;} = [];
    public bool Completed {get; set;} 
    public int? PerformanceScore {get; set;} 
    public FatigueLevel? FatigueScore {get; set;} 
    public string? JournalNote {get; set;}
}

public class SessionExercise
{
    public int Id {get; set;}
    public  int SessionId {get; set;}
    public Session? Session {get; set;}
    public Exercise? Exercise {get; set;}
    public int ExerciseId {get; set;}
    public int? DurationMinutes {get; set;}
    public int? NumberOfSets {get; set;}
    public int? NumberOfReps {get; set;}
}

public class Exercise
{
    public int Id {get; set;}
    public List<SessionExercise> SessionExercises {get; set;} = [];
    public required string Name {get; set;}
    public required string Description {get; set;}
    public DifficultyLevel Difficulty {get; set;}
}
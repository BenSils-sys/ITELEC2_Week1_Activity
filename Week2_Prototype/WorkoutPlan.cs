public class WorkoutPlan
{
    public string goal {get;}
    public string experienceLevel {get;}
    public int workoutDay {get; private set;}

    public WorkoutPlan(string goal, string experienceLevel, int workoutDay)
    {
        if (workoutDay < 1 || workoutDay > 7)
        {
            throw new ArgumentOutOfRangeException("Workout Days must be between 1 and 7.");
        }
        
        this.goal = goal;
        this.experienceLevel = experienceLevel;
        this.workoutDay = workoutDay;
    }

    public void displayPlan()
    {
        Console.WriteLine("Fitness Goal: " + goal);
        Console.WriteLine("Experience Level: " + experienceLevel);
        Console.WriteLine("Workout Days: " + workoutDay);
    }

    public bool updateWorkoutDay(int newDay)
    {
        if (newDay < 1 || newDay > 7)
        {
            return false;
        }

        workoutDay = newDay;
        return true;
    }
}
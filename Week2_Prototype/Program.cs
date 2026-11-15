
var first = new WorkoutPlan("Build Muscle", "Beginner", 3);
var second = new WorkoutPlan("Lose Weight", "Intermediate", 5);

Console.WriteLine("===== FIRST WORKOUT PLAN =====");
first.displayPlan();

Console.WriteLine("\n===== SECOND WORKOUT PLAN =====");
second.displayPlan();

// Test 1: Valid update
Console.WriteLine("\n===== UPDATE FIRST PLAN =====");
Console.WriteLine("Update to 4 days: " + first.updateWorkoutDay(4));

// Test 2: Invalid update
Console.WriteLine("\n===== INVALID UPDATE =====");
Console.WriteLine("Update to 8 days: " + first.updateWorkoutDay(8));

// Display updated first plan
Console.WriteLine("\n===== UPDATED FIRST PLAN =====");
first.displayPlan();

// Display second plan
Console.WriteLine("\n===== SECOND PLAN =====");
second.displayPlan();


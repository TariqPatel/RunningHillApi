using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Sentence = "Past Activity 1"
                },
                new Activity
                {
                    Sentence = "Past Activity 2"
                },
                new Activity
                {
                    Sentence = "Future Activity 1"
                },
                new Activity
                {
                    Sentence = "Future Activity 2"
                },
                new Activity
                {
                    Sentence = "Future Activity 3"
                },
                new Activity
                {
                    Sentence = "Future Activity 4"
                },
                new Activity
                {
                    Sentence = "Future Activity 5"
                },
                new Activity
                {
                    Sentence = "Future Activity 6"
                },
                new Activity
                {
                    Sentence = "Future Activity 7"
                },
                new Activity
                {
                    Sentence = "Future Activity 8"
                }
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}
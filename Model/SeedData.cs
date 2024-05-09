using CIS169IntroToNET.Data;
using Microsoft.EntityFrameworkCore;

namespace CIS169IntroToNET.Model;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new CIS169IntroToNETContext(
                   serviceProvider.GetRequiredService<
                       DbContextOptions<CIS169IntroToNETContext>>()))
        {
            if (context == null || context.Course == null)
            {
                throw new ArgumentNullException("Null RazorPagesMovieContext");
            }

            if (context.Course.Any())
            {
                return; 
            }

            context.Course.AddRange(
                new Course
                {
                    CourseName = "CIS 501",
                    CourseDescription = "Intro to Business Analysis",
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("08:00:00"),
                    EndTime = TimeOnly.Parse("08:50:00")
                },

                new Course
                {
                    CourseName = "CIS 169",
                    CourseDescription = "C#",
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("09:00:00"),
                    EndTime = TimeOnly.Parse("09:50:00")
                },

                new Course
                {
                    CourseName = "CIS 486",
                    CourseDescription = "Intro to 4GL",
                    RoomNumber = 0,
                    StartTime = TimeOnly.Parse("00:00:00"),
                    EndTime = TimeOnly.Parse("00:00:00")
                },

                new Course
                {
                    CourseName = "CIS 681",
                    CourseDescription = "Advanced .NET Programming",
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("09:00:00"),
                    EndTime = TimeOnly.Parse("09:50:00")
                },
                
                new Course
                {
                    CourseName = "CIS 855",
                    CourseDescription = "Field Projects",
                    RoomNumber = 200,
                    StartTime = TimeOnly.Parse("10:00:00"),
                    EndTime = TimeOnly.Parse("10:50:00")
                }
            );
            context.SaveChanges();
        }
    }
}
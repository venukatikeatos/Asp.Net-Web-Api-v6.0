namespace CollegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>{
                new Student
                {
                    Id = 1,
                    StudentName = "Test",
                    Email = "Test@gmail.com",
                    Address ="Hyd,India"
                },
                new Student
                {
                    Id = 2,
                    StudentName = "Test1",
                    Email = "Test1@gmail.com",
                    Address ="Hyd,India"
                },
                new Student
                {
                    Id = 3,
                    StudentName = "Test2",
                    Email = "Test2@gmail.com",
                    Address ="Hyd,India"
                }
                };
    }
}

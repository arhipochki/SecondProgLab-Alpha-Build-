using ForTest;
using System.Text.Json;

Dictionary<string, List<Student>> students = new Dictionary<string, List<Student>>()
{
    { "CS-23", new List<Student> { new Student { Name = "Alex", Group = "CS-23" }, new Student { Name = "Artyom", Group = "CS-23" } } },
    { "CS-28", new List<Student> { new Student { Name = "Nikita", Group = "CS-28" }, new Student { Name = "Maxim", Group = "CS-28" } } },
    { "CS-20", new List<Student> { new Student { Name = "Anya", Group = "CS-20" }, new Student { Name = "Misha", Group = "CS-20" } } },
    { "CS-26", new List<Student> { new Student { Name = "Katya", Group = "CS-26" }, new Student { Name = "Amir", Group = "CS-26" } } },
};

/*var _jsonString = File.ReadAllText("Data.json");
Dictionary<string, List<Student>> students = JsonSerializer.Deserialize<Dictionary<string, List<Student>>>(_jsonString);
*/

List<Teacher> teachers = new List<Teacher>();

teachers.Add(new Teacher { Name = "Svyatoslav", Subjects = new Dictionary<Subject, List<string>> { { new Subject { Name = "Programming on High-Level languages" }, new List<string> { "CS-23", "CS-28" } } } });
teachers.Add(new Teacher { Name = "Alexey", Subjects = new Dictionary<Subject, List<string>> { { new Subject { Name = "Technology of programming" }, new List<string> { "CS-20", "CS-26" } } } });
teachers.Add(new Teacher { Name = "Yulia", Subjects = new Dictionary<Subject, List<string>> { { new Subject { Name = "Math" }, new List<string> { "CS-23" } } } });

foreach (var teacher in teachers)
{
    foreach (var subj in teacher.Subjects)
    {
        foreach (var group in subj.Value)
        {
            foreach (var student in students[group])
            {
                student.Grades.Add(subj.Key.Name, new Random().Next(0, 60));
            }
        }
    }    
}

foreach (var group in students)
{
    foreach (var student in group.Value)
    {
        student.CalculateRating();
        Console.Write($"{student.Name} {student.Group}");
        foreach (var subj in student.Grades)
        {
            Console.Write($" {subj.Key} {subj.Value}");
        }
        Console.Write($" rating: {student.Rating}\n");
    }
}

string fileName = "Data.json";
var options = new JsonSerializerOptions { WriteIndented = true };
string jsonString = JsonSerializer.Serialize(students, options);
File.WriteAllText(fileName, jsonString);

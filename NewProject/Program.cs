using NewProject;

Group p137 = new Group(1);



p137.AddStudent(new Student("kenan", "Qahramanof"));
p137.AddStudent(new Student("Adil", "Tehranli"));
p137.AddStudent(new Student("Maned", "Amirof"));
p137.AddStudent(new Student("Said", "Amirli"));


Console.WriteLine(p137.GetAll());


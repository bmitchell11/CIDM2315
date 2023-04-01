namespace Homework9;
class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(111, "Alice");
        Student Bob = new Student(222, "Bob");
        Student Cathy = new Student(333, "Cathy");
        Student David = new Student(444, "David");
        foreach(Student stu in Student.student_list){
            stu.PrintInfo();
        }

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);
        if(gradebook.ContainsKey("Tom")){
            //null
        }
        else{
            gradebook.Add("Tom", 3.3);
        }

        double sum = gradebook.Values.Sum();
        double dividend = gradebook.Count;
        double avg = sum/dividend;
        Console.WriteLine($"The average GPA is {avg}");


        foreach(var grade in gradebook){
            if(grade.Value > avg){
                if(grade.Key=="Alice"){
                    Alice.PrintInfo();
                }
                if(grade.Key=="Bob"){
                    Bob.PrintInfo();
                }
                if(grade.Key=="Cathy"){
                    Cathy.PrintInfo();
                }
                if(grade.Key=="David"){
                    David.PrintInfo();
                }
            }
   
        }

    }

}
        
class Student
{
    public static List<Student> student_list = new List<Student>();
    public int studentID {get; set;}
    public string studentName {get; set;}

    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, studentName: {studentName}");
    }

    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);
    }
}        








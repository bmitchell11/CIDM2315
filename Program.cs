namespace Homework6;
class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.setSalary(9000);
        p1.PrintProfessorInfo();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.setSalary(8000);
        p2.PrintProfessorInfo();

        Student s1 = new Student();
        s1.studentName = "Alice";
        s1.classEnroll = "Java";
        s1.setGrade(90);
        s1.PrintStudentInfo();
        
        Student s2 = new Student();
        s2.studentName = "Bob";
        s2.classEnroll = "Math";
        s2.setGrade(80);
        s2.PrintStudentInfo();


        double salary_diff = SalaryDifference(p1.getSalary(),p2.getSalary());
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is {salary_diff}");

        double total_grade = TotalGrade(s1.getGrade(), s2.getGrade());
        Console.WriteLine($"The total grade of {s1.studentName} and {s2.studentName} is {total_grade}");
    }

    

    public static double SalaryDifference(double sal1, double sal2){
        if(sal1>sal2){
            return sal1-sal2;
        }
        else{
            return sal2-sal1;
        }
    }

    public static double TotalGrade(double grade1, double grade2){
        return grade1+grade2;
    }
    
}

class Professor{
    
    public string profName;

    public string classTeach;

    public double salary {set; get;}

    public void setSalary(double salary_amount){
        salary = salary_amount;
    }
    public double getSalary(){
        return salary;
    }

    public void PrintProfessorInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {getSalary()}");
    }


}

class Student{
    public string studentName;

    public string classEnroll;

    public double studentGrade {set; get;} 

    public void setGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double getGrade(){
        return studentGrade;
    }

    public void PrintStudentInfo(){
        Console.WriteLine($"Student {studentName} enrolls {classEnroll}, and the grade is {getGrade()}");
    }
    
}

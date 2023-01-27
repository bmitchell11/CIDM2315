namespace Homework2;
class Program
{
    static void Main(string[] args)
    {

       Console.WriteLine("Please input a letter grade");
        string input_letter_grade = Console.ReadLine();
        if(input_letter_grade=="A"){
            Console.WriteLine("GPA Point: 4");
        }else if(input_letter_grade=="B"){
            Console.WriteLine("GPA Point: 3");
        }
        else if(input_letter_grade=="C"){
            Console.WriteLine("GPA Point: 2");
        }
        else if(input_letter_grade=="D"){
            Console.WriteLine("GPA Point: 1");
        }
        else if(input_letter_grade=="F"){
            Console.WriteLine("GPA Point: 0");
        }else{
            Console.WriteLine("Wrong Letter Grade!");
        }
        }

    }


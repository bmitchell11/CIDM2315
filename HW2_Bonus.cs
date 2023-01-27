namespace Homework2_Bonus;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Please input a year");
        string input_year = Console.ReadLine();
        int x = Convert.ToInt16(input_year);

        if(x%4==0){
            if(!(x%100==0)||(x%400==0)){
                Console.WriteLine($"{input_year} is a Leap Year!");
            }else{
                Console.WriteLine($"{input_year} is not a Leap Year");
        }
        }else{
            Console.WriteLine($"{input_year} is not a Leap Year");
        }
    }
}

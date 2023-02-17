namespace Homework5;
class Program
{
    static void Main(string[] args)
    {
        
        // Question 1
        Console.WriteLine("Please input an integer");
        int input1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input an integer");
        int input2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"a = {input1}, b = {input2}");
        int max1 = LargestNumber(input1,input2);
        Console.WriteLine($"The largest number is {max1}");
        

        
        // Question 2
        Console.WriteLine("Please input an integer");
        int input_a = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input an integer");
        int input_b = Convert.ToInt16(Console.ReadLine());        
        Console.WriteLine("Please input an integer");
        int input_c = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input an integer");
        int input_d = Convert.ToInt16(Console.ReadLine());
        int max_num1 = LargestNumber(input_a,input_b);
        int max_num2 = LargestNumber(input_c,input_d);
        int max_num3 = LargestNumber(max_num1,max_num2);
        Console.WriteLine($"a = {input_a}, b = {input_b}, c = {input_c}, d = {input_d}");
        Console.WriteLine($"The largest number is: {max_num3}");
        
        


        // Question 3
        CreateAccount();

        }

 



        // Question 1 & 2 Method
    static int LargestNumber(int a, int b)
    {
        if(a>b){
            return a; 
        }
        else{
            return b;
        }
    }
    



        // Question 3 Method
    static void CreateAccount()
    {
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password");
        string password = Console.ReadLine();
        Console.WriteLine("Enter your password again");
        string password_ver = Console.ReadLine();
        Console.WriteLine("Enter your birth year:");
        int BirthYear = Convert.ToInt16(Console.ReadLine());
        bool Age = CheckAge(BirthYear);
        if(Age==true){
            if(password==password_ver){
                Console.WriteLine("Account Created Successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }
    }

    
    // Question 3 Method
    static bool CheckAge(int birth_year)
    {
        int age = (2023-birth_year);
        if(age>=18){
            return true;
        }
        else{
            return false;
        }

       

    }
    


}






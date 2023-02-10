namespace Homework4;
class Program
{
    static void Main(string[] args)
    {
        // Q1 MAIN
        int n1, n2;
 
        Console.WriteLine("Please input an integer:");
        n1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input an integer:");
        n2 = Convert.ToInt16(Console.ReadLine());    
        Console.WriteLine($"a = {n1}; b = {n2}");
        
        int returned_num = LargestNumber(n1, n2);
        Console.WriteLine($"{returned_num} is the largest number");

        // Q2 MAIN

        Triangle();
    }
    
    

    // Q1 METHOD
    static int LargestNumber(int a,int b)
    {
        if(a>b){
            return a;
        }
        else{
            return b;
        }
        

    }

    //Q2 METHOD
    static void Triangle()
    {
        Console.WriteLine("Assign an integer value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Input a shape for the triangle");
        string shape = Console.ReadLine();
        Console.WriteLine($"N is: {N}; shape is {shape}");
        if(shape=="left"){
            for(int a = 0; a<N; a++)
        {
                for(int b = 0; b<N; b++){
                    if(a>=b)
                    Console.Write("*");
        }
            Console.WriteLine("");    
        }
        }
        if(shape=="right"){
            for(int d = 0; d<N; d++)
        {

                for(int e = 1; e<N-d; e++)
                {

                    Console.Write(" ");
                    }
                for(int f = 0; f<=d ; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
                }


        }
    }

    }

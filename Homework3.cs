namespace Homework3;
class Program
{
    static void Main(string[] args)
    {

        
        //Q1

    Console.WriteLine("Input an integer");
    int x = Convert.ToInt16(Console.ReadLine());
    int y = 0;
    for(int i = 1; i<=x; i++)
    {
        if(x%i==0){
            y++;
        }

    }
    if(y==2)
    {
        Console.WriteLine($"{x} is a prime number");
    }else{
        Console.WriteLine($"{x} is not a prime number");
    }

    




        // Q2

        Console.WriteLine("Assign an integer value to N:");
        
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++){
                Console.Write("#");
            }
            Console.WriteLine("");
            }        
    




        
    
        //Q3

        Console.WriteLine("Assign an integer value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++){
                if(row>=col)
                Console.Write("*");
        }
            Console.WriteLine("");    
        }
        

        
        
}
}

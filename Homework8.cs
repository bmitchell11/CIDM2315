namespace Homework8;
class Program
{
    static void Main(string[] args)
    {
        int[] int_array = {11,21,31,42,53};
        ArraySum(int_array);

        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

          // Test Q2.1
        PrintAllOddNumber(array_2d);

        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");        

        // Test Q2.3 
        
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");        
        }
        
        

    }


    public static void ArraySum(int[] int_array)
    {
        Console.WriteLine(int_array.Sum());
    }


    public static void PrintAllOddNumber(int[ , ] array_2d)
    {
       foreach(int value in array_2d)
       {
            if(value%2!=0){
                Console.Write($"{value}" + " ");
            }
       }
    }

    public static int ElementSum(int[ , ] array_2d)
    {   

        int sum = 0;
        for(int row=0; row<3; row++){
            for(int col=0; col<3; col++){
                sum += array_2d[row,col];
            }   
        }
        return sum;
    }





    public static int[ , ] DoubleArray(int[ , ] array_2d){

        int[,] double_array = {
        {2, 4, 6},
        {8, 10, 12},
        {14, 16, 18}
        };
        int[,] value = double_array;
        return double_array;
      







    
    }





}


       
    

    

   







     




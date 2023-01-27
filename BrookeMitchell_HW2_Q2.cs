namespace Homework2_Q2;
class Program
{
    static void Main(string[] args)
    {
        



        Console.WriteLine("Please input the first num");
        string str_num_x = Console.ReadLine();
        int int_x = Convert.ToInt16(str_num_x);

        Console.WriteLine("Please input the second num");
        string str_num_y = Console.ReadLine();
        int int_y = Convert.ToInt16(str_num_y);

        Console.WriteLine("Please input the third num");
        string str_num_z = Console.ReadLine();
        int int_z = Convert.ToInt16(str_num_z);

        if(int_x<int_y){
            if(int_x<int_z){
                Console.WriteLine($"{str_num_x} is the smallest number");
            }else{
                Console.WriteLine($"{str_num_z} is the smallest number");
            }
        }
        if(int_y<int_x){
            if(int_y<int_z){
                Console.WriteLine($"{str_num_y} is the smallest number");
            }else{
                Console.WriteLine($"{str_num_z} is the smallest number");
            }
        }
    
 }

}

namespace Homework7;
class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(cus_id:110, cus_name:"Alice", cus_age:28);
        Customer cus2 = new Customer(cus_id:111, cus_name:"Bob", cus_age:30);
        cus1.PrintCusInfo();
        cus2.PrintCusInfo();
        cus1.ChangeID(220);
        cus2.ChangeID(221);
        cus1.PrintCusInfo();
        cus2.PrintCusInfo();
        cus1.CompareAge(cus2);
    }
}

class Customer{
    private int id = 0;
    public string name = string.Empty;
    public int age = 0;
    public void PrintCusInfo(){
        Console.WriteLine($"Customer:{id}, name: {name}, age: {age}");
    }

    public Customer(int cus_id, string cus_name, int cus_age){
        id = cus_id;
        name = cus_name;
        age = cus_age;
    }

    public void ChangeID(int new_id){
        id=new_id;
    }
    public void CompareAge(Customer objCustomer){
        if(this.age >= objCustomer.age){
            Console.WriteLine($"{this.name} is older");
        }
        else{
            Console.WriteLine($"{objCustomer.name} is older");
        }
    }
        
}

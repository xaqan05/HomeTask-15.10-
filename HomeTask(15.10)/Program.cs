
//   Task 1

/*namespace HomeTask_15._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Hyundai","Elantra",125000,4);

            car1.ShowFullInfo();

            MotorCycle motor1 = new MotorCycle("Kawasaki","Ninja 650",20000,2);
            motor1.ShowFullInfo();
        }
    }

    class Vehicle
    {
        public string Brand;
        public string Model;
        public double Mile;

        public Vehicle(string brand,string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        public Vehicle(string brand,string model,double mile) :this(brand,model) 
        {
            this.Mile = mile;
        }
    }

    class Car : Vehicle
    {
        public int DoorsNum;

       
        public Car(string brand,string model,double mile,int doorsNum) : base(brand,model,mile) 
        {
            this.DoorsNum = doorsNum;
        }
        public void ShowFullInfo()
        {
            Console.WriteLine("Brand:" + Brand + " " + "Model:" + Model + " " + "Mile:" + Mile + " " + "Doors Num:" + DoorsNum);
        }
    }

    class MotorCycle : Vehicle
    {
        public int WheelNum;

        public MotorCycle(string brand,string model,double mile,int wheelNum): base(brand,model,mile)
        {
            this.WheelNum = wheelNum;
        }

        public void ShowFullInfo()
        {
            Console.WriteLine("Brand:" + Brand + " " + "Model:" + Model + " " + "Mile:" + Mile + " " + "Doors Num:" + WheelNum);
        }

    }
}*/








//   Task 2





namespace HomeTask_15._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notebook notebook = new Notebook("Lenovo", "İş üçün notebook", 1, true, 1500, 16, 512);

            notebook.Sale();
            notebook.GetFullInfo();
        }

    }

    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string Name, string description, int count, bool isStock, double price)
        {
            this.Name = Name;
            this.Description = description;
            this.Count = count;
            this.IsStock = isStock;
            this.Price = price;

        }

        public void Sale()
        {
            if(IsStock && Count > 0)
            {
                Count--;
                if(Count == 0)
                {
                    IsStock = false;
                }
                Console.WriteLine("Mehsul satildi");
            }
            else
            {
                Console.WriteLine("Mehsul yoxdur !!");
            }
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Count: {Count}, IsStock: {IsStock}, Price: {Price}");
        }
    }

    class Notebook : Product
    {
        public byte RAM;
        public int Storage;

        public Notebook(string name,string description,int count,bool isStock,double price,byte ram,int storage) : base(name,description,count,isStock,price) 
        {
            this.RAM = ram;
            this.Storage = storage;
        }
        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Count: {Count}, IsStock: {IsStock}, Price: {Price}, RAM: {RAM}, Storage: {Storage}");
        }
    }
}

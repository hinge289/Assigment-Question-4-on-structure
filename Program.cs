namespace struct_assigment_2_Q3
{
    struct Car
    {
        Car[] cars;
        internal string brand, color, model;
        internal long price;
        internal int year;

        public Car(Car[]arr)
        {
            cars = arr;
        }

        public void user_demand(long price_range,string color,int year)
        {
            Console.WriteLine("_______________________CARS LIST___________________________");
            Console.WriteLine("Similar to your search criteria _____________________________________");
            Console.WriteLine("BRAND\t\t\tMODEL\t\t\tCOLOR\t\t\tM YEAR\t\tPRICE");
            for (int i = 0; i < cars.Length; i++) 
            {
                if (color == cars[i].color && price_range >= cars[i].price && year >= cars[i].year)
                {
                    Console.WriteLine($"{cars[i].brand}\t\t\t{cars[i].model}\t\t\t{cars[i].color}\t\t\t{cars[i].year}\t\t\t{cars[i].price}");
                } 
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car[] cars = new Car[5];
            cars[0].brand = "TOYOTA";
            cars[0].color = "Red";
            cars[0].model = "Glanza";
            cars[0].price = 1000000;
            cars[0].year = 2024;

            cars[1].brand = "TATA";
            cars[1].color = "Black";
            cars[1].model = "Harrier";
            cars[1].price = 2000000;
            cars[1].year = 2023;

            cars[2].brand = "TOYOTA";
            cars[2].color = "Red";
            cars[2].model = "Fortuner";
            cars[2].price = 4500000;
            cars[2].year = 2022;

            cars[3].brand = "TATA";
            cars[3].color = "Blue";
            cars[3].model = "Nexon";
            cars[3].price = 900000;
            cars[3].year = 2024;

            cars[4].brand = "MARUTI";
            cars[4].color = "Red";
            cars[4].model = "Baleno";
            cars[4].price = 700000;
            cars[4].year = 2024;

            Car obj= new Car(cars);

            Console.WriteLine("__________________Welcome TO XYZ___________________________");
            Console.WriteLine("Enter Price Range");
            long price_r=long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year ");
            int years=int.Parse(Console.ReadLine());
            Console.WriteLine("What Color of car doyou want?  Red/Black/Blue");
            string colors = Console.ReadLine();

            obj.user_demand(price_range:price_r,color:colors,year:years);




        }
    }
}

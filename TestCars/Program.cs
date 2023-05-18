namespace TestCars
{
    class Program

    {
        private static Input input = new Input();

        static void Main(string[] args)
        {
            int CountCarsForRepair = InputCountCarsForRepairing();
        }
        static int InputCountCarsForRepairing()
        {
            int CountCarsForRepair = 0;
            Console.WriteLine("\tHow many cars were received for repair?");
            int CountCars = input.UserInputCountCars();



            Car[] cars = new Car[CountCars];

            for (var i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Input info about car");
                Console.WriteLine($"\nCar {i + 1}\n");
                cars[i] = GetCar();

            }

            Console.WriteLine("\nlist of cars\n");

            for (var i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Car {i + 1}");
                Print(cars[i]);
                Console.WriteLine();
            }
            return CountCarsForRepair;
        }
        static Car GetCar()
        {
            Car car = new Car();
            car.id = Guid.NewGuid();
            car.wheel = input.UserInputCountWheels(car);
            Console.WriteLine();
            car.body = input.UserInputTypeOfBody(car);
            Console.WriteLine();
            car.engine = input.UserInputTypeOfEngine(car);
            Console.WriteLine();
            car.paint = input.UserInputColorOfCar(car);
            Console.Clear();
            return car;
        }

        static void Print(Car car)
        {
            Console.WriteLine("Info about car ");
            Console.WriteLine($"Id: {car.id}");
            Console.WriteLine($"wheel: {car.wheel}");
            Console.WriteLine($"body: {car.body}");
            Console.WriteLine($"engine: {car.engine}");
            Console.WriteLine($"paint: {car.paint}");
        }  
    }
}

/* List<string> FreeSlotsForCarsForRepair = new List<string>(5);
        if (cars == "ready")
        {
            FreeSlotsForCarsForRepair.Add($"{cars[i]}");
            Console.WriteLine($"Car {cars[i]} IS ready for delivery to the client");

        }
        else
        {
            Console.WriteLine($"Car {cars[i]} ISN'T ready for delivery to the client");
        } */
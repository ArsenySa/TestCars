using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCars
{
    public class Input
    {
       public int UserInputCountCars()
        {
            do
            {

                var IsNumber = int.TryParse(Console.ReadLine(), out int CountCars);
                if (IsNumber)
                {
                    return CountCars;
                }
                else
                {
                    Console.WriteLine("please, input valid value(number)");
                }

            } while (true); //check for valid count cars
        }
       public byte UserInputCountWheels(Car car)
        {
            do
            {
                Console.WriteLine("input count wheels");
                var IsNumber = byte.TryParse(Console.ReadLine(), out car.wheel);
                if (IsNumber)
                {
                    return car.wheel;
                }
                else
                {
                    Console.WriteLine("please, input valid value(number)");
                }
            } while (true); //check for valid count wheels
        }
       public string UserInputTypeOfBody(Car car)
        {
            string[] TypeOfBody = { "1.Hatchback", "2.Sedan", "3.MUV / SUV", "4.Coupe", "5.Convertible", "6.Wagon", "7.Van", "8.Jeep" };
            Console.WriteLine("choose the type of body");
            for (int i = 0; i < TypeOfBody.Length; i++)
            {
                Console.WriteLine(TypeOfBody[i]);
            }
            Console.WriteLine("\nPress 1-8\n");
            do
            {
                var x = Console.ReadLine();
                if (int.TryParse(x, out int a))
                {
                    return TypeOfBody[a - 1];
                }
                else
                {
                    Console.WriteLine("please, input valid value(number)");
                }

            } while (true); //check for valid type of body
        }
       public string UserInputTypeOfEngine(Car car)
        {
            string[] TypeOfEngine = { "1.mechanical engineering", "2.electrical", "3.design engineering", "4.manufacturing engineering", "5.automotive engineering" };
            Console.WriteLine("choose the type of engine");
            for (int i = 0; i < TypeOfEngine.Length; i++)
            {
                Console.WriteLine(TypeOfEngine[i]);
            }
            Console.WriteLine("\nPress 1-5\n");
            do
            {
                var x = Console.ReadLine();
                if (int.TryParse(x, out int a))
                {
                    return TypeOfEngine[a - 1];
                }
                else
                {
                    Console.WriteLine("please, input valid value(number)");
                }

            } while (true); //check for valid type of engine
        }
       public string UserInputColorOfCar(Car car)
        {
            string[] ColorOfCar = { "1.red", "2.orange", "3.yellow", "4.green", "5.blue", "6.indigo", "7.violet" };
            Console.WriteLine("choose the type of engine");
            for (int i = 0; i < ColorOfCar.Length; i++)
            {
                Console.WriteLine(ColorOfCar[i]);
            }
            Console.WriteLine("\nPress 1-7\n");
            do
            {
                var x = Console.ReadLine();
                if (int.TryParse(x, out int a))
                {
                    return ColorOfCar[a - 1];
                }
                else
                {
                    Console.WriteLine("please, input valid value(number)");
                }

            } while (true); //check for valid type of paint
        }
    }
}

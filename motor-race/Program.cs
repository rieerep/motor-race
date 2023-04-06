using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace motor_race
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

			Car carOne = new Car()
			{
				carId = 1,
				name = "Mazda Autozam",
				distanceTraveled = 0,
				time = 0,
			};

			Car car2 = new Car()
			{
				carId = 1,
				name = "Land Cruiser",
				distanceTraveled = 0,
				time = 0,
			};

			Car car3 = new Car()
			{
				carId = 1,
				name = "Mazda Autozam",
				distanceTraveled = 0,
				time = 0,
			};

			Console.WriteLine(carOne.name);
			var carOneTask = await Race(carOne);
			var raceStatusTask = RaceStatus(carOne);

			Console.WriteLine(carOneTask);

        }

		public async static Task<Car> Race(Car carOne)
		{
			int tick = 30;
			int raceDistance = 10000;
			while (true)
			{
				await Wait(tick);
				carOne.distanceTraveled += (33.33M * tick);
				Console.WriteLine($"Car: {carOne.name} Distance traveled: {carOne.distanceTraveled}");
				// Console.WriteLine($"Distance traveled: {car.distanceTraveled}");

				if (carOne.distanceTraveled >= raceDistance)
				{
					Console.WriteLine("You reached the finish line");
					return carOne;
				}
			}
		}
		private static async Task Wait(double delay = 1)
		{
			await Task.Delay(TimeSpan.FromSeconds(delay / 10));

			// Lägga in slumpgenererad händelse här?
			// Tärningsmodell - händelse baserad på vad man slår
			Console.WriteLine("30 seconds passed");
		}
		public async static Task RaceStatus(Car car)
		{
			while (true)
			{
				await Task.Delay(TimeSpan.FromSeconds(1));
				Console.WriteLine($"{car.name} has reached {car.distanceTraveled} and has been driving for {car.time} seconds");
			}
            
        }

		public static void PrintCar (Car car)
		{
			Console.WriteLine($"car name: {car.name}");
		}
    }
}
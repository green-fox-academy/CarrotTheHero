using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class ParkingLot
    {
        public List<Car> listOfCars = new List<Car>();
        Random random = new Random();

        public ParkingLot(int numberOfCars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                listOfCars.Add(new Car((CarType)random.Next(typeof(CarType).GetEnumNames().Length),
                    (CarColor)random.Next(typeof(CarColor).GetEnumNames().Length)));
            }
        }

        public void GetNumberOfSameType()
        {
            var porscheQuery = from porsche in listOfCars
                            where porsche.Type == CarType.Porsche
                            select porsche;

            var paganiQuery = from pagani in listOfCars
                               where pagani.Type == CarType.Pagani
                               select pagani;

            var ferrariQuery = from ferrari in listOfCars
                             where ferrari.Type == CarType.Ferrari
                             select ferrari;
            Console.WriteLine("Number of Porsches: {0} \nNumber of Paganis: {1} \nNumber of Ferraris: {2}",
                porscheQuery.Count(), paganiQuery.Count(), ferrariQuery.Count());
        }

        public void GetNumberOfSameColor()
        {
            var greenQuery = from color in listOfCars
                             where color.Color == CarColor.black
                             select color;

            var blueQuery = from color in listOfCars
                            where color.Color == CarColor.yellow
                            select color;

            var redQuery = from color in listOfCars
                           where color.Color == CarColor.red
                           select color;

            Console.WriteLine("Number of Black cars: {0} \nNumber of Yellow cars: {1} \nNumber of Red cars: {2}",
                greenQuery.Count(), blueQuery.Count(), redQuery.Count());
        }
        public void GetMostFrequentCar()
        {
            var frequencyOfCars = from car in listOfCars
                                  group car by car.Type into uniqueCars
                                  orderby uniqueCars.Count() descending
                                  select new { uniqueCars.Key, Count = uniqueCars.Count() };
            var mostFrequent = frequencyOfCars.FirstOrDefault();

            Console.WriteLine("The most common car in the parkinglot is: {0}", mostFrequent.Key);
        }
    }
}
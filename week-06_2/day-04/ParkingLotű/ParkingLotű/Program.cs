﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkinglot = new ParkingLot(256);

            Console.WriteLine();

            parkinglot.GetNumberOfSameType();
            parkinglot.GetNumberOfSameColor();
            parkinglot.GetMostFrequentCar();

            Console.ReadLine();
        }
    }
}

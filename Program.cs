using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  4- Your job is to write a program for a speed camera. 
//  For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.

//  Write a program that asks the user to enter the speed limit. 
//  Once set, the program asks for the speed of a car. 
//  If the user enters a value less than the speed limit, program should display Ok on the console.

//  If the value is above the speed limit, the program should calculate the number of demerit points. 
//  For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
//  If the number of demerit points is above 12, the program should display License Suspended.

// Late update - you can probably do this via demeritPoints++ (by incrementing 1). I've already finished it
// Next time: add a while loop that continually asks the questions, and reassigns variable. You can do this as a while condition 
// e.g., bool exit = false; and when the user types "exit", then the bool becomes true, and exists out the loop


namespace UdemyCSharp_ControlFlow_Exercises1_Number4
{
    class Program
    {
        static void Main(string[] args)
        {

            int speedLimit;
            int speedCar;
           
            Console.WriteLine("Please insert the speed limit:");
            speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of the car?");
            speedCar = Convert.ToInt32(Console.ReadLine());

            int speedDifference = (speedCar - speedLimit);
            int demeritPoints;


            // Not speeding
            if (speedDifference <= 0)
            {
                Console.WriteLine("Ok!");
            }

            // Speeding - 0 demerit points
            if (speedDifference < 5 && speedDifference > 0)
            {
                demeritPoints = 0;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!" );
            }

            // Speeding - 1 demerit points
            if (speedDifference < 10 && speedDifference >= 5)
            {
                demeritPoints = 1;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 2 demerit points
            if (speedDifference < 15 && speedDifference >= 10)
            {
                demeritPoints = 2;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 3 demerit points
            if (speedDifference < 20 && speedDifference >= 15)
            {
                demeritPoints = 3;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 4 demerit points
            if (speedDifference < 25 && speedDifference >= 20)
            {
                demeritPoints = 4;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 5 demerit points
            if (speedDifference < 30 && speedDifference >= 25)
            {
                demeritPoints = 5;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 6 demerit points
            if (speedDifference < 35 && speedDifference >= 30)
            {
                demeritPoints = 6;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 7 demerit points
            if (speedDifference < 40 && speedDifference >= 35)
            {
                demeritPoints = 7;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 8 demerit points
            if (speedDifference < 45 && speedDifference >= 40)
            {
                demeritPoints = 8;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 9 demerit points
            if (speedDifference < 50 && speedDifference >= 45)
            {
                demeritPoints = 9;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 10 demerit points
            if (speedDifference < 55 && speedDifference >= 50)
            {
                demeritPoints = 10;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 11 demerit points
            if (speedDifference < 60 && speedDifference >= 55)
            {
                demeritPoints = 11;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - 12 demerit points
            if (speedDifference == 60)
            {
                demeritPoints = 12;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
            }

            // Speeding - LICENSE SUSPENDED because greater than 12 demerit points
            if (speedDifference > 60)
            {
                demeritPoints = 13;
                Console.WriteLine("You have incurred " + demeritPoints + " demerit points!");
                Console.WriteLine("LICENSE SUSPENDED!");
            }


        }
    }
}

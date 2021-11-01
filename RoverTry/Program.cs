using RoverTry.Concrete;
using RoverTry.Concrete.Movement;
using System;

namespace RoverTry
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Plateau plateau = new Plateau("5 5");
            Rover rover = new Rover();
            Movement movement = new Movement(plateau, rover);
            rover.SetStartPos("1 2 N");
            movement.GetMovement("LMLMLMLMM");
            movement.PrintPos();

            //Plateau plateau1 = new Plateau("5 5");
            //Rover rover1 = new Rover();
            //Movement movement1 = new Movement(plateau1, rover1);
            //rover1.SetStartPos("3 3 E");
            //movement1.GetMovement("MMRMMRMRRM");
            //movement1.PrintPos();



        }
    }
}

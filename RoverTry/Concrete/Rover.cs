using RoverTry.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTry.Concrete
{
    public class Rover : IRover 
    {


        private char Direction;
        private int CoordinateX = 0;
        private int CoordinateY = 0;

        public Rover()
        {
            
        }
        public void SetStartPos(string position)
        {
            var splitPos = position.Split(" ");
            CoordinateX = Int32.Parse(splitPos[0]);
            SetCoordinateX(CoordinateX);
            CoordinateY = Int32.Parse(splitPos[1]);
            SetCoordinateY(CoordinateY);
           Direction= Convert.ToChar(splitPos[2]);
            SetDirection(Direction);
        }

       

        public void SetDirection(char direction)
        {
            this.Direction = direction;
        }

        public char GetDirection()
        {
            return this.Direction;
        }

        public void SetCoordinateX(int x)
        {
            this.CoordinateX = x;
        }

        public int GetCoordinateX()
        {
            return this.CoordinateX;
        }

        public void SetCoordinateY(int y)
        {
            this.CoordinateY = y;
        }

        public int GetCoordinateY()
        {
            return this.CoordinateY;
        }
    }
}

using RoverTry.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTry.Concrete
{
   public class Plateau : IPlateau
    {
        public int gridX;
        public int gridY;
       
        public Plateau(string gridSize)
        {
            var splitAxis = gridSize.Split(" ");
            gridY = Int32.Parse(splitAxis[0]);
            SetGridY(gridY);
            gridX = Int32.Parse(splitAxis[1]);
            SetGridX(gridX);
        }

        public int GetGridX()
        {
            return this.gridX;
        }

        public int GetGridY()
        {
            return this.gridY;
        }

        public void SetGridX(int x)
        {
            this.gridX = x;
        }

        public void SetGridY(int y)
        {
            this.gridY = y;
        }
    }
}

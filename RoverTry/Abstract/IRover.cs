using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTry.Abstract
{
   public interface IRover
    {

        void SetDirection(char direction);
        char GetDirection();
        void SetStartPos(string position);
        

        void SetCoordinateX(int x);
        int GetCoordinateX();
        void SetCoordinateY(int y);
        int GetCoordinateY();

    }
}

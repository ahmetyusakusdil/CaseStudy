using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTry.Abstract.Movement
{
   public interface IMovement
    {
       
        
        void GetMovement(string coordinates);
        void CheckMovement(char movement);
        void Move();
        void TurnLeft();
        void TurnRight();
        void PrintPos();


    }
}

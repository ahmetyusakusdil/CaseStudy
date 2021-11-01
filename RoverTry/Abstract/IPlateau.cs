using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTry.Abstract
{
   public interface IPlateau
    {
        void SetGridX(int x);
        int GetGridX();

        void SetGridY(int y);
        int GetGridY();

    }
}

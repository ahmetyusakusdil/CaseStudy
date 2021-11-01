using RoverTry.Abstract;
using RoverTry.Concrete;
using RoverTry.Abstract.Movement;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoverTry.Concrete.Movement
{
    public class Movement : IPlateau, IMovement
    {
        private const char NorthDirection = 'N';
        private const char EastDirection = 'E';
        private const char SouthDirection = 'S';
        private const char WestDirection = 'W';
        private const char MovementLeft = 'L';
        private const char MovementRight = 'R';
        private const char MovementMove = 'M';
        char MoveDirection ='M';
       
        int CoordinateX = 0;
        int CoordinateY = 0;
        int GridX;
        int GridY;

        IPlateau _plateau;
        IRover _rover;

        
        public Movement(IPlateau plateau, IRover rover)
        {
            _plateau = plateau;
            _rover = rover;
            
        }
        public void TurnLeft()
        {
           
                switch (MoveDirection)
                {
                    case NorthDirection:
                        MoveDirection = WestDirection;
                        break;
                    case EastDirection:
                        MoveDirection = NorthDirection;
                        break;
                    case SouthDirection:
                        MoveDirection = EastDirection;
                        break;

                    case WestDirection:
                        MoveDirection = SouthDirection;
                        break;
                    default:
                        break;
                }
            
           
        }

        public void TurnRight()
        {
           
                switch (MoveDirection)
                {
                    case NorthDirection:
                        MoveDirection = EastDirection;
                        break;
                    case EastDirection:
                        MoveDirection = SouthDirection;
                        break;
                    case SouthDirection:
                        MoveDirection = WestDirection;
                        break;

                    case WestDirection:
                        MoveDirection = NorthDirection;
                        break;
                    default:
                        break;
                }
            
        }

        public void Move()
        {
           
            this.CoordinateX = _rover.GetCoordinateX();
            this.CoordinateY = _rover.GetCoordinateY();
           
                switch (MoveDirection)
                {
                    case NorthDirection:
                        if (CoordinateY < _plateau.GetGridY()) CoordinateY++;
                        else Console.WriteLine($"CoordinateY out of bounds");
                        break;

                    case EastDirection:
                        if (CoordinateX < _plateau.GetGridX()) CoordinateX++;
                        else Console.WriteLine($"CoordinateX out of bounds");
                        break;

                    case SouthDirection:
                        if (CoordinateY > 0) CoordinateY--;
                        else Console.WriteLine($"CoordinateY out of bounds");
                        break;

                    default:
                        if (CoordinateX > 0) CoordinateX--;
                        else Console.WriteLine($"CoordinateX out of bounds");
                        break;
                }
            

        }

        public void GetMovement(string coordinates)
        {

                for (int i = 0; i < coordinates.Length; i++)
                {
                    CheckMovement(coordinates[i]);

                }
          
                
        }

        public void CheckMovement(char movement)
        {
            
           
                switch (movement)
                {
                    case MovementLeft:
                        TurnLeft();
                    
                    break;

                    case MovementRight:
                        TurnRight();
                    
                    break;

                    default:
                        Move();
                        break;
                }
            
            
        }

        public void SetGridX(int x)
        {
            this.GridX = x;
        }

        public int GetGridX()
        {
            return this.GridX;
        }

        public void SetGridY(int y)
        {
            this.GridY = y;
        }

        public int GetGridY()
        {
            return this.GridY;
        }

        public void PrintPos()
        {
            Console.WriteLine(CoordinateX + " " + CoordinateY + " " + MoveDirection);
        }

       

        
    }
}

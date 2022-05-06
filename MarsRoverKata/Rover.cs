using MarsRoverKata.Commands;
using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    internal class Rover
    {
        //private const int TableSideLength = 10;
        //private int[,] _table = new int[TableSideLength, TableSideLength]
        //{
        //    //                         North
        //                {  1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
        //                { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 },
        //                { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
        //                { 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 },
        //    /* West */  { 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 }, /* East */
        //                { 51, 52, 53, 54, 55, 56, 57, 58, 59, 60 },
        //                { 61, 62, 63, 64, 65, 66, 67, 68, 69, 70 },
        //                { 71, 72, 73, 74, 75, 76, 77, 78, 79, 80 },
        //                { 81, 82, 83, 84, 85, 86, 87, 88, 89, 90 },
        //                { 91, 92, 93, 94, 95, 96, 97, 98, 99, 100 }
        //    //                          South
        //};

        private Position _currentPosition;
        private Directions _currentDirection;
        private List<MoveRoverCommand> _commands;

        public Rover(Position startingPosition, Directions startingDirection)
        {
            _currentPosition = startingPosition;
            _currentDirection = startingDirection;
            _commands = new List<MoveRoverCommand>();
        }

        public Position CurrentPosition => _currentPosition;

        public Rover AddCommand(MoveRoverCommand command)
        {
            _commands.Add(command);

            return this;
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                _currentPosition = command.Execute(_currentPosition, _currentDirection);
            }

            //return this;
        }

        //internal int MoveForward()
        //{
        //    Position position;

        //    switch (_currentDirection)
        //    {
        //        case Directions.North:
        //            //position = GetTablePositionFor(_currentPosition);
        //            int newPositionX = _currentPosition.X - 1;

        //            return newPositionX < 0
        //                ? _table[_currentPosition.X, _currentPosition.Y]
        //                : _table[newPositionX, _currentPosition.Y];
                    
        //        case Directions.South:
        //            //position = GetTablePositionFor(_currentPosition);
        //            int newsouthPositionX = _currentPosition.X + 1;

        //            return newsouthPositionX > 9
        //                ? _table[_currentPosition.X, _currentPosition.Y]
        //                : _table[newsouthPositionX, _currentPosition.Y];

        //        case Directions.East:

        //            //position = GetTablePositionFor(_currentPosition);
        //            int newEastPositionY = _currentPosition.Y - 1;

        //            return newEastPositionY < 0
        //                ? _table[_currentPosition.X, _currentPosition.Y]
        //                : _table[_currentPosition.X, newEastPositionY];

        //        case Directions.West:

        //            //position = GetTablePositionFor(_currentPosition);
        //            int newWestPositionY = _currentPosition.Y + 1;

        //            return newWestPositionY > 9
        //                ? _table[_currentPosition.X, _currentPosition.Y]
        //                : _table[_currentPosition.X, newWestPositionY];

        //        default:
        //            return 0;
        //    }
        //}

        internal Directions TurnLeft()
        {
            switch (_currentDirection)
            {
                case Directions.North:
                    return Directions.West;
                case Directions.South:
                    return Directions.East;
                case Directions.East:
                    return Directions.North;
                case Directions.West:
                    return Directions.South;
                default:
                    return Directions.North;
            }
        }

        internal Directions TurnRight()
        {
            switch (_currentDirection)
            {
                case Directions.North:
                    return Directions.East;
                case Directions.South:
                    return Directions.West;
                case Directions.East:
                    return Directions.South;
                case Directions.West:
                    return Directions.North;
                default:
                    return Directions.North;
            }
        }

        //internal void Direction(Directions direction)
        //{
        //    _currentDirection = direction;
        //}

        //public void StartingPoint(Position startingPosition)
        //{
        //    //_startingPoint = startingPoint;
        //    _currentPosition = startingPosition;
        //}

        //private Position GetTablePositionFor(int point)
        //{
        //    for (int row = 0; row < TableSideLength; row++)
        //    {
        //        for (int column = 0; column < TableSideLength; column++)
        //        {
        //            if (_table[row, column] == point)
        //                return new Position(row, column);
        //        }
        //    }

        //    return new Position(1, 1);
        //}

    }

    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; } // rows
        public int Y { get; } // columns
    }
}
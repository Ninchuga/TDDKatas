using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata.Commands
{
    public class MoveForwardCommand : MoveRoverCommand
    {
        //public MoveForwardCommand(Position position) : base(position)
        //{
        //}

        public override Position Execute(Position currentRoverPosition, Directions currentRoverDirection)
        {
            switch (currentRoverDirection)
            {
                case Directions.North:
                    //position = GetTablePositionFor(_currentPosition);
                    int newNorthPositionX = currentRoverPosition.X - 1;

                    return newNorthPositionX < 0
                        ? new Position(currentRoverPosition.X, currentRoverPosition.Y) //_table[_currentPosition.X, _currentPosition.Y]
                        : new Position(newNorthPositionX, currentRoverPosition.Y); //_table[newPositionX, _currentPosition.Y];

                case Directions.South:
                    //position = GetTablePositionFor(_currentPosition);
                    int newSouthPositionX = currentRoverPosition.X + 1;

                    return newSouthPositionX > 9
                        ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                       : new Position(newSouthPositionX, currentRoverPosition.Y);
                //? _table[_currentPosition.X, _currentPosition.Y]
                //: _table[newSouthPositionX, _currentPosition.Y];

                case Directions.East:

                    //position = GetTablePositionFor(_currentPosition);
                    int newEastPositionY = currentRoverPosition.Y - 1;

                    return newEastPositionY < 0
                        ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                       : new Position(currentRoverPosition.X, newEastPositionY);
                //? _table[_currentPosition.X, _currentPosition.Y]
                //: _table[_currentPosition.X, newEastPositionY];

                case Directions.West:

                    //position = GetTablePositionFor(_currentPosition);
                    int newWestPositionY = currentRoverPosition.Y + 1;

                    return newWestPositionY > 9
                         ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                       : new Position(currentRoverPosition.X, newWestPositionY);
                //? _table[_currentPosition.X, _currentPosition.Y]
                //: _table[_currentPosition.X, newWestPositionY];

                default:
                    return currentRoverPosition;
            }
        }
    }
}

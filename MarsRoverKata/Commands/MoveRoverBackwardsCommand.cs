using System;

namespace MarsRoverKata.Commands
{
    public class MoveRoverBackwardsCommand : MoveRoverCommand
    {
        public override Position Execute(Position currentRoverPosition, Directions currentRoverDirection)
        {
            switch (currentRoverDirection)
            {
                case Directions.North:
                    int newNorthPositionX = currentRoverPosition.X + 1;

                    return GetPosition((newPositionX) => newPositionX > MarsMap.SideMaxLength, Directions.North, newNorthPositionX, currentRoverPosition);

                    //return newNorthPositionX > MarsMap.SideMaxLength
                    //    ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                    //    : new Position(newNorthPositionX, currentRoverPosition.Y);

                case Directions.South:
                    int newSouthPositionX = currentRoverPosition.X - 1;

                    return GetPosition((newPositionX) => newPositionX < MarsMap.SideStartingPoint, Directions.South, newSouthPositionX, currentRoverPosition);

                    //return newSouthPositionX < MarsMap.SideStartingPoint
                    //    ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                    //   : new Position(newSouthPositionX, currentRoverPosition.Y);

                case Directions.East:
                    int newEastPositionY = currentRoverPosition.Y - 1;

                    return GetPosition((newPositionY) => newPositionY < MarsMap.SideStartingPoint, Directions.East, newEastPositionY, currentRoverPosition);

                    //return newEastPositionY < MarsMap.SideStartingPoint
                    //    ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                    //   : new Position(currentRoverPosition.X, newEastPositionY);

                case Directions.West:
                    int newWestPositionY = currentRoverPosition.Y + 1;

                    return GetPosition((newPositionY) => newPositionY > MarsMap.SideMaxLength, Directions.West, newWestPositionY, currentRoverPosition);

                    //return newWestPositionY > MarsMap.SideMaxLength
                    //     ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                    //   : new Position(currentRoverPosition.X, newWestPositionY);

                default:
                    return currentRoverPosition;
            }
        }

        //private Position GetPosition(Func<int, bool> predicate, Directions direction, int newPosition, Position currentRoverPosition)
        //{
        //    if (predicate(newPosition))
        //    {
        //        return new Position(currentRoverPosition.X, currentRoverPosition.Y);
        //    }

        //    return direction == Directions.North || direction == Directions.South
        //        ? new Position(x: newPosition, currentRoverPosition.Y)
        //        : new Position(currentRoverPosition.X, y: newPosition);
        //}
    }
}

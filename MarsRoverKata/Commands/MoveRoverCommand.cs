using System;

namespace MarsRoverKata.Commands
{
    public abstract class MoveRoverCommand
    {
        public abstract Position Execute(Position currentRoverPosition, Directions currentRoverDirection);

        protected Position GetPosition(Func<int, bool> predicate, Directions direction, int newPosition, Position currentRoverPosition)
        {
            if (predicate(newPosition))
            {
                return new Position(currentRoverPosition.X, currentRoverPosition.Y);
            }

            return direction == Directions.North || direction == Directions.South
                ? new Position(x: newPosition, currentRoverPosition.Y)
                : new Position(currentRoverPosition.X, y: newPosition);
        }
    }
}

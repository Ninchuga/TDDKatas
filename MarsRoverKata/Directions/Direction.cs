using System;

namespace MarsRoverKata.Directions
{
    public abstract class Direction
    {
        public abstract Position GetPositionForward(Position currentRoverPosition);
        public abstract Position GetPositionBackward(Position currentRoverPosition);

        protected Position GetPosition(Func<int, bool> predicate, string direction, int newPosition, Position currentRoverPosition)
        {
            if (predicate(newPosition))
            {
                return new Position(currentRoverPosition.X, currentRoverPosition.Y);
            }

            return direction == nameof(North) || direction == nameof(South)
                ? new Position(x: newPosition, currentRoverPosition.Y)
                : new Position(currentRoverPosition.X, y: newPosition);
        }
    }
}

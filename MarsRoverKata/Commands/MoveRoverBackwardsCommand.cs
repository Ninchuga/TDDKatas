namespace MarsRoverKata.Commands
{
    public class MoveRoverBackwardsCommand : MoveRoverCommand
    {
        // As an improvement we could create a separate class for each direction
        public override Position Execute(Position currentRoverPosition, Directions currentRoverDirection)
        {
            switch (currentRoverDirection)
            {
                case Directions.North:
                    int newNorthPositionX = currentRoverPosition.X + 1;

                    return GetPosition((newPositionX) => newPositionX > MarsMap.SideMaxLength, Directions.North, newNorthPositionX, currentRoverPosition);

                case Directions.South:
                    int newSouthPositionX = currentRoverPosition.X - 1;

                    return GetPosition((newPositionX) => newPositionX < MarsMap.SideStartingPoint, Directions.South, newSouthPositionX, currentRoverPosition);

                case Directions.East:
                    int newEastPositionY = currentRoverPosition.Y - 1;

                    return GetPosition((newPositionY) => newPositionY < MarsMap.SideStartingPoint, Directions.East, newEastPositionY, currentRoverPosition);

                case Directions.West:
                    int newWestPositionY = currentRoverPosition.Y + 1;

                    return GetPosition((newPositionY) => newPositionY > MarsMap.SideMaxLength, Directions.West, newWestPositionY, currentRoverPosition);

                default:
                    return currentRoverPosition;
            }
        }
    }
}

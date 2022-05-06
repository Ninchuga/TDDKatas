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

                    return newNorthPositionX > MarsMap.SideMaxLength
                        ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                        : new Position(newNorthPositionX, currentRoverPosition.Y);

                case Directions.South:
                    int newSouthPositionX = currentRoverPosition.X - 1;

                    return newSouthPositionX < MarsMap.SideStartingPoint
                        ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                       : new Position(newSouthPositionX, currentRoverPosition.Y);

                case Directions.East:
                    int newEastPositionY = currentRoverPosition.Y - 1;

                    return newEastPositionY < MarsMap.SideStartingPoint
                        ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                       : new Position(currentRoverPosition.X, newEastPositionY);

                case Directions.West:
                    int newWestPositionY = currentRoverPosition.Y + 1;

                    return newWestPositionY > MarsMap.SideMaxLength
                         ? new Position(currentRoverPosition.X, currentRoverPosition.Y)
                       : new Position(currentRoverPosition.X, newWestPositionY);

                default:
                    return currentRoverPosition;
            }
        }
    }
}

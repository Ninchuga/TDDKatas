namespace MarsRoverKata.Directions
{
    public class West : Direction
    {
        public override Position GetPositionBackward(Position currentRoverPosition)
        {
            int newWestPositionY = currentRoverPosition.Y + 1;

            return GetPosition((newPositionY) => newPositionY > MarsMap.SideMaxLength, nameof(West), newWestPositionY, currentRoverPosition);
        }

        public override Position GetPositionForward(Position currentRoverPosition)
        {
            int newWestPositionY = currentRoverPosition.Y - 1;

            return GetPosition((newPositionY) => newPositionY < MarsMap.SideStartingPoint, nameof(West), newWestPositionY, currentRoverPosition);
        }
    }
}

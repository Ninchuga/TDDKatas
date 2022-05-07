namespace MarsRoverKata.Directions
{
    public class East : Direction
    {
        public override Position GetPositionBackward(Position currentRoverPosition)
        {
            int newEastPositionY = currentRoverPosition.Y - 1;

            return GetPosition((newPositionY) => newPositionY < MarsMap.SideStartingPoint, nameof(East), newEastPositionY, currentRoverPosition);
        }

        public override Position GetPositionForward(Position currentRoverPosition)
        {
            int newEastPositionY = currentRoverPosition.Y + 1;

            return GetPosition((newPositionY) => newPositionY > MarsMap.SideMaxLength, nameof(East), newEastPositionY, currentRoverPosition);
        }
    }
}

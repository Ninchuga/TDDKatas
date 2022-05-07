namespace MarsRoverKata.Directions
{
    public class North : Direction
    {
        public override Position GetPositionBackward(Position currentRoverPosition)
        {
            int newNorthPositionX = currentRoverPosition.X + 1;

            return GetPosition((newPositionX) => newPositionX > MarsMap.SideMaxLength, nameof(North), newNorthPositionX, currentRoverPosition);
        }

        public override Position GetPositionForward(Position currentRoverPosition)
        {
            int newNorthPositionX = currentRoverPosition.X - 1;

            return GetPosition((newPositionX) => newPositionX < MarsMap.SideStartingPoint, nameof(North), newNorthPositionX, currentRoverPosition);
        }
    }
}

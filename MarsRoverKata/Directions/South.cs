namespace MarsRoverKata.Directions
{
    public class South : Direction
    {
        public override Position GetPositionBackward(Position currentRoverPosition)
        {
            int newSouthPositionX = currentRoverPosition.X - 1;

            return GetPosition((newPositionX) => newPositionX < MarsMap.SideStartingPoint, nameof(South), newSouthPositionX, currentRoverPosition);
        }

        public override Position GetPositionForward(Position currentRoverPosition)
        {
            int newSouthPositionX = currentRoverPosition.X + 1;

            return GetPosition((newPositionX) => newPositionX > MarsMap.SideMaxLength, nameof(South), newSouthPositionX, currentRoverPosition);
        }
    }
}

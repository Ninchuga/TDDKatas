using MarsRoverKata.Directions;

namespace MarsRoverKata.Commands
{
    public class MoveRoverForwardCommand : MoveRoverCommand
    {
        public override Position Execute(Position currentRoverPosition, Direction currentRoverDirection)
        {
            return currentRoverDirection.GetPositionForward(currentRoverPosition);
        }
    }
}

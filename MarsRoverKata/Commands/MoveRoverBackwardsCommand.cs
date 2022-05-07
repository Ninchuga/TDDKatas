using MarsRoverKata.Directions;

namespace MarsRoverKata.Commands
{
    public class MoveRoverBackwardsCommand : MoveRoverCommand
    {
        public override Position Execute(Position currentRoverPosition, Direction currentRoverDirection)
        {
            return currentRoverDirection.GetPositionBackward(currentRoverPosition);
        }
    }
}

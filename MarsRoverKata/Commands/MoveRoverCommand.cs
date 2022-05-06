namespace MarsRoverKata.Commands
{
    public abstract class MoveRoverCommand
    {
        //public MoveRoverCommand(Position position)
        //{
        //    RoverPosition = position;
        //}

        //public Position RoverPosition { get; }

        public abstract Position Execute(Position currentRoverPosition, Directions currentRoverDirection);
    }
}

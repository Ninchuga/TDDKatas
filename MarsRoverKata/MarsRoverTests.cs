using FluentAssertions;
using MarsRoverKata.Commands;
using Xunit;

namespace MarsRoverKata
{
    public class MarsRoverTests
    {
        [Fact]
        public void ShouldMoveRoverForwardNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);
            
            rover.AddCommand(new MoveRoverForwardCommand()).ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(4);
            rover.CurrentPosition.Y.Should().Be(5);
        }

        [Fact]
        public void ShouldStayInTheLastMapPositionWhenTheNextMoveForwardIsOutOfTheMapBorderMovingNorth()
        {
            var rover = new Rover(new Position(x: 1, y: 5), Directions.North);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(1);
            rover.CurrentPosition.Y.Should().Be(5);
        }

        [Fact]
        public void ShouldMoveRoverForwardSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);
            
            rover.AddCommand(new MoveRoverForwardCommand()).ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(6);
            rover.CurrentPosition.Y.Should().Be(5);
        }

        [Fact]
        public void ShouldMoveRoverForwardEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);
           
            rover.AddCommand(new MoveRoverForwardCommand()).ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(6);
        }

        [Fact]
        public void ShouldStayInTheLastMapPositionWhenTheNextMoveForwardIsOutOfTheMapBorderMovingEast()
        {
            var rover = new Rover(new Position(x: 5, y: 9), Directions.East);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(10);
        }

        [Fact]
        public void ShouldMoveRoverForwardWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.AddCommand(new MoveRoverForwardCommand()).ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(4);
        }

        [Fact]
        public void ShouldTurnRoverLeftToWestWhenOnNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            var currentDirection = rover.TurnLeft();

            currentDirection.Should().Be(Directions.West);
        }

        [Fact]
        public void ShouldTurnRoverLeftToSouthWhenOnWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            var currentDirection = rover.TurnLeft();

            currentDirection.Should().Be(Directions.South);
        }

        [Fact]
        public void ShouldTurnRoverLeftToEastWhenOnSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            var currentDirection = rover.TurnLeft();

            currentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShouldTurnRoverLeftToNorthWhenOnEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            var currentDirection = rover.TurnLeft();

            currentDirection.Should().Be(Directions.North);
        }

        [Fact]
        public void ShouldTurnRoverRightToEastWhenOnNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            var currentDirection = rover.TurnRight();

            currentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShouldTurnRoverRightToSouthWhenOnEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            var currentDirection = rover.TurnRight();

            currentDirection.Should().Be(Directions.South);
        }

        [Fact]
        public void ShouldTurnRoverRightToWestWhenOnSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            var currentDirection = rover.TurnRight();

            currentDirection.Should().Be(Directions.West);
        }

        [Fact]
        public void ShouldTurnRoverRightToNorthWhenOnWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            var currentDirection = rover.TurnRight();

            currentDirection.Should().Be(Directions.North);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            rover.AddCommand(new MoveRoverBackwardsCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(3);
            rover.CurrentPosition.Y.Should().Be(5);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.AddCommand(new MoveRoverBackwardsCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(7);
            rover.CurrentPosition.Y.Should().Be(5);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            rover.AddCommand(new MoveRoverBackwardsCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(3);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.AddCommand(new MoveRoverBackwardsCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(7);
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingWestForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(3);
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingEastForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(7);
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingNorthForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(3);
            rover.CurrentPosition.Y.Should().Be(5);
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingSouthForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(7);
            rover.CurrentPosition.Y.Should().Be(5);
        }
    }
}

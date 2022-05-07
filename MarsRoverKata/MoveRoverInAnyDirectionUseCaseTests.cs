using FluentAssertions;
using MarsRoverKata.Commands;
using Xunit;

namespace MarsRoverKata
{
    public class MoveRoverInAnyDirectionUseCaseTests
    {
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

        [Fact]
        public void ShoudMoveForwardInNorthDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();
            rover
                .TurnRight()
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(3);
            rover.CurrentPosition.Y.Should().Be(7);
            rover.CurrentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShoudMoveForwardInWestDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();
            rover
                .TurnRight()
                .TurnRight()
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(4);
            rover.CurrentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShoudMoveBackwardsInNorthDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.AddCommand(new MoveRoverBackwardsCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();
            rover
                .TurnRight()
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(7);
            rover.CurrentPosition.Y.Should().Be(7);
            rover.CurrentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShoudMoveBackwardsInWestDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.AddCommand(new MoveRoverBackwardsCommand())
                .AddCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommands();
            rover
                .TurnRight()
                .TurnRight()
                .AddCommand(new MoveRoverForwardCommand())
                .AddCommand(new MoveRoverForwardCommand())
                .ExecuteCommands();

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(9);
            rover.CurrentDirection.Should().Be(Directions.East);
        }
    }
}

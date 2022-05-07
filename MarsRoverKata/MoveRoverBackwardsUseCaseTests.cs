using FluentAssertions;
using MarsRoverKata.Commands;
using Xunit;

namespace MarsRoverKata
{
    public class MoveRoverBackwardsUseCaseTests
    {
        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            rover.ExecuteCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(3);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().Be(Directions.South);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.ExecuteCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(7);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().Be(Directions.North);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            rover.ExecuteCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(3);
            rover.CurrentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShouldMoveRoverBackwardsWhenDirectionIsWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.ExecuteCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(7);
            rover.CurrentDirection.Should().Be(Directions.West);
        }

    }
}

using FluentAssertions;
using Xunit;

namespace MarsRoverKata
{
    public class TurnRoverUseCaseTests
    {
        [Fact]
        public void ShouldTurnRoverLeftToWestWhenOnNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.TurnLeft();

            rover.CurrentDirection.Should().Be(Directions.West);
        }

        [Fact]
        public void ShouldTurnRoverLeftToSouthWhenOnWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.TurnLeft();

            rover.CurrentDirection.Should().Be(Directions.South);
        }

        [Fact]
        public void ShouldTurnRoverLeftToEastWhenOnSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            rover.TurnLeft();

            rover.CurrentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShouldTurnRoverLeftToNorthWhenOnEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            rover.TurnLeft();

            rover.CurrentDirection.Should().Be(Directions.North);
        }

        [Fact]
        public void ShouldTurnRoverRightToEastWhenOnNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.North);

            rover.TurnRight();

            rover.CurrentDirection.Should().Be(Directions.East);
        }

        [Fact]
        public void ShouldTurnRoverRightToSouthWhenOnEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.East);

            rover.TurnRight();

            rover.CurrentDirection.Should().Be(Directions.South);
        }

        [Fact]
        public void ShouldTurnRoverRightToWestWhenOnSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.South);

            rover.TurnRight();

            rover.CurrentDirection.Should().Be(Directions.West);
        }

        [Fact]
        public void ShouldTurnRoverRightToNorthWhenOnWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), Directions.West);

            rover.TurnRight();

            rover.CurrentDirection.Should().Be(Directions.North);
        }
    }
}

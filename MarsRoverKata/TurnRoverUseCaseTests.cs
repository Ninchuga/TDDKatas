using FluentAssertions;
using MarsRoverKata.Directions;
using Xunit;

namespace MarsRoverKata
{
    public class TurnRoverUseCaseTests
    {
        [Fact]
        public void ShouldTurnRoverLeftToWestWhenOnNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new North());

            rover.TurnLeft();

            rover.CurrentDirection.Should().BeOfType(typeof(West));
        }

        [Fact]
        public void ShouldTurnRoverLeftToSouthWhenOnWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new West());

            rover.TurnLeft();

            rover.CurrentDirection.Should().BeOfType(typeof(South));
        }

        [Fact]
        public void ShouldTurnRoverLeftToEastWhenOnSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new South());

            rover.TurnLeft();

            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShouldTurnRoverLeftToNorthWhenOnEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new East());

            rover.TurnLeft();

            rover.CurrentDirection.Should().BeOfType(typeof(North));
        }

        [Fact]
        public void ShouldTurnRoverRightToEastWhenOnNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new North());

            rover.TurnRight();

            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShouldTurnRoverRightToSouthWhenOnEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new East());

            rover.TurnRight();

            rover.CurrentDirection.Should().BeOfType(typeof(South));
        }

        [Fact]
        public void ShouldTurnRoverRightToWestWhenOnSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new South());

            rover.TurnRight();

            rover.CurrentDirection.Should().BeOfType(typeof(West));
        }

        [Fact]
        public void ShouldTurnRoverRightToNorthWhenOnWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new West());

            rover.TurnRight();

            rover.CurrentDirection.Should().BeOfType(typeof(North));
        }
    }
}

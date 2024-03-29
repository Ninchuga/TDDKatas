﻿using FluentAssertions;
using MarsRoverKata.Commands;
using MarsRoverKata.Directions;
using Xunit;

namespace MarsRoverKata
{
    public class MoveRoverForwardUseCaseTests
    {
        [Fact]
        public void ShouldMoveRoverForwardNorth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new North());

            rover.ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(4);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().BeOfType(typeof(North));
        }

        [Fact]
        public void ShouldStayInTheLastMapPositionWhenTheNextMoveForwardIsOutOfTheMapBorderMovingNorth()
        {
            var rover = new Rover(new Position(x: 1, y: 5), new North());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(1);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().BeOfType(typeof(North));
        }

        [Fact]
        public void ShouldMoveRoverForwardSouth()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new South());

            rover.ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(6);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().BeOfType(typeof(South));
        }

        [Fact]
        public void ShouldMoveRoverForwardEast()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new East());

            rover.ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(6);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShouldStayInTheLastMapPositionWhenTheNextMoveForwardIsOutOfTheMapBorderMovingEast()
        {
            var rover = new Rover(new Position(x: 5, y: 9), new East());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(10);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShouldMoveRoverForwardWest()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new West());

            rover.ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(4);
            rover.CurrentDirection.Should().BeOfType(typeof(West));
        }
    }
}

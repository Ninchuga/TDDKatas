﻿using FluentAssertions;
using MarsRoverKata.Commands;
using MarsRoverKata.Directions;
using Xunit;

namespace MarsRoverKata
{
    public class MoveRoverInAnyDirectionUseCaseTests
    {
        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingWestForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new West());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(3);
            rover.CurrentDirection.Should().BeOfType(typeof(West));
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingEastForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new East());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(7);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingNorthForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new North());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(3);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().BeOfType(typeof(North));
        }

        [Fact]
        public void ShouldGiveYouValidPositionWhenMovingSouthForwardAndBackwards()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new South());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand());

            rover.CurrentPosition.X.Should().Be(7);
            rover.CurrentPosition.Y.Should().Be(5);
            rover.CurrentDirection.Should().BeOfType(typeof(South));
        }

        [Fact]
        public void ShoudMoveForwardInNorthDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new North());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .TurnRight()
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(3);
            rover.CurrentPosition.Y.Should().Be(7);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShoudMoveForwardInWestDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new West());

            rover.ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand())
                .TurnRight()
                .TurnRight()
                .ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(4);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShoudMoveBackwardsInNorthDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new North());

            rover.ExecuteCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand())
                .TurnRight()
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(7);
            rover.CurrentPosition.Y.Should().Be(7);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }

        [Fact]
        public void ShoudMoveBackwardsInWestDirectionAndThenTurnToEastAndMoveForward()
        {
            var rover = new Rover(new Position(x: 5, y: 5), new West());

            rover.ExecuteCommand(new MoveRoverBackwardsCommand())
                .ExecuteCommand(new MoveRoverBackwardsCommand())
                .TurnRight()
                .TurnRight()
                .ExecuteCommand(new MoveRoverForwardCommand())
                .ExecuteCommand(new MoveRoverForwardCommand());

            rover.CurrentPosition.X.Should().Be(5);
            rover.CurrentPosition.Y.Should().Be(9);
            rover.CurrentDirection.Should().BeOfType(typeof(East));
        }
    }
}

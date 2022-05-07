using FluentAssertions;
using MarsRoverKata.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarsRoverKata
{
    public class MoveRoverBackwardsUseCaseTests
    {
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

    }
}

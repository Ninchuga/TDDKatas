using MarsRoverKata.Commands;
using System.Collections.Generic;

namespace MarsRoverKata
{
    internal class Rover
    {
        private Position _currentPosition;
        private Directions _currentDirection;
        private List<MoveRoverCommand> _commands;

        public Rover(Position startingPosition, Directions startingDirection)
        {
            _currentPosition = startingPosition;
            _currentDirection = startingDirection;
            _commands = new List<MoveRoverCommand>();
        }

        public Position CurrentPosition => _currentPosition;

        public Rover AddCommand(MoveRoverCommand command)
        {
            _commands.Add(command);

            return this;
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                _currentPosition = command.Execute(_currentPosition, _currentDirection);
            }
        }

        internal Directions TurnLeft()
        {
            switch (_currentDirection)
            {
                case Directions.North:
                    return Directions.West;
                case Directions.South:
                    return Directions.East;
                case Directions.East:
                    return Directions.North;
                case Directions.West:
                    return Directions.South;
                default:
                    return Directions.North;
            }
        }

        internal Directions TurnRight()
        {
            switch (_currentDirection)
            {
                case Directions.North:
                    return Directions.East;
                case Directions.South:
                    return Directions.West;
                case Directions.East:
                    return Directions.South;
                case Directions.West:
                    return Directions.North;
                default:
                    return Directions.North;
            }
        }
    }
}
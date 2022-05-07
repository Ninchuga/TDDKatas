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
        public Directions CurrentDirection => _currentDirection;

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

            _commands.Clear();
        }

        internal Rover TurnLeft()
        {
            switch (_currentDirection)
            {
                case Directions.North:
                    _currentDirection = Directions.West;
                    break;
                case Directions.South:
                    _currentDirection = Directions.East;
                    break;
                case Directions.East:
                    _currentDirection = Directions.North;
                    break;
                case Directions.West:
                    _currentDirection = Directions.South;
                    break;
                default:
                    _currentDirection = Directions.North;
                    break;
            }

            return this;
        }

        internal Rover TurnRight()
        {
            switch (_currentDirection)
            {
                case Directions.North:
                    _currentDirection = Directions.East;
                    break;
                case Directions.South:
                    _currentDirection = Directions.West;
                    break;
                case Directions.East:
                    _currentDirection = Directions.South;
                    break;
                case Directions.West:
                    _currentDirection = Directions.North;
                    break;
                default:
                    _currentDirection = Directions.North;
                    break;
            }

            return this;
        }
    }
}
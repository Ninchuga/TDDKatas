using MarsRoverKata.Commands;
using MarsRoverKata.Directions;
using System.Collections.Generic;

namespace MarsRoverKata
{
    internal class Rover
    {
        private Position _currentPosition;
        private Direction _currentDirection;
        //private List<MoveRoverCommand> _commands;

        public Rover(Position startingPosition, Direction startingDirection)
        {
            _currentPosition = startingPosition;
            _currentDirection = startingDirection;
            //_commands = new List<MoveRoverCommand>();
        }

        public Position CurrentPosition => _currentPosition;
        public Direction CurrentDirection => _currentDirection;

        public Rover ExecuteCommand(MoveRoverCommand command)
        {
            _currentPosition = command.Execute(_currentPosition, _currentDirection);

            return this;
        }

        //public Rover AddCommand(MoveRoverCommand command)
        //{
        //    _commands.Add(command);

        //    return this;
        //}

        //public void ExecuteCommands()
        //{
        //    foreach (var command in _commands)
        //    {
        //        _currentPosition = command.Execute(_currentPosition, _currentDirection);
        //    }

        //    _commands.Clear();
        //}

        internal Rover TurnLeft()
        {
            switch (_currentDirection.GetType().Name)
            {
                case nameof(North):
                    _currentDirection = new West();
                    break;
                case nameof(South):
                    _currentDirection = new East();
                    break;
                case nameof(East):
                    _currentDirection = new North();
                    break;
                case nameof(West):
                    _currentDirection = new South();
                    break;
                default:
                    _currentDirection = new North();
                    break;
            }

            return this;
        }

        internal Rover TurnRight()
        {
            switch (_currentDirection.GetType().Name)
            {
                case nameof(North):
                    _currentDirection = new East();
                    break;
                case nameof(South):
                    _currentDirection = new West();
                    break;
                case nameof(East):
                    _currentDirection = new South();
                    break;
                case nameof(West):
                    _currentDirection = new North();
                    break;
                default:
                    _currentDirection = new North();
                    break;
            }

            return this;
        }
    }
}
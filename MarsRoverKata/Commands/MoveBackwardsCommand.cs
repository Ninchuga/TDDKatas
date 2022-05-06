using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKata.Commands
{
    public class MoveBackwardsCommand : MoveRoverCommand
    {
        //public MoveBackwardsCommand(Position position) : base(position)
        //{
        //}

        public override Position Execute(Position currentRoverPosition, Directions currentRoverDirection)
        {
            throw new NotImplementedException();
        }
    }
}

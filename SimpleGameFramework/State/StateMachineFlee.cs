using SimpleGameFramework.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.State
{
    public class StateMachineFlee : IStateMachinePattern
    {
        // This would turn off the game.
        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.F: return this;
            }

            return this;
        }

        public GameStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.F: return GameStatesTypes.FLEE;
            }

            return GameStatesTypes.FLEE;
        }
    }
}

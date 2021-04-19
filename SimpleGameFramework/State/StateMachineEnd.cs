using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.State
{
    public class StateMachineEnd : IStateMachinePattern
    {
        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                default: return new StateMachineEnd();

            }


        }

        public GameStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                // Have to research here on how to make the game stop here if this would happen.
                //default: return false;
                default: return GameStatesTypes.END;
            }
        }
    }
}

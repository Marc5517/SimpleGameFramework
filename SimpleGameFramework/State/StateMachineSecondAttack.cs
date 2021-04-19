using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.State
{
    public class StateMachineSecondAttack:IStateMachinePattern
    {
        private static readonly IStateMachinePattern START = new StateMachineStart();

        // The logic in this should be that we can only choose the next command, where we go back to start, and if we do not apply, the game will report it as a mistake.
        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.S: return START;
                default: return new StateMachineEnd();
            }
        }

        public GameStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.S: return GameStatesTypes.START;
                // Not completely right here yet.
                default: return GameStatesTypes.END;
            }
        }
    }
}

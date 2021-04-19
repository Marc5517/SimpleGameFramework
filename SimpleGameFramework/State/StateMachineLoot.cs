using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.State
{
    public class StateMachineLoot:IStateMachinePattern
    {
        private static readonly IStateMachinePattern SECONDATTACK = new StateMachineSecondAttack();

        // The logic in this should be that we can only choose the next command, and if we do not apply, the game will report it as a mistake.
        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.A2: return SECONDATTACK;
                default: return new StateMachineEnd();
            }
        }

        public GameStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.A2: return GameStatesTypes.SECONDATTACK;
                // Not completely right here yet.
                default: return GameStatesTypes.END;
            }
        }
    }
}

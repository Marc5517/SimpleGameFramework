using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.State
{
    public class StateMachineStart:IStateMachinePattern
    {
        private static readonly IStateMachinePattern FIRSTATTACK = new StateMachineFirstAttack();
        private static readonly IStateMachinePattern LOOT = new StateMachineLoot();
        private static readonly IStateMachinePattern FLEE = new StateMachineFlee();

        // The logic in this should be that we can only choose these three commands, and if we pick the wrong one, the game will report as mistake.
        public IStateMachinePattern NextState(InputType input)
        {
            switch (input)
            {
                case InputType.A1: return FIRSTATTACK;
                case InputType.L: return LOOT;
                case InputType.F: return FLEE;
                default: return new StateMachineEnd();
            }
        }

        public GameStatesTypes NextAction(InputType input)
        {
            switch (input)
            {
                case InputType.A1: return GameStatesTypes.FIRSTATTACK;
                case InputType.L: return GameStatesTypes.LOOT;
                case InputType.F: return GameStatesTypes.FLEE;
                // Not completely right here yet.
                default: return GameStatesTypes.END;
            }
        }
    }
}

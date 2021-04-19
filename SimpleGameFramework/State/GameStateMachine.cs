using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.State
{
    public class GameStateMachine:IState
    {
        private IStateMachinePattern _currentState;

        // This shows that we're starting the game at Start.
        public GameStateMachine()
        {
            _currentState = new StateMachineStart();
        }

        public GameStatesTypes NextMove(InputType input)
        {
            GameStatesTypes nextMove = _currentState.NextAction(input);
            _currentState = _currentState.NextState(input);
            return nextMove;
        }
    }
}

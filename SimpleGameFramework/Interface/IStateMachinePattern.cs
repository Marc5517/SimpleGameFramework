using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Interface
{
    public interface IStateMachinePattern
    {
        IStateMachinePattern NextState(InputType input);
        GameStatesTypes NextAction(InputType input);
    }
}

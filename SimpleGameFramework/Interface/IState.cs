using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Interface
{
    public enum GameStatesTypes
    {
        START,
        FIRSTATTACK,
        SECONDATTACK,
        LOOT,
        FLEE,
        END // In doubt about during this last part
    };

    public enum InputType
    {
        S,
        A1,
        A2,
        L,
        F
    }

    public interface IState
    {
        GameStatesTypes NextMove(InputType input);
    }
}

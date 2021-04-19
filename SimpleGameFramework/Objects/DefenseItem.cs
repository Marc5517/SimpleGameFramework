using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;
using SimpleGameFramework.Objects.Base;

namespace SimpleGameFramework.Objects
{
    public class DefenceItem : WorldObject
    {
        private int _reduceHitpoint;

        public DefenceItem(string name, int reduceHitpoint, bool lootable, bool removable, Position oPosition, ITrace iTrace) : base(name, lootable, removable, oPosition, iTrace)
        {
            _reduceHitpoint = reduceHitpoint;
        }

        public int ReduceHitpoint
        {
            get { return _reduceHitpoint; }
            set { _reduceHitpoint = value; }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(ReduceHitpoint)}: {_reduceHitpoint}, {nameof(Lootable)}: {Lootable}, {nameof(Removable)}: {Removable}";
        }
    }
}

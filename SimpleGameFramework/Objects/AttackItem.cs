using SimpleGameFramework.Interface;
using SimpleGameFramework.Objects.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Objects
{
    public class AttackItem : WorldObject
    {
        private int _hitpoint;
        private int _range;

        public AttackItem(string name, int hitpoint, int range, bool lootable, bool removable, Position oPosition, ITrace iTrace) : base(name, lootable, removable, oPosition, iTrace)
        {
            _hitpoint = hitpoint;
            _range = range;
        }

        public int Hitpoint
        {
            get { return _hitpoint; }
            set { _hitpoint = value; }
        }

        public int Range
        {
            get { return _range; }
            set { _range = value; }
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Hitpoint)}: {_hitpoint}, {nameof(Range)}: {_range}, {nameof(Lootable)}: {Lootable}, {nameof(Removable)}: {Removable}";
        }
    }
}

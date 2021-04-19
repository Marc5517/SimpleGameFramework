using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Interface;

namespace SimpleGameFramework.Objects.Base
{
    public class WorldObject : IWorldObject
    {
        public string Name { get; }
        private bool _lootable;
        private bool _removable;
        private Position OPosition { get; }
        private ITrace _iTrace;


        public WorldObject(string name, bool lootable, bool removable, Position oPosition, ITrace iTrace)
        {
            Name = name;
            _iTrace = iTrace;
            Lootable = lootable;
            Removable = removable;
            OPosition = oPosition;
        }

        public bool Lootable
        {
            get { return _lootable; }
            set
            {
                _lootable = value;
                if (_lootable != true)
                {
                    _iTrace.TraceEvent("This Item: " + Name + " is not lootable");
                }
            }
        }

        public bool Removable
        {
            get { return _removable; }
            set
            {
                _removable = value;
                if (_removable)
                {
                    _iTrace.TraceEvent("This Item: " + Name + " is removable");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using SimpleGameFramework.Lists;
using SimpleGameFramework.Objects.Base;

namespace SimpleGameFramework
{
    public class World
    {
        private int _maxX;
        private int _maxY;
        // Those two last ones would've been used for a bigger project.
        private CreatureList _creatureList;
        private WorldObjectList _worldObjectList;

        public World(int maxX, int maxY)
        {
            _maxX = maxX;
            _maxY = maxY;
        }

        public int MaxX
        {
            get { return _maxX; }
            set { _maxX = value; }
        }

        public int MaxY
        {
            get { return _maxY; }
            set { _maxY = value; }
        }

        public override string ToString()
        {
            return $"{nameof(MaxX)}: {_maxX}, {nameof(MaxY)}: {_maxY}";
        }

    }
}

using SimpleGameFramework.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SimpleGameFramework.Interface;
using SimpleGameFramework.Lists;
using SimpleGameFramework.Objects.Base;
using System.Linq;

namespace SimpleGameFramework
{
    public class Creature
    {
        private string _name;
        private PositiveInt _hitpoint;
        private int _power;
        private int _defensePower;
        public Position CPosition { get; }
        private ITrace _iTrace;
        private WorldObjectList _worldObjectList;

        public Creature(string name, PositiveInt hitpoint, int power, int defensePower, ITrace iTrace, Position cPosition)
        {
            _name = name;
            _iTrace = iTrace;
            Hitpoint = hitpoint;
            _power = power;
            _defensePower = defensePower;
            CPosition = cPosition;
            _worldObjectList = new WorldObjectList();
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public PositiveInt Hitpoint
        {
            get { return _hitpoint; }
            set
            {
                _hitpoint = value;
                if (_hitpoint.Value == 0)
                {
                    _iTrace.TraceEvent("This creature: " + Name + " is dead");
                }
            }
        }

        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public int DefensePower
        {
            get { return _defensePower; }
            set { _defensePower = value; }
        }

        // This method uses a inflicts damage on a creature based on power of the creature who uses this method.
        public int Hit()
        {
            return Power;
        }

        // This method makes it possible for a creature to loot an attackitem.
        // If the item is lootable, then it's power is increased by the item's hitpoint and it's added to the list. 
        // If the Item is removable, then the item will lose the power it was increased with and it will be removed from the list.
        public void LootAttackItem(AttackItem aI)
        {
            if (aI.Lootable)
            {
                _power = _power + aI.Hitpoint;
                _worldObjectList.Add(aI);
                if (aI.Removable)
                {
                    _power = _power - aI.Hitpoint;
                    _worldObjectList.Remove(aI);
                }
            }
        }

        // It works the same way as LootAttackItem, but it increases the Defence Power instead.
        public void LootDefenseItem(DefenceItem dI)
        {
            if (dI.Lootable)
            {
                _defensePower = _defensePower + dI.ReduceHitpoint;
                _worldObjectList.Add(dI);
                if (dI.Removable)
                {
                    _defensePower = _defensePower - dI.ReduceHitpoint;
                    _worldObjectList.Remove(dI);
                }
            }
        }

        // When the method Hit had been used, this method makes it possible for the creature to receive the hit.
        public void ReceiveHit(int Power)
        {
            Hitpoint = Hitpoint - (Power - _defensePower);
        }

        public override string ToString()
        {
            // LINQ is used here right before ToString, so that we can get info about which items the creature has on him/her.
            var arsenal = string.Join("\n", from wol in _worldObjectList.ObjectList select wol.ToString());
            return $"{nameof(Name)}: {_name}, {nameof(Hitpoint)}: {_hitpoint}, " +
                   $"{nameof(Power)}: {_power}, {nameof(DefensePower)}: {_defensePower}, " +
                   $"{nameof(WorldObjectList)}: {_worldObjectList.Count}. \n Arsenal: {arsenal}";
        }
    }
}

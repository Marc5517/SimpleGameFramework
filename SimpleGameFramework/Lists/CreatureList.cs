using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework.Lists
{
    public class CreatureList : ListTemplate<Creature>
    {
        protected override ICollection<Creature> CreateCollection()
        {
            return new List<Creature>();
        }
    }
}

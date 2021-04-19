using System;
using System.Collections.Generic;
using System.Text;
using SimpleGameFramework.Objects.Base;

namespace SimpleGameFramework.Lists
{
    public class WorldObjectList : ListTemplate<WorldObject>
    {
        protected override ICollection<WorldObject> CreateCollection()
        {
            return new List<WorldObject>();
        }
    }
}

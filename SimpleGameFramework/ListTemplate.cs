using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameFramework
{
    public abstract class ListTemplate <T>
    {
        // This temnplate class makes it possible to create a list containing a specific object.

        private ICollection<T> _objectList;

        public ListTemplate()
        {
            _objectList = CreateCollection();
        }

        public ICollection<T> ObjectList => _objectList;

        protected abstract ICollection<T> CreateCollection();

        // This method adds items to a list.
        public void Add(T item)
        {
            _objectList.Add(item);
        }

        // This method removes items from the list.
        public bool Remove(T item)
        {
            return _objectList.Remove(item);
        }

        // This method counts the exact number of items the list contains.
        public int Count => _objectList.Count;
    }
}

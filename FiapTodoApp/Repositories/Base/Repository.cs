using FiapTodoApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapTodoApp.Repositories.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private List<T> _items = new List<T>();
        public List<T> Items
        {
            protected set { _items = value; }
            get { return _items; }
        }

        public abstract void LoadAll();
    }
}

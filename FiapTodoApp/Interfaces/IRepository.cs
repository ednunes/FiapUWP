﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapTodoApp.Interfaces
{
    public interface IRepository<T>
    {
        void LoadAll();
    }
}

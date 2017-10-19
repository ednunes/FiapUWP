using FiapTodoApp.Models;
using FiapTodoApp.Repositories.Base;
using System;
using System.Collections.Generic;

namespace FiapTodoApp.Repositories
{
    public class MockCategoryRepository : Repository<Category>
    {
        private static readonly Lazy<MockCategoryRepository> _instance =
                new Lazy<MockCategoryRepository>(() => new MockCategoryRepository());

        public static MockCategoryRepository Instance { get { return _instance.Value; } }

        public override void LoadAll()
        {
            if (Items.Count == 0)
            {
                var categories = new List<Category>()
                {
                new Category {Color = "Black", Description = "Pessoal", Id = Guid.NewGuid().ToString() },
                new Category {Color = "Red", Description = "Família", Id = Guid.NewGuid().ToString() },
                new Category {Color = "Lime", Description = "Trabalho", Id = Guid.NewGuid().ToString() },
                };

                categories.ForEach(c => Items.Add(c));
            }
        }
    }

}

using FiapTodoApp.Models;
using FiapTodoApp.Repositories.Base;
using System;
using System.Collections.Generic;

namespace FiapTodoApp.Repositories
{
    public class MockTodoItemRepository : Repository<TodoItem>
    {
        private static readonly Lazy<MockTodoItemRepository> _instance =
                new Lazy<MockTodoItemRepository>(() => new MockTodoItemRepository());

        public static MockTodoItemRepository Instance { get { return _instance.Value; } }

        private MockCategoryRepository CategoryRepository => MockCategoryRepository.Instance;

        public override void LoadAll()
        {
            if (Items.Count == 0)
            {
                var todoItems = new List<TodoItem>()
            {
                new TodoItem {Id = Guid.NewGuid().ToString(), Category = CategoryRepository.Items[1],
                    Details = "", Title = "Ir a padaria" },
                new TodoItem {Id = Guid.NewGuid().ToString(), Category = CategoryRepository.Items[2],
                    Details = "Andar 10 - Sala 5", Title = "Reunião com a equipe" },
                new TodoItem {Id = Guid.NewGuid().ToString(), Category = CategoryRepository.Items[2],
                    Details = "Pendências do projeto", Title = "Ligar para o João" },
            };

                todoItems.ForEach(t => Items.Add(t));
            }
        }
    }

}

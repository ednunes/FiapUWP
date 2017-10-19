using FiapTodoApp.Models;
using FiapTodoApp.Repositories;
using System.Collections.Generic;

namespace FiapTodoApp.ViewModels
{
    public class MainPageViewModel
    {
        public MockCategoryRepository CategoryRepository { get; private set; } = MockCategoryRepository.Instance;
        public MockTodoItemRepository TodoItemRepository { get; private set; } = MockTodoItemRepository.Instance;

        public List<Category> Categories => CategoryRepository.Items;
        public List<TodoItem> TodoItems => TodoItemRepository.Items;

        public MainPageViewModel()
        {
            CategoryRepository.LoadAll();
            TodoItemRepository.LoadAll();
        }
    }
}

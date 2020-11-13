using System.Collections.Generic;
using System;

namespace TodoItem
{
    public interface ITodoItemRepository
    {
        IEnumerable<TodoItem> getAll ();

        TodoItem getById(Guid Id);

        TodoItem add(TodoItem todo); 

        TodoItem remove(Guid Id);

        void update (TodoItem todo);
    }
}
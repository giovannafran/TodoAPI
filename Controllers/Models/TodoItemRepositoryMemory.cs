using System;
using System.Collections.Generic;
using System.Collections.Concurrent;


namespace TodoAPI
{
    public class TodoItemRepositoryMemory : ITodoItemRepository

    {   private readonly ConcurrentDictionary<Guid,TodoItem> data = new ConcurrentDictionary<Guid,TodoItem> ();

        public TodoItem add(TodoItem todo)
        {
            ToDo.Id = Guid.NewGuid();
            if(data.TryAdd(todo.Id, todo))
            {
                return todo; //  se nao conseguir retornar é sempre importante relatar o problema.
            }
            throw new Exception("Falha de Insercao"); //excessao para problemas, caso eu nao consiga adicionar.
        }

        public IEnumerable<TodoItem> getAll()
        {
            return data.Values;
        }

        public TodoItem getById (Guid Id)
        {
            throw new NotImplementException();
        }

        public void remove (Guid Id)
        {
            throw new NotImplementException();
        }

        public void update (TodoItem todo)
        {
            throw new NotImplementException();
        }






    }
}
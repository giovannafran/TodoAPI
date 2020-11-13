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
            return data.Values; // retornar os valores
        }

        public TodoItem getById (Guid Id)
        {
            TodoItem TodoItem; // declarei a variável // nao ocnsegui usar VAR para declarar, tive q usar o tipo específico.
            data.TryGetValue(Id, out TodoItem); // mandei buscar os dados dela //TodoItem passando como referencia
            return TodoItem;
        }

        public TodoItem remove (Guid Id)
        {
            TodoItem TodoItem;
            data.TryRemove(Id, out TodoItem); // remocao
            return TodoItem; // retornei quem foi removido


        }

        public void update (TodoItem todo)
        {
            //data.TryUpdate(todo.Id,todo,todo); // "nesta chave tem q conter elemento 3, pois vou alterar p elemento 2" // esse metodo esta mandando um novo todoitem, esse codigo nao é o correto quando falamos de implementação.
            data[todo.Id] = todo;
        }






    }
}
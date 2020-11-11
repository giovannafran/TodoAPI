using System;

namespace TodoAPI
{
    public class TodoItem // classe q representa dados
    {
        public Guid Id {get;set;} // Guid vai gerar um identificador unico com muitos BITS
        public String Name {get;set;}
        public String Description {get;set;}
        public bool IsComplete {get;set;}
    }
}
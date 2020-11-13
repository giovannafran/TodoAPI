using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TodoAPI.Controllers
{
    [ApiController]
    [Route("api/TodoItems")] //variaveis pre definidas
    public class ToDoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ToDoController> _logger;

        private readonly ITodoItemRepository _repository;

        public ToDoController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        
    }
}

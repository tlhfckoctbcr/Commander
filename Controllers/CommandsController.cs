using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
  // Using /[controller] uses the controller name for the route.
  [Route("api/[controller]")]
  [ApiController]
  public class CommandsController: ControllerBase
  {
    private readonly MockCommanderRepo _repository = new MockCommanderRepo();
    // GET api/commands
    [HttpGet]
    public ActionResult <IEnumerable<Command>> GetAllCommands()
    {
      var commandItems = _repository.GetAllCommands();
      return Ok(commandItems);
    }

    // GET api/commands/{id}
    [HttpGet("{id}")]
    public ActionResult <Command> GetCommandById(int id)
    {
      var commandItem = _repository.GetCommandById(id);
      return Ok(commandItem);
    }
  }
}

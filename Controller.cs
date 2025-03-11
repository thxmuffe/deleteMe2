using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// [Controller] class attribute merkkaa käännösvaiheessa (dotnet build)
[ApiController]
[Route("api")]

// 1. pitäisi olla public
// 2. pitäisi periä ControllerBase
// 3. pitäisi olla namespace määritetty

public class Controller {

[HttpGet]
public async Task<ActionResult<string>> GetGreeting() {
        return
            "Beep boop! Greetings, carbon-based lifeform!"
            + " May your circuits stay cool"
            + " and your snacks stay plentiful today!";
    }

}

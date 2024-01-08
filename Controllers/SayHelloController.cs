using Microsoft.AspNetCore.Mvc;

namespace SayHello_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
    public class SayHelloController
    {

        [HttpGet]
        [Route("/UserName/{name}")]
        public string UserName(string name)
        {
            return $"Hello, {name} have a nice day!";
        }

    }

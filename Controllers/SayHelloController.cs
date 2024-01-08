using Microsoft.AspNetCore.Mvc;

namespace SayHello_Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
    public class SayHelloController
    {
        
        public List<string> studentName = new();

        [HttpPost]
        [Route("/UserName/{name}")]
        public List<string> UserName(string name)
        {
            studentName.Add("Hello, "+name+".");
            return studentName;
        }

    }

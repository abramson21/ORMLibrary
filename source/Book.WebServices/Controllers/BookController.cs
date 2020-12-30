namespace Book.WebServices.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Library.Services;
    using Library.Domain;

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices service;

        public BookController(IBookServices service)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
        }

        [HttpGet]
        public IEnumerable<Book> GetAll()
        {
            return this.service.GetAll().ToList();
        }
    }
}

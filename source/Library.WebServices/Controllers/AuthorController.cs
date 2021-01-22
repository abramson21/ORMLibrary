namespace Library.WebServices.Controllers
{
    using System;
    using Library.Domain;
    using Microsoft.AspNetCore.Mvc;
    using Library.Services;
    using System.Linq;
    using System.Collections.Generic;
    using AutoMapper;
    using Library.WebServices.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly IAuthorService authorService;

        private readonly IMapper mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            this.authorService = authorService ?? throw new ArgumentNullException(nameof(authorService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("for-book/{bookId}")]
        public IEnumerable<AuthorViewModel> Filter([FromRoute] int bookId)
        {
            return this.authorService.GetAuthorByBookId(bookId).Select(t => new AuthorViewModel(t.Name));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = this.authorService.GetAll().AsEnumerable().Select(x => this.mapper.Map<Author, AuthorDTO>(x));
            //this.mapper.Map<IEnumerable<Author>, IEnumerable<AuthorDTO>>(this.authorService.GetAll());
            return this.Ok(result);
        }

        [HttpGet("{authorId}")]
        public Author GetId([FromRoute] int authorId)
        {
            return this.authorService.GetId(authorId);
        }

        [HttpPost]
        public IActionResult Create([FromBody] AuthorDTO dto)
        {
            if (dto is null)
            {
                return this.Ok(new {Error = $"{nameof(dto)} is null"});
            }

            var author = this.authorService.Create(dto.LastName, dto.FirstName, dto.MiddleName);

            if (author is null)
            {
                return this.Ok(new {Error = $"{nameof(author)} is null"});
            }

            return this.Ok(new {Id = author.ID});
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            this.authorService.Delete(id);

            return this.Ok(new {Id = id});
        }
    }
}

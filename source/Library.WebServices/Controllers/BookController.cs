using System.Collections.Generic;

namespace Library.WebServices.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Linq;
    using AutoMapper;
    using Library.Domain;
    using Library.Services;
    using Library.WebServices.ViewModels;

    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService bookService;

        private readonly IMapper mapper;

        public BookController(IBookService bookService, IMapper mapper)
        {
            this.bookService = bookService ?? throw new ArgumentNullException(nameof(bookService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = this.bookService.GetAll()
                .AsEnumerable()
                .Select(x => this.mapper.Map<Book, BookDTO>(x));
            return this.Ok(result);
        }

        [HttpGet("{Id}")]
        public Book GetBookId(int id)
        {
            return this.bookService.GetBookId(id);
        }
        
        [HttpGet("title/{str}")]
        public IActionResult GetBookByTitleName(string str)
        {
            var books = this.bookService.GetBooksByTitle(str);
            if (books == null) return this.NotFound();
            return this.Ok(books);
        }
    }
}

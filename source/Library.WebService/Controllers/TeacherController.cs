namespace Library.WebService.Controllers
{
    using FluentNHibernate.Automapping;
    using AutoMapper;
    using Microsoft.AspNetCore.JsonPatch;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Library.Domain;
    using Library.Services;
    using Library.WebServices.ViewModels;

    [Route("api/[cobtroller")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices service;

        private readonly IMapper mapper;

        public BookController(IBookServices services, IMapper mapper)
        {
            this.service = service ?? throw new ArgumentNullException(nameof(service));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("for-books/{groupId}")]
        public IActionResult Filter([FromRoute] int bookId)
        {
            var result = this.service.Get(bookId)
                .AsEnumerable()
                .Select(this.mapper.Map<Book, TeacherViewModel>);

            return this.Ok(result);
        }

        public IActionResult GetAll()
        {
            var result = this.service.GetAll()
                .AsEnumerable()
                .Select(this.mapper.Map<Teacher, TeacherDto>);

            return this.Ok(result);
        }
    }
}

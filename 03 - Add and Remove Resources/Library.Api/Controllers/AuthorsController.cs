﻿using AutoMapper;
using Library.Api.Models;
using Library.Data.Respositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Library.Api.Controllers
{
[Route("api/authors")]
    public class AuthorsController : Controller
    {
   
        private ILibraryRepository _libraryRepository;

        public AuthorsController(ILibraryRepository libraryRepository)
        {

            _libraryRepository = libraryRepository;
        }

        [HttpGet()]
        public IActionResult GetAuthors()
        {
            var authorsFromRepo = _libraryRepository.GetAuthors();

            var authors = Mapper.Map<IEnumerable<AuthorDto>>(authorsFromRepo);
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(Guid id)
        {
            var authorFromRepo = _libraryRepository.GetAuthor(id);

            if (authorFromRepo == null)
            {
                return NotFound();
            }
            var author = Mapper.Map<AuthorDto>(authorFromRepo);
            return Ok(author);
        }
    }
}
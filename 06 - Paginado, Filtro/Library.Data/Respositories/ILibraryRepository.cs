﻿using System;
using System.Collections.Generic;
using Library.Data.Entities;
using Library.Api.Helper;

namespace Library.Data.Respositories
{
    public interface ILibraryRepository
    {
        //IEnumerable<Author> GetAuthors();
        //TODO : 05 - Cambio la firma del metodo de Repositorio
        //IEnumerable<Author> GetAuthors(AuthorsResourceParameters authorsResourceParameters);

        //TODO : 08 - Cambio el tipo de retorno
        PagedList<Author> GetAuthors(AuthorsResourceParameters authorsResourceParameters);

        Author GetAuthor(Guid authorId);
        IEnumerable<Author> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(Author author);
        void DeleteAuthor(Author author);
        void UpdateAuthor(Author author);
        bool AuthorExists(Guid authorId);
        IEnumerable<Book> GetBooksForAuthor(Guid authorId);
        Book GetBookForAuthor(Guid authorId, Guid bookId);
        void AddBookForAuthor(Guid authorId, Book book);
        void UpdateBookForAuthor(Book book);
        void DeleteBook(Book book);
        bool Save();
    }
}

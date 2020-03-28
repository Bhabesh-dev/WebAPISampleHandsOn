using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPISampleHandsOn.Models;
using WebAPISampleHandsOn.Services.Repository;

namespace WebAPISampleHandsOn.Services
{




    public interface IBookServices
    {
        public IEnumerable<Book> GetBooks();

        public Book GetBookID(Guid bookId);
        public void AddBook([FromBody] Book book) ;


        public void DeleteBook(Guid bookId) ;
    }

    public class BookServices :IBookServices
    {
        private IRepository<Book> bookRepository;

        public BookServices(IRepository<Book> repository)
        {
            this.bookRepository = repository;

        }

        public IEnumerable<Book> GetBooks() => bookRepository.GetAll();

        public Book GetBookID(Guid bookId) => bookRepository.GetById(bookId);
        public void AddBook([FromBody] Book book) => bookRepository.Insert(book);


        public void DeleteBook(Guid bookId) => bookRepository.Delete(bookId);






    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebAPISampleHandsOn.Models;
using WebAPISampleHandsOn.Services;


namespace WebAPISampleHandsOn.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        private IBookServices bookServices;

        public BookController(IBookServices Services)
        {
            this.bookServices = Services;

        }
        [HttpGet]
        [Route("")]
        //public IEnumerable<Book> GetBooks() => bookServices.GetAll();
        public IEnumerable<Book> GetBooks() => bookServices.GetBooks();

        [HttpGet]
        [Route("{bookId}")]
        public Book GetBookID(Guid bookId) => bookServices.GetBookID(bookId);
        //public Book GetBookID(Guid bookId) => bookServices.GetById(bookId);

        [HttpPost]
        [Route("{bookId}")]
        [AllowAnonymous]
        //public void AddBook([FromBody] Book book) => bookServices.Insert(book);
        public void AddBook([FromBody] Book book) => bookServices.AddBook(book);

        [HttpDelete]
        [Route("{bookId}")]
        [AllowAnonymous]
        //public void DeleteBook(Guid bookId) => bookServices.Delete(bookId);
        public void DeleteBook(Guid bookId) => bookServices.DeleteBook(bookId);



    }
}

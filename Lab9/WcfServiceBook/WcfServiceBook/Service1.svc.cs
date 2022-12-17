using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public List<Book> GetBooks()
        {
            return PopulateBookData();
        }
        private List<Book> PopulateBookData()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book();
            book1.Author = "William";
            book1.BookId = 1;
            book1.Name = "BookSSK";
            book1.PagesCount = 900;
            book1.Year = "2332";
            books.Add(book1);
            return books;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    public class Books
    {
        public int Id;
        public string book_name;
        public List<Person> people;
        public Books()
        {
            this.people = new List<Person>();
        }
        public Books(int Id) : this() 
        {
            this.Id = Id;
        }
        public Books(int Id, string book) : this(Id)
        {
            this.book_name = book;
        }


    }
}

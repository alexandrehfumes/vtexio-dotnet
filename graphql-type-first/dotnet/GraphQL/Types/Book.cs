using System.Collections.Generic;

namespace GettingStarted.GraphQL.Types
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
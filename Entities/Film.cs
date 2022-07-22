using System;
using System.Collections.Generic;

namespace Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Category> Categories { get; set; }
    }
}

using System;

namespace Patterns.Models.Factory
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

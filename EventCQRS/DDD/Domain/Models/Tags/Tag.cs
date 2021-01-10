using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Tags
{
   public class Tag
    {

        public int Id { get; private set; }

        public string   Name { get; private set; }

        public Tag(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

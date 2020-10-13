using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public class Project
    {
        public int Id;
        public string Name;

        public Project()
        { }

        public Project(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public class IProjectRepository
    {
        private static Dictionary<string, Project> Projects;

        public IProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new Dictionary<string, Project>();
                Projects.Add("testProjectOne", new Project
                {
                    Id = 1,
                    Name = "1 - Accounting Project"
                });

            }
        }
    }
}

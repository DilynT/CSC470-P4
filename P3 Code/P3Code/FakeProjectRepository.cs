using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public class FakeProjectRepository
    {
        public static Dictionary<string, Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new Dictionary<string, Project>();
                Projects.Add("testProjectOne", new Project
                {
                    Id = 1,
                    Name = "1 - Accounting Project"
                });

                Projects.Add("testProjectTwo", new Project
                {
                    Id = 2,
                    Name = "2 - Big Expensive Project"
                });

                Projects.Add("testProjectThree", new Project
                {
                    Id = 3,
                    Name = "3 - Some other Project"
                });
            }
        }
        public List<Project> GetAll()
        {
            List<Project> projects1 = new List<Project>();
            foreach (KeyValuePair<string, Project> project1 in Projects)
            {
                projects1.Add(project1.Value);
            }
            /*            if (users.Count > 0)
                        {
                            return users;
                        }*/
            return projects1;
        }
    }
}

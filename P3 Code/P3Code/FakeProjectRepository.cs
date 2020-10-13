using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace P3Code
{
    public class FakeProjectRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_PROJECT_ID_ERROR = "Cannot modify the project ID.";
        public const string DUPLICATE_PROJECT_NAME_ERROR = "Project name already exists.";
        public const string NO_PROJECT_FOUND_ERROR = "No project found.";
        public const string EMPTY_PROJECT_NAME_ERROR = "Project name is empty or blank.";

        public static Dictionary<string, Project> Projects;

        public FakeProjectRepository()
        {
            if (Projects == null)
            {
                Projects = new Dictionary<string, Project>();
                Projects.Add("testProjectOne", new Project
                {
                    Id = 1,
                    Name = "Accounting Project"
                });

                Projects.Add("testProjectTwo", new Project
                {
                    Id = 2,
                    Name = "Big Expensive Project"
                });

                Projects.Add("testProjectThree", new Project
                {
                    Id = 3,
                    Name = "Some other Project"
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
            return projects1;
        }

        public string Add(string projectName)
        {
            if(projectName.Equals(""))
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            int maxID = 0;
            /* For a large list, I'd rather check id values here at the same time */
            foreach(KeyValuePair<string, Project> pair in Projects)
            {
                if(pair.Value.Name.Equals(projectName))
                {
                    return DUPLICATE_PROJECT_NAME_ERROR;
                }
                if(pair.Value.Id > maxID)
                {
                    maxID = pair.Value.Id;
                }
            }
            int newID = GetNextID(maxID);

            string testProject = "testProject" + newID;
            Projects.Add(testProject, new Project(newID, projectName));
            return NO_ERROR;
        }
        public string Modify(int id, string project_text)
        {
            if (project_text.Equals(""))
            {
                return EMPTY_PROJECT_NAME_ERROR;
            }
            foreach (KeyValuePair<string, Project> pair in Projects)
            {
                if (pair.Value.Name.Equals(project_text))
                {
                    return DUPLICATE_PROJECT_NAME_ERROR;
                }
            }
            foreach (KeyValuePair<string, Project> pair in Projects)
            {
                if (pair.Value.Id == id)
                {
                    pair.Value.Name = project_text;
                }
            }

            return NO_ERROR;
        }
        public string Remove(int id)
        {
            foreach (KeyValuePair<string, Project> pair in Projects)
            {
                if (pair.Value.Id == id)
                {
                    Projects.Remove(pair.Key);
                    return NO_ERROR;
                }
            }
            return "NO PROJECT FOUND";
        }
        private int GetNextID(int id)
        {
            return id + 1;
        }
    }
}

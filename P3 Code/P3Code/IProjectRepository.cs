using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        string Add(string projectName);
        Project Remove(int projectId);
        Project Modify(int projectId);
        bool IsDuplicateName(string projectName);
    }
}

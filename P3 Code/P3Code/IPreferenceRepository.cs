using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public interface IPreferenceRepository
    {
        string GetPreference(string userName, string preferenceName);
        string SetPreference(string userName, string preferenceName, string Value);
    }
}

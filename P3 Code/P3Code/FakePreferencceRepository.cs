using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public class FakePreferencceRepository
    {
        const string PREFERENCE_PROJECT_ID = "";
        const string PREFERENCE_PROJECT_NAME = "";
        const string NO_ERROR = "";

        public static Dictionary<string, Dictionary<string, string>> Preferences;

        public FakePreferencceRepository()
        {

        }
        public static string SetPreference(string userName, string preferenceName, string Value)
        {
            //Preferences.Add(userName, new  = preferenceName, )
            
            //foreach (var key in Preferences.Keys)
            //{
            //    var userDict = Preferences[key];
            //    foreach( var key2 in userDict.Keys)
            //    {
            //        var projDict = userDict[key2];
            //        foreach( var item in projDict)
            //        {
            //            var currentKey = item.Key;
            //            var currentValue = item.Value;
            //        }
            //    }
            //}

            return "1";
        }

        //string GetPreference(string userName, string preferenceName)

    }
}

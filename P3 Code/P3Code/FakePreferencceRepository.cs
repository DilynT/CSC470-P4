using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3Code
{
    public class FakePreferencceRepository
    {
        const string PREFERENCE_PROJECT_ID = "1";
        const string PREFERENCE_PROJECT_NAME = "Accounting Project";
        const string NO_ERROR = "1";

        public static Dictionary<string, Dictionary<string, string>> Preferences;
        private static Dictionary<string, string> ProjHolder;
        private static Dictionary<string, string> tempHold;
        public FakePreferencceRepository()
        {
            if (Preferences == null)
            {
                ProjHolder = new Dictionary<string, string>();
                ProjHolder.Add("Accounting Project", "1");

                Preferences = new Dictionary<string, Dictionary<string, string>>();
                Preferences.Add("testUserName", ProjHolder);
            }

        }


        public static string SetPreference(string userName, string preferenceName, int Value)
        {
            tempHold = new Dictionary<string, string>();
            tempHold.Add(preferenceName, Value.ToString());
            if(Preferences[userName] != null)
                Preferences.Remove(userName);
            Preferences.Add(userName, tempHold);

            return preferenceName;
        }

        public static string GetPreference(string userName, string preferenceName)
        {
            tempHold = new Dictionary<string, string>();
            if (Preferences == null)
            {
                ProjHolder = new Dictionary<string, string>();
                ProjHolder.Add("Accounting Project", "1");

                Preferences = new Dictionary<string, Dictionary<string, string>>();
                Preferences.Add("testUserName", ProjHolder);
            }
            if (Preferences.ContainsKey(userName))
            {
                Preferences.TryGetValue(userName, out tempHold);
                if(tempHold.ContainsKey(preferenceName))
                {
                    return preferenceName;
                }
            }

            return null;
        }

    }
}

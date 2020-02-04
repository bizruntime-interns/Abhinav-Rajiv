using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace dictonary
{
    class Dictionary
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

                Dictionary<int, string> My_dict1 =
                               new Dictionary<int, string>();
                 My_dict1.Add(1123, "Welcome");
                My_dict1.Add(1124, "to");
                My_dict1.Add(1125, "biz");

                foreach (KeyValuePair<int, string> ele1 in My_dict1)
                {
                    
                }
                Console.WriteLine();
                Dictionary<string, string> My_dict2 = new Dictionary<string, string>() { { "a.1", "Dog" }, { "a.2", "Cat" }, { "a.3", "Pig" } };

            foreach (KeyValuePair<string, string> ele2 in My_dict2)
                {
                    log.Info(ele2.Key + " and " + ele2.Value);
                }
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class DictionaryDemo
    {
        Dictionary <string,string> dictionary = new Dictionary <string,string> ();
        public void DictMethod()
        {
            dictionary.Add("1", "Ankita");
            dictionary.Add("2", "Mansi");
            dictionary.Add("3", "patil");
            //Console.WriteLine(dictionary["2"]);

            //modify
            dictionary["2"] = "Nikita";

            //remove
            dictionary["2"] = "Kalyani";

            //print the dictionary
            foreach(KeyValuePair<string,string> key in dictionary)
            {
                Console.WriteLine("{0} : {1}", key.Key, key.Value);
            }
             
            Dictionary<int, string> dict =new Dictionary<int, string> ();
            dict.Add(1, "Sahil");
            dict.Add(2, "Piyush");
            dict[3] = "ABCD";
            foreach(KeyValuePair<int,string> kv in dict)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
            }
            if (dict.ContainsKey(2))
            {
                dict[2] = "Rahul";
            }
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine("{0} : {1}", kv.Key, kv.Value);
            }
        }

    }
}

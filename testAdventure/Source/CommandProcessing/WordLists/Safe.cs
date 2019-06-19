using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAdventure
{
    static class Safe
    {
        public static Dictionary<string,string> Add (Dictionary<string,string> dictionary, string key, string value)
        {
            value = TextUtils.StemWord.Stem(value).Value;
            key = TextUtils.StemWord.Stem(key).Value;
            //Console.WriteLine(value);
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value);
            return dictionary;
        }

        public static List<string> Add (List<string> a, List<string> b)
        {
            List<string> returnData = new List<string>(a);
            foreach (string s in b)
            {
                if (!returnData.Contains(s))
                    returnData.Add(s);
            }
            return returnData;
        }

        public static void Add(List<string> a, string b)
        {
            if (!a.Contains(b))
                    a.Add(b);
        }

        public static void AddRange<T, S>(this Dictionary<T, S> target, Dictionary<T, S> copyThis)
        {
            foreach (var item in copyThis)
            {
                if (!target.ContainsKey(item.Key))
                {
                    target.Add(item.Key, item.Value);
                }
            }
        }

        public static void Remove(List<string> a_return, List<string> b)
        {
            foreach (string word in b)
            {
                for (int i = 0; i < a_return.Count; i++)
                {
                    if (a_return[i].Equals(word))
                    {
                        a_return.RemoveAt(i);
                    }
                }
            }
        }
    }
}

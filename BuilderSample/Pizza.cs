using System;
using System.Collections.Generic;

namespace BuilderSample
{
    public class Pizza
    {
        private List<String> items = new List<string>();


        public void Add(String item)
        {
            items.Add(item);
        }

        override public String ToString()
        {
            return "Pizza with " + string.Join(",", items.ToArray());
        }
    }
}
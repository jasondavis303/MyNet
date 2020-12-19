using System;

namespace MyNet
{
    class Node : IComparable
    {
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Node)obj).Name);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

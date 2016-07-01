using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MyBug
    {
        public string Name { get; set; }
    }
    public class BugFactory
    {
        public MyBug GetBug()
        {
            return new MyBug {Name = "Lol"};
        }
    }
}

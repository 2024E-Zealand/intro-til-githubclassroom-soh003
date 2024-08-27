using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        //instance
        private string _name;
        private int _age;

        //Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        //konstruktør
        public Demo()
        {
            
        }

        public Demo(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

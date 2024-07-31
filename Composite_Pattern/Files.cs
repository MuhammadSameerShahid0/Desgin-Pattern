using Composite_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Files : IFileSystem
    {
        public string Name { get; set; }
        public Files(string name)
        {
            Name = name;
        }
        public void Display(string indent)
        {
            Console.WriteLine($"{indent} - {Name}");
        }
    }
}

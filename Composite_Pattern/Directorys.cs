using Composite_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Directorys : IFileSystem
    {
        public string Name { get; set; }
        private List<IFileSystem> _Components = new List<IFileSystem>();
        public Directorys(string name)
        {
            Name = name;            
        }
        public void AddComponent(IFileSystem component)
        {
            _Components.Add(component);
        }
        public void RemoveComponent(IFileSystem component)
        {
            _Components.Remove(component);
        }
        public void Display(string indent)
        {
            Console.WriteLine($"{indent}+ {Name}");
            foreach (var components in _Components) 
            {
                components.Display(indent + " ");
            }
        }
    }
}

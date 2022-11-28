using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchDemo
{
    internal class ReactDeveloper : Developer
    {
        public ReactDeveloper(string name, int age, int skillLevel) : base(name, age)
        {
            SkillLevel = skillLevel;
        }

        public int SkillLevel { get; set; }
    }
}

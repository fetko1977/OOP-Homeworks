using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SULS
{
    public class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string firstName, string lastName, int age = 0)
            : base(firstName, lastName, age)
        {
        }
    }
}

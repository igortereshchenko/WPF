using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class ViewModel
    {
        public ViewModel()
        {
            /* Set default age */
            this.Age = 30;
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 10 || value > 100)
                    throw new ArgumentException("The age must be between 10 and 100");
                _age = value;
            }
        }

    }
}

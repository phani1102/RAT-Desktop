using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAT
{
    public class WERiskFactor
    {
        private int _restages;
        public int restages
        {
            get { return _restages; }
            set
            {
                _restages = value;

            }
        }

        private int _program;
        public int program
        {
            get { return _program; }
            set
            {
                _program = value;

            }
        }

        private int _intersects;
        public int intersects
        {
            get { return _intersects; }
            set
            {
                _intersects = value;

            }
        }
    }
}

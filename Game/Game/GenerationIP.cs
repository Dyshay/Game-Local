using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GenerationIP
    {
        private int _IPOne;

        public int IPOne
        {
            get { return _IPOne; }
            set { _IPOne = value; }
        }
        private int _IPTwo;

        public int IPTwo
        {
            get { return _IPTwo; }
            set { _IPTwo = value; }
        }
        private int _IPThree;

        public int IPThree
        {
            get { return _IPThree; }
            set { _IPThree = value; }
        }
        private int _IPFour;

        public int IPFour
        {
            get { return _IPFour; }
            set { _IPFour = value; }
        }
        
        public string GenerateIPt()
        {
            Random Number = new Random();
            IPOne = Number.Next(1, 256);
            IPThree = Number.Next(1, 256);
            IPTwo = Number.Next(1, 256);
            IPFour = Number.Next(1, 256);
            return $"{IPOne}.{IPTwo}.{IPThree}.{IPFour}";
        }
    }
}

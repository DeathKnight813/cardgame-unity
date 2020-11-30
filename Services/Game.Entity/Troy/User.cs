using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Entity.Troy;

namespace Game.Entity.Troy
{
    public class User : ezt_members
    {
        private decimal goldScore;

        public decimal GoldScore
        {
            get { return goldScore; }
            set { goldScore = value; }
        }
    }
}

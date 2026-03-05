using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrain.Domain
{
    public class Train
    {
        public List<Wagon> Wagons;
        public Train()
        {
            Wagons = new List<Wagon>();
        }
    }
}

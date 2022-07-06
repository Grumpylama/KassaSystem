using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBoard
{
    public class Item
    {
        public double price { get; private set; }
        public string name { get; private set; }
        private string imgPath;

        public Item (string name, double price)
        {
            this.price = price;
            this.name = name;
        }

        public void addImg(string imgPath)
        {
            this.imgPath = imgPath;
        }
    }
}

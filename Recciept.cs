using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CBoard
{

    public class recceiptItem
    {
        public Item item { get; private set; }
        public int count { get; private set; }

        public recceiptItem(Item i)
        {
            this.item = i;
            this.count = 1;
        }

        public void increase()
        {
            count++;
        }
        public void decrease()
        {
            if (count > 0)
                count--;
            else return;
        }
    }
    class Recciept
    {
        private List<recceiptItem> items;

        public Recciept()
        {
            items = new List<recceiptItem>();
        }
        public void addItem(Item i)
        {
            foreach(recceiptItem ri in items)
            {
                if (ri.item == i)
                    ri.increase(); return;
            }

            items.Add(new recceiptItem(i));
            return;
        }

        public void removeitem(Item item)
        {
            foreach(recceiptItem ri in items)
            {
                if(ri.item == item)
                {
                    if(ri.count < 0)
                    {
                        //Nothing to remove. 
                        return;
                    }

                    //else(ri.)
                }
            }
        }

        public void printRecciept()
        {
            
        }
        // Might not be necessary
        public string getText()
        {
            return "";
        }

        public void destroy()
        {
            this.destroy();
        }

        public double getTotalPrice()
        {
            double counter = 0;
            foreach(recceiptItem ri in items)
            {
                counter = counter + (ri.count * ri.item.price);
            }
            return counter;
        }
    }
}

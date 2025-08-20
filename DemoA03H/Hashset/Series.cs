using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoA03H.Hashset
{
    internal class Series :IEquatable <Series>
    {
        public Series(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public bool Equals(Series? other)
        {
            return this.Id.Equals(other.Id)&&
                this.Title.Equals(other.Title)&&
                this.Price.Equals(other.Price);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Price);  
        }
        public override string ToString()
        {
            return $"Id : {Id} || Title  :  {Title}  || Price : {Price} ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractice
{
    /// <summary>
    /// Represents as a single piece of candy
    /// </summary>
    public class Candy : IComparable<Candy> 
    {
        /// <summary>
        /// The candy's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The candy's flavor
        /// </summary>
        public string Flavor { get; set; }

        /// <summary>
        /// The date of the candy created
        /// </summary>
        public DateTime DateOfCreation { get; set; }

        public int CompareTo(Candy? other)
        {
            throw new NotImplementedException();
        }
    }
}

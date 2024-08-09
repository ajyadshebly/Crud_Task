using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_task.Models
{
    internal class Order
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public DateTime CreatedAT { get; set; }
        
    }
}

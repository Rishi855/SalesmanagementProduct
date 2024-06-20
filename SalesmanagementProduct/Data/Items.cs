using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesmanagementProduct.Data
{
    public class Items
    {
        [Key, Column(Order = 1)]
        public int ItemSize { get; set; }
        
        [Key, Column(Order = 2)]
        public string ItemType { get; set; }
    }
}

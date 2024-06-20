using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesmanagementProduct.Data
{
    public class Stock
    {
        [Key, Column(Order = 0)]
        public int ItemSize { get; set; }

        [Key, Column(Order = 1)]
        public string ItemType { get; set; }
        
        public float Dozen { get; set; }
        
        public int Piece { get; set; }
    }
}

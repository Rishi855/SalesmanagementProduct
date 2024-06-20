using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SalesmanagementProduct.Data
{
    public class Outward
    {
        [Key, Column(Order = 0)]
        
        public string BailNumber { get; set; }
        [Key, Column(Order = 1)]
        
        public int ItemSize { get; set; }
        [Key, Column(Order = 2)]
        
        public string ItemType { get; set; }
        
        public DateTime Date { get; set; }
        
        public float Dozen { get; set; }
        
        public int Piece { get; set; }
    }
}

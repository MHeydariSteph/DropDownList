using System.ComponentModel.DataAnnotations;


namespace DropDownList.Model
{
    public class DspClass
    {
        [Key]
        public int DispId { get; set; }
        public string SaleMan { get; set; }
    }
}

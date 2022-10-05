using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [Display(Name = "Account Number")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(12, ErrorMessage ="max 12 characters only")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Beneficiary Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string BeneficiaryName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bank Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string BankName { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Display(Name = "Swift Code")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(11, ErrorMessage = "max 11 characters only")]
        public string SwiftCode { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyy}")]
        public DateTime Date { get; set; }
    }
}

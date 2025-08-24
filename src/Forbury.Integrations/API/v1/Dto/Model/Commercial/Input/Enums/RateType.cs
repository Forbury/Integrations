using System.ComponentModel.DataAnnotations;

namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Enums
{
    public enum RateType
    {
        [Display(Name = "Cap Rate")]
        CapRate,

        [Display(Name = "Discount Rate")]
        DiscountRate
    }
}

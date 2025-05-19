using Forbury.Integrations.API.v1.Dto.Model.Retail.Input.Space.Lease.MovingAnnualTurnover;

namespace Forbury.Integrations.API.v1.Dto.Model.Retail.Input.General
{
    public class RetailGeneralDto: Commercial.Input.General.GeneralDto
    {
        /// <summary>
        /// Property level Moving Annual Turnover setting
        /// </summary>
        public MovingAnnualTurnoverDto MAT { get; set; }
    }
}

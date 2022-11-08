namespace Forbury.Integrations.API.v1.Dto.Model.Commercial.Input.Reporting
{
    public class ReportingDto
    {
        public decimal? SiteArea { get; set; }
        public string LegalDescription { get; set; }
        public string LocalGovernmentArea { get; set; }
        public string Zoning { get; set; }
        public string FloorSpaceRatio { get; set; }
        public string PlanningScheme { get; set; }
        public decimal? NabersEnergy { get; set; }
        public decimal? NabersWater { get; set; }
        public string YearBuilt { get; set; }
        public string Sector { get; set; }
        public string SubSector { get; set; }
        public string Precinct { get; set; }
        public string Grade { get; set; }
        public string PcaMarket { get; set; }
        public string PcaCharacteristic { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string JobReference { get; set; }
        public string PrimaryValuer { get; set; }
        public string SecondaryValuer { get; set; }
    }
}

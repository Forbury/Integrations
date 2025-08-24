using System.ComponentModel.DataAnnotations;

namespace Forbury.Integrations.API.v1.Dto.Enums
    {
        public enum HistoricalCpiSourceType
        {
        [Display(Name = "Sydney - All Groups")]
        SydneyAllGroups,

        [Display(Name = "Melbourne - All Groups")]
        MelbourneAllGroups,

        [Display(Name = "Brisbane - All Groups")]
        BrisbaneAllGroups,

        [Display(Name = "Adelaide - All Groups")]
        AdelaideAllGroups,

        [Display(Name = "Perth - All Groups")] 
        PerthAllGroups,

        [Display(Name = "Hobart - All Groups")]
        HobartAllGroups,

        [Display(Name = "Darwin - All Groups")]
        DarwinAllGroups,

        [Display(Name = "Canberra - All Groups")] 
        CanberraAllGroups,

        [Display(Name = "Australia - All Groups")]
        AustraliaAllGroups,

        [Display(Name = "New Zealand - All Groups")]
        NewZealandAllGroups,

        [Display(Name = "Other")]
        Other
        }
    }

using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetConsole.Files
{
    public class ProfileDto
    {
        public int ProfileId { get; set; }

        public List<RecommendationDto> Recommendations { get; set; }
    }

    public class RecommendationDto
    {
        public int RecommendationId { get; set; }
        public OriginalProduct OriginalProduct { get; set; }
        public ReplacementProduct ReplacementProduct { get; set; }
        public string DosageType { get; set; }
        public string[] PrescriptionType { get; set; }
        public string PrescriptionCalculation { get; set; }
        public int? ReplacementMaxQuantity { get; set; }
        public RichText JustificationText { get; set; }
        public bool InformationOnly { get; set; }
        public string DoseTimeOfDay { get; set; }
        public int Sequence { get; set; }
        public string CustomDemographics { get; set; }

        public bool IsHideCostDisplay { get; set; }
        public string HideCostDisplayReason { get; set; }
        public string PcoName { get; set; } = string.Empty;
        //public static DoseTimeOfDay ToEnumDoseTimeOfDay(RecommendationDto dto)
        //{
        //    string doseTime = null;
        //   switch(dto.DoseTimeOfDay.ToLower())
        //    {
        //        case "morning":
        //            doseTime = (string)DoseTimeOfDay.mo
        //            break;
        //        case "morning":
        //            break;
        //        case "morning":
        //            break;
        //            default: return null;
        //    }
        //}
    }
    public enum RecommendationStatus
    {
        Available,
        DosageRulesIncompatible,
        FailedToCalculateQuantity,
        DemographicsIncompatible,
        ScriptTypeMismatch
    }
    public enum TimeOfDay
    {
        Daily = 0,
        Morning = 64,
        Night = 128
    }
    public enum DoseTimeOfDay
    {
        Daily,
        Morning,
        Night
    }

    public class RichText
    {
        public string Text { get; set; }
        public string HTML { get; set; }
    }

    public class OriginalProduct
    {
        public string OriginalCode { get; set; }
        public Dosage SwitchFromDosage { get; set; }
    }

    public class ReplacementProduct
    {
        public string ReplacementCode { get; set; }
        public Dosage SwitchToDosage { get; set; }
    }

    public class Dosage
    {
        public int Quantity { get; set; }
        public string Frequency { get; set; }
    }
}

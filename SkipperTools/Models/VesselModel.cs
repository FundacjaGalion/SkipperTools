using System;
using System.ComponentModel.DataAnnotations;

namespace SkipperTools.Models
{
    public class VesselModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CheckInMarina { get; set; }

        public int MaxCrewMembers { get; set; }
        public int LockableCabins { get; set; }
        public int YearOfConstruction { get; set; }
        public float SailSurface { get; set; }
        public float TotalLength { get; set; }
        public float HeightInCabin { get; set; }
        public float TotalWidth { get; set; }
        public float MaximumDraft { get; set; }
        public float MastHeight { get; set; }
        public int KeelType { get; set; }
        public int RudderType { get; set; }
        public int EngineType { get; set; }
        public int EngineBrand { get; set; }
        public float EnginePower { get; set; }
        public int EngineLocation { get; set; }
        public float FuelTankCapacity { get; set; }
        public float WaterTankCapacity { get; set; }
        public float DirtyWaterTankCapacity { get; set; }
        public bool MainsailWithTravelers { get; set; }
        public bool MastTopLight { get; set; }
        public bool SternLadder { get; set; }
        public bool SternGangplanck { get; set; }
        public bool NavigationLights { get; set; }
        public bool BoomTent { get; set; }
        public bool PortableTankWithSpout { get; set; }
        public bool Rectifier { get; set; }
        public bool Oven { get; set; }
        public bool StationaryChemicalToilet { get; set; }
        public bool DepthSounder { get; set; }
        public bool JibSystemOnARigidForestay { get; set; }
        public bool LazyJack { get; set; }
        public bool SteeringWheel { get; set; }
        public bool SprayHood { get; set; }
        public bool DrinkingWaterInstallation { get; set; }
        public bool OutboardWaterInstalation { get; set; }
        public bool ElectricalInverter { get; set; }
        public bool CockpitLight { get; set; }
        public bool Sink { get; set; }
        public bool OutsideShower { get; set; }
        public bool GPS { get; set; }
        public bool MastSpreadersLight { get; set; }
        public bool MastPennant { get; set; }
        public bool Railings { get; set; }
        public bool LifeSavingEquipment { get; set; }
        public bool FireExtinguisher { get; set; }
        public bool HotWater { get; set; }
        public bool CookingFacilities { get; set; }
        public bool YachtVentilationForwardHatch { get; set; }
        public bool Socket230V { get; set; }
        public string ExtraStuff { get; set; }


    }
}

namespace MHR___Ass.Data.Resistances
{
    public class Resistance
    {
        public ResistanceType Type { get; set; }
        public int Value { get; set; }
    }

    public class FireResistance : Resistance
    {
        public FireResistance(int value = 0)
        {
            Type = ResistanceType.Fire;
            Value = value;
        }
    }

    public class WaterResistance : Resistance
    {
        public WaterResistance(int value = 0)
        {
            Type = ResistanceType.Water;
            Value = value;
        }
    }

    public class DragonResistance : Resistance
    {
        public DragonResistance(int value = 0)
        {
            Type = ResistanceType.Dragon;
            Value = value;
        }
    }

    public class ThunderResistance : Resistance
    {
        public ThunderResistance(int value = 0)
        {
            Type = ResistanceType.Thunder;
            Value = value;
        }
    }

    public class IceResistance : Resistance
    {
        public IceResistance(int value = 0)
        {
            Type = ResistanceType.Ice;
            Value = value;
        }
    }
}
using MHR___Ass.Data.Decorations;

namespace MHR___Ass.Data.Slots
{
    public class Slot
    {
        public SlotType Type { get; set; }
        public Decoration Decoration { get; set; }
    }

    public class SmallSlot : Slot
    {
        public SmallSlot(Decoration decoration = null)
        {
            Type = SlotType.Small;
            if (decoration != null)
            {
                Decoration = decoration;
            }
        }
    }

    public class MediumSlot : Slot
    {
        public MediumSlot(Decoration decoration = null)
        {
            Type = SlotType.Medium;
            if (decoration != null)
            {
                Decoration = decoration;
            }
        }
    }

    public class LargeSlot : Slot
    {
        public LargeSlot(Decoration decoration = null)
        {
            Type = SlotType.Large;
            if (decoration != null)
            {
                Decoration = decoration;
            }
        }
    }

    public class ExtraLargeSlot : Slot
    {
        public ExtraLargeSlot(Decoration decoration = null)
        {
            Type = SlotType.ExtraLarge;
            if (decoration != null)
            {
                Decoration = decoration;
            }
        }
    }

    public class SlotCombo
    {
        public int Small { get; set; }
        public int Medium { get; set; }
        public int Large { get; set; }
        public int ExtraLarge { get; set; }

        public SlotCombo()
        {
        }

        public SlotCombo(int small = 0, int medium = 0, int large = 0, int extraLarge = 0)
        {
            Small = small;
            Medium = medium;
            Large = large;
            ExtraLarge = extraLarge;
        }
    }
}
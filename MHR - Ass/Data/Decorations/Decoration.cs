using MHR___Ass.Data.Skills;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations
{
    public class Decoration
    {
        public string Name { get; set; }
        public Skill Skill { get; set; }
        public SlotType Type { get; set; }

        public bool IsSlotCompatible(SlotType type)
        {
            return (int)Type <= (int)type;
        }
    }
}
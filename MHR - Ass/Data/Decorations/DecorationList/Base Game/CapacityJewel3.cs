using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class CapacityJewel3 : Decoration
    {
        public CapacityJewel3()
        {
            Name = "Capacity Jewel 3";
            Skill = new AmmoUp(1);
            Type = SlotType.Large;
        }
    }
}
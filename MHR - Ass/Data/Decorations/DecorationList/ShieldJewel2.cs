using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ShieldJewel2 : Decoration
    {
        public ShieldJewel2()
        {
            Name = "Shield Jewel 2";
            Skill = new GuardUp(1);
            Type = SlotType.Medium;
        }
    }
}
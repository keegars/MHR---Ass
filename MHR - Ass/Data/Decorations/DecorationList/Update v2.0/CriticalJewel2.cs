using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class CriticalJewel2 : Decoration
    {
        public CriticalJewel2()
        {
            Name = "Critical Jewel 2";
            Skill = new CriticalBoost(1);
            Type = SlotType.Medium;
        }
    }
}
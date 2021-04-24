using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class CritElementJewel2 : Decoration
    {
        public CritElementJewel2()
        {
            Name = "Crit Element Jewel 2";
            Skill = new CriticalElement(1);
            Type = SlotType.Medium;
        }
    }
}
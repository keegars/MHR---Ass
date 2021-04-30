using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BluntJewel2 : Decoration
    {
        public BluntJewel2()
        {
            Name = "Blunt Jewel 2";
            Skill = new Bludgeoner(1);
            Type = SlotType.Medium;
        }
    }
}
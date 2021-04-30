using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class PierceJewel3 : Decoration
    {
        public PierceJewel3()
        {
            Name = "Pierce Jewel 3";
            Skill = new PierceUp(1);
            Type = SlotType.Large;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class CrisisJewel2 : Decoration
    {
        public CrisisJewel2()
        {
            Name = "Crisis Jewel 2";
            Skill = new Resuscitate(1);
            Type = SlotType.Medium;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BraceJewel1 : Decoration
    {
        public BraceJewel1()
        {
            Name = "Brace Jewel 1";
            Skill = new FlinchFree(1);
            Type = SlotType.Small;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class MasteryJewel2 : Decoration
    {
        public MasteryJewel2()
        {
            Name = "Mastery Jewel 2";
            Skill = new MastersTouch(1);
            Type = SlotType.Medium;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ExpertJewel2 : Decoration
    {
        public ExpertJewel2()
        {
            Name = "Expert Jewel 2";
            Skill = new CriticalEye(1);
            Type = SlotType.Medium;
        }
    }
}
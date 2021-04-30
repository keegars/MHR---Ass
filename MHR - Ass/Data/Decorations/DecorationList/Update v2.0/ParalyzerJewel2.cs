using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ParalyzerJewel2 : Decoration
    {
        public ParalyzerJewel2()
        {
            Name = "Paralyzer Jewel 2";
            Skill = new ParalysisAttack(1);
            Type = SlotType.Medium;
        }
    }
}
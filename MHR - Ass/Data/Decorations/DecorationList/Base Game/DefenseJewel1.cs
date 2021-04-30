using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DefenseJewel1 : Decoration
    {
        public DefenseJewel1()
        {
            Name = "Defense Jewel 1";
            Skill = new DefenseBoost(1);
            Type = SlotType.Small;
        }
    }
}
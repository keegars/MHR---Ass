using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class AttackJewel2 : Decoration
    {
        public AttackJewel2()
        {
            Name = "Attack Jewel 2";
            Skill = new AttackBoost(1);
            Type = SlotType.Medium;
        }
    }
}
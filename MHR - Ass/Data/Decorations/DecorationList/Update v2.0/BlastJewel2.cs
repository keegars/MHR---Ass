using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BlastJewel2 : Decoration
    {
        public BlastJewel2()
        {
            Name = "Blast Jewel 2";
            Skill = new BlastAttack(1);
            Type = SlotType.Medium;
        }
    }
}
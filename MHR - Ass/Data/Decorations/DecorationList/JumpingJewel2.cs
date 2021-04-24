using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class JumpingJewel2 : Decoration
    {
        public JumpingJewel2()
        {
            Name = "Jumping Jewel 2";
            Skill = new EvadeExtender(1);
            Type = SlotType.Medium;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SleepJewel2 : Decoration
    {
        public SleepJewel2()
        {
            Name = "Sleep Jewel 2";
            Skill = new SleepAttack(1);
            Type = SlotType.Medium;
        }
    }
}
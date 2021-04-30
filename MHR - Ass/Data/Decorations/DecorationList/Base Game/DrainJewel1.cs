using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DrainJewel1 : Decoration
    {
        public DrainJewel1()
        {
            Name = "Drain Jewel 1";
            Skill = new StaminaThief(1);
            Type = SlotType.Small;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardDrainResJewel4 : Decoration
    {
        public HardDrainResJewel4()
        {
            Name = "Hard Drain Res Jewel 4";
            Skill = new StaminaThief(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
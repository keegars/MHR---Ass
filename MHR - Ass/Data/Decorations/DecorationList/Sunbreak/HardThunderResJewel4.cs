using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardThunderResJewel4 : Decoration
    {
        public HardThunderResJewel4()
        {
            Name = "Hard Thunder Res Jewel 4";
            Skill = new ThunderResistance(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
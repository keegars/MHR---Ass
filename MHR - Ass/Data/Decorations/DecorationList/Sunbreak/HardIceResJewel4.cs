using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardIceResJewel4 : Decoration
    {
        public HardIceResJewel4()
        {
            Name = "Hard Ice Res Jewel 4";
            Skill = new IceResistance(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardEnduringResJewel4 : Decoration
    {
        public HardEnduringResJewel4()
        {
            Name = "Hard Enduring Res Jewel 4";
            Skill = new ItemProlonger(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
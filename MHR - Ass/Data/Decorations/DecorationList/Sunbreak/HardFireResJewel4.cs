using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardFireResJewel4 : Decoration
    {
        public HardFireResJewel4()
        {
            Name = "Hard Fire Res Jewel 4";
            Skill = new FireResistance(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
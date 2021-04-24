using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ThunderResJewel1 : Decoration
    {
        public ThunderResJewel1()
        {
            Name = "Thunder Res Jewel 1";
            Skill = new ThunderResistance(1);
            Type = SlotType.Small;
        }
    }
}
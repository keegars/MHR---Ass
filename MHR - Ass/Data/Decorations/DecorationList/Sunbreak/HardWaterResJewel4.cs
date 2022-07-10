using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardWaterResJewel4 : Decoration
    {
        public HardWaterResJewel4()
        {
            Name = "Hard Water Res Jewel 4";
            Skill = new WaterResistance(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
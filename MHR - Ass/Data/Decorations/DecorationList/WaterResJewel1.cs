using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class WaterResJewel1 : Decoration
    {
        public WaterResJewel1()
        {
            Name = "Water Res Jewel 1";
            Skill = new WaterResistance(1);
            Type = SlotType.Small;
        }
    }
}
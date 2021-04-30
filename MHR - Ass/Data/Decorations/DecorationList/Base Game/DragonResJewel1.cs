using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DragonResJewel1 : Decoration
    {
        public DragonResJewel1()
        {
            Name = "Dragon Res Jewel 1";
            Skill = new DragonResistance(1);
            Type = SlotType.Small;
        }
    }
}
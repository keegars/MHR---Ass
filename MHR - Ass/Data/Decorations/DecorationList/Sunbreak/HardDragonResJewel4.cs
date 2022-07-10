using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardDragonResJewel4 : Decoration
    {
        public HardDragonResJewel4()
        {
            Name = "Hard Dragon Res Jewel 4";
            Skill = new DragonResistance(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
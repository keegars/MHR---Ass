using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardHungerlessResJewel4 : Decoration
    {
        public HardHungerlessResJewel4()
        {
            Name = "Hard Hungerless Res Jewel 4";
            Skill = new HungerResistance(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
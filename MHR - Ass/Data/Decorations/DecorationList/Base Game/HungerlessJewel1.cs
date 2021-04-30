using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HungerlessJewel1 : Decoration
    {
        public HungerlessJewel1()
        {
            Name = "Hungerless Jewel 1";
            Skill = new HungerResistance(1);
            Type = SlotType.Small;
        }
    }
}
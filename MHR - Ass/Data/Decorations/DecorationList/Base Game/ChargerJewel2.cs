using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ChargerJewel2 : Decoration
    {
        public ChargerJewel2()
        {
            Name = "Charger Jewel 2";
            Skill = new Focus(1);
            Type = SlotType.Medium;
        }
    }
}
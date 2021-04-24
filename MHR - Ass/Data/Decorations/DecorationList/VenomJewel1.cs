using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class VenomJewel1 : Decoration
    {
        public VenomJewel1()
        {
            Name = "Venom Jewel 1";
            Skill = new PoisonAttack(1);
            Type = SlotType.Small;
        }
    }
}
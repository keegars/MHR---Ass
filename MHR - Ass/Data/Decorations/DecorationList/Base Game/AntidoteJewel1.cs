using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class AntidoteJewel1 : Decoration
    {
        public AntidoteJewel1()
        {
            Name = "Antidote Jewel 1";
            Skill = new PoisonResistance(1);
            Type = SlotType.Small;
        }
    }
}
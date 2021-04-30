using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class AntiparaJewel1 : Decoration
    {
        public AntiparaJewel1()
        {
            Name = "Antipara Jewel 1";
            Skill = new ParalysisResistance(1);
            Type = SlotType.Small;
        }
    }
}
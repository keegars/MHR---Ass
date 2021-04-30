using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class AntiblastJewel1 : Decoration
    {
        public AntiblastJewel1()
        {
            Name = "Antiblast Jewel 1";
            Skill = new BlastResistance(1);
            Type = SlotType.Small;
        }
    }
}
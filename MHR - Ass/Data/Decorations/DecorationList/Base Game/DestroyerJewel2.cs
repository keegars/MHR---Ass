using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class DestroyerJewel2 : Decoration
    {
        public DestroyerJewel2()
        {
            Name = "Destroyer Jewel 2";
            Skill = new Partbreaker(1);
            Type = SlotType.Medium;
        }
    }
}
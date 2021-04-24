using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class KOJewel2 : Decoration
    {
        public KOJewel2()
        {
            Name = "KO Jewel 2";
            Skill = new Slugger(1);
            Type = SlotType.Medium;
        }
    }
}
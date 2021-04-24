
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class PhysiqueJewel2 : Decoration
    {
        public PhysiqueJewel2()
        {
            Name = "Physique Jewel 2";
            Skill = new Constitution(1);
            Type = SlotType.Medium;
        }
    }
}


            
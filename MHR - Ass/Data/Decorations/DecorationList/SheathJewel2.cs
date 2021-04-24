
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SheathJewel2 : Decoration
    {
        public SheathJewel2()
        {
            Name = "Sheath Jewel 2";
            Skill = new QuickSheath(1);
            Type = SlotType.Medium;
        }
    }
}


            
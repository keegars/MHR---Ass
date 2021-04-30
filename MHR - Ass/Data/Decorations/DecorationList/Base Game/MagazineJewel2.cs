using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class MagazineJewel2 : Decoration
    {
        public MagazineJewel2()
        {
            Name = "Magazine Jewel 2";
            Skill = new LoadShells(1);
            Type = SlotType.Medium;
        }
    }
}
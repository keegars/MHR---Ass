
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class RefreshJewel2 : Decoration
    {
        public RefreshJewel2()
        {
            Name = "Refresh Jewel 2";
            Skill = new StaminaSurge(1);
            Type = SlotType.Medium;
        }
    }
}


            
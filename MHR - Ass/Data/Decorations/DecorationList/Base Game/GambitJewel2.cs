using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class GambitJewel2 : Decoration
    {
        public GambitJewel2()
        {
            Name = "Gambit Jewel 2";
            Skill = new PunishingDraw(1);
            Type = SlotType.Medium;
        }
    }
}
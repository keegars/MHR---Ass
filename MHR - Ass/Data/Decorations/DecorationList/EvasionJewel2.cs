using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class EvasionJewel2 : Decoration
    {
        public EvasionJewel2()
        {
            Name = "Evasion Jewel 2";
            Skill = new EvadeWindow(1);
            Type = SlotType.Medium;
        }
    }
}
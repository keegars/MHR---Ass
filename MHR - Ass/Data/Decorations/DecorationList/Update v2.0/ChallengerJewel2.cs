using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ChallengerJewel2 : Decoration
    {
        public ChallengerJewel2()
        {
            Name = "Challenger Jewel 2";
            Skill = new Agitator(1);
            Type = SlotType.Medium;
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class EnhancerJewel2 : Decoration
    {
        public EnhancerJewel2()
        {
            Name = "Enhancer Jewel 2";
            Skill = new PowerProlonger(1);
            Type = SlotType.Medium;
        }
    }
}
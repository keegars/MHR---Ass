using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BubbleJewel2 : Decoration
    {
        public BubbleJewel2()
        {
            Name = "Bubble Jewel 2";
            Skill = new BubblyDance(1);
            Type = SlotType.Medium;
        }
    }
}
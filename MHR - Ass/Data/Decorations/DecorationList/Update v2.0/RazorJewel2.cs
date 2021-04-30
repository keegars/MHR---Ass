using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class RazorJewel2 : Decoration
    {
        public RazorJewel2()
        {
            Name = "Razor Jewel 2";
            Skill = new RazorSharp(1);
            Type = SlotType.Medium;
        }
    }
}
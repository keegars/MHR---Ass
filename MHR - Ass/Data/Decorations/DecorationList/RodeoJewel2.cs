using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class RodeoJewel2 : Decoration
    {
        public RodeoJewel2()
        {
            Name = "Rodeo Jewel 2";
            Skill = new MasterMounter(1);
            Type = SlotType.Medium;
        }
    }
}
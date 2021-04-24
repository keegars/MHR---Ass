using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BomberJewel1 : Decoration
    {
        public BomberJewel1()
        {
            Name = "Bomber Jewel 1";
            Skill = new Bombardier(1);
            Type = SlotType.Small;
        }
    }
}
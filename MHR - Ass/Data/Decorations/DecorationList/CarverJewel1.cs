using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class CarverJewel1 : Decoration
    {
        public CarverJewel1()
        {
            Name = "Carver Jewel 1";
            Skill = new CarvingPro(1);
            Type = SlotType.Small;
        }
    }
}
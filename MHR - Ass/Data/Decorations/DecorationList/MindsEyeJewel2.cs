using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class MindsEyeJewel2 : Decoration
    {
        public MindsEyeJewel2()
        {
            Name = "Mind's Eye Jewel 2";
            Skill = new MindsEye(1);
            Type = SlotType.Medium;
        }
    }
}
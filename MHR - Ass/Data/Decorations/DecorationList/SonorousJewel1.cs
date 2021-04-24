
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class SonorousJewel1 : Decoration
    {
        public SonorousJewel1()
        {
            Name = "Sonorous Jewel 1";
            Skill = new HornMaestro(1);
            Type = SlotType.Small;
        }
    }
}


            

using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class QuickloadJewel1 : Decoration
    {
        public QuickloadJewel1()
        {
            Name = "Quickload Jewel 1";
            Skill = new ReloadSpeed(1);
            Type = SlotType.Small;
        }
    }
}


            
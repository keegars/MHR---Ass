using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class BotanyJewel1 : Decoration
    {
        public BotanyJewel1()
        {
            Name = "Botany Jewel 1";
            Skill = new Botanist(1);
            Type = SlotType.Small;
        }
    }
}
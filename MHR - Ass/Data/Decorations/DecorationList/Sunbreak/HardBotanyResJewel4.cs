using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class HardBotanyResJewel4 : Decoration
    {
        public HardBotanyResJewel4()
        {
            Name = "Hard Botany Res Jewel 4";
            Skill = new Botanist(3);
            Type = SlotType.ExtraLarge;
        }
    }
}
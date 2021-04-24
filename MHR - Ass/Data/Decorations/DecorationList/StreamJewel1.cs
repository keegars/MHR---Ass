
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class StreamJewel1 : Decoration
    {
        public StreamJewel1()
        {
            Name = "Stream Jewel 1";
            Skill = new WaterAttack(1);
            Type = SlotType.Small;
        }
    }
}


            
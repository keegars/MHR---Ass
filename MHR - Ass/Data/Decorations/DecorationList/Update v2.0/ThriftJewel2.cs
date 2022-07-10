using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ThriftJewel2 : Decoration
    {
        public ThriftJewel2()
        {
            Name = "Thrift Jewel 2";
            Skill = new SpareShot(1);
            Type = SlotType.Medium;
        }
    }
}
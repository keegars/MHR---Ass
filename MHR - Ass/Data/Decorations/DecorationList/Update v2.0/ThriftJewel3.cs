using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ThriftJewel3 : Decoration
    {
        public ThriftJewel3()
        {
            Name = "Thrift Jewel 3";
            Skill = new SpareShot(1);
            Type = SlotType.Large;
        }
    }
}
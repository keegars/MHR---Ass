using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class ResistorJewel2 : Decoration
    {
        public ResistorJewel2()
        {
            Name = "Resistor Jewel 2";
            Skill = new BlightResistance(1);
            Type = SlotType.Medium;
        }
    }
}
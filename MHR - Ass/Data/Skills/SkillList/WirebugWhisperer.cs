
namespace MHR___Ass.Data.Skills.SkillList
{
    public class WirebugWhisperer : Skill
    {
        public WirebugWhisperer(int value) : base(value)
        {
        }

        public WirebugWhisperer() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WirebugWhisperer
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Improves your handling of Wirebugs.
1: Extends the duration you can keep a Wirebug by 30%.
2: Further increases passive Wirebug recovery rate.
3: Further increases passive recovery rate while on the ground.";
    }
 }
            
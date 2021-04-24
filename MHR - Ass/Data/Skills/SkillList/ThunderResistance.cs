
namespace MHR___Ass.Data.Skills.SkillList
{
    public class ThunderResistance : Skill
    {
        public ThunderResistance(int value) : base(value)
        {
        }

        public ThunderResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ThunderResistance
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
Increases thunder resistance. Also improves defense at higher levels.
1: Thunder resistance +6
2: Thunder resistance +12
3: Thunder resistance +20 Defense +10";
    }
 }
            
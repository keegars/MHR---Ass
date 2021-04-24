
namespace MHR___Ass.Data.Skills.SkillList
{
    public class StunResistance : Skill
    {
        public StunResistance(int value) : base(value)
        {
        }

        public StunResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new StunResistance
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
Reduces stun duration.
1: Reduces the duration of stun by 60%.
2: Reduces the duration of stun by 90%.
3: Prevents stun.";
    }
 }
            
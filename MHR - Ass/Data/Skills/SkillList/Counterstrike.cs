
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Counterstrike : Skill
    {
        public Counterstrike(int value) : base(value)
        {
        }

        public Counterstrike() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Counterstrike
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
Temporarily increases attack power after being thrown off.
1: Attack +10 after activation.
2: Attack +15 after activation.
3: Attack +25 after activation.";
    }
 }
            
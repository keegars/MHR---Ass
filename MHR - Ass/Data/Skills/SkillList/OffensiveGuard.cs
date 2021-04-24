
namespace MHR___Ass.Data.Skills.SkillList
{
    public class OffensiveGuard : Skill
    {
        public OffensiveGuard(int value) : base(value)
        {
        }

        public OffensiveGuard() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new OffensiveGuard
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
Temporarily increases attack power after executing a perfectly-timed guard.
1: Attack +5% while active.
2: Attack +10% while active.
3: Attack +15% while active.";
    }
 }
            
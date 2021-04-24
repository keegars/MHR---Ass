
namespace MHR___Ass.Data.Skills.SkillList
{
    public class SleepResistance : Skill
    {
        public SleepResistance(int value) : base(value)
        {
        }

        public SleepResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SleepResistance
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
Reduces the duration of sleep.
1: Reduces the duration of sleep by 30%.
2: Reduces the duration of sleep by 60%.
3: Prevents sleep.";
    }
 }
            
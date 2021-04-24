
namespace MHR___Ass.Data.Skills.SkillList
{
    public class MaximumMight : Skill
    {
        public MaximumMight(int value) : base(value)
        {
        }

        public MaximumMight() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MaximumMight
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
Increases affinity if stamina is kept full for a period of time.
1: While active, increases affinity by 10%.
2: While active, increases affinity by 20%.
3: While active, increases affinity by 30%.";
    }
 }
            
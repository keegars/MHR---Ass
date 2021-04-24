
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Steadiness : Skill
    {
        public Steadiness(int value) : base(value)
        {
        }

        public Steadiness() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Steadiness
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 2;
        public override string Description { get; set; } = @"
Suppresses the deviation of bowgun shots.
1: Deviation -1
2: Deviation -2";
    }
 }
            
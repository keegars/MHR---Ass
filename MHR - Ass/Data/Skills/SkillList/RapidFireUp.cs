
namespace MHR___Ass.Data.Skills.SkillList
{
    public class RapidFireUp : Skill
    {
        public RapidFireUp(int value) : base(value)
        {
        }

        public RapidFireUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new RapidFireUp
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
Improves light bowgun rapid fire.
1: Rapid fire damage +5%
2: Rapid fire damage +10%
3: Rapid fire damage +20%";
    }
 }
            

namespace MHR___Ass.Data.Skills.SkillList
{
    public class SpeedEating : Skill
    {
        public SpeedEating(int value) : base(value)
        {
        }

        public SpeedEating() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SpeedEating
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
Increases meat-eating and item-consumption speed.
1: Slightly increases eating speed.
2: Increases eating speed.
3: Greatly increases eating speed.";
    }
 }
            
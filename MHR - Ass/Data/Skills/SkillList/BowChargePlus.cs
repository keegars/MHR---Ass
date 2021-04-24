
namespace MHR___Ass.Data.Skills.SkillList
{
    public class BowChargePlus : Skill
    {
        public BowChargePlus(int value) : base(value)
        {
        }

        public BowChargePlus() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BowChargePlus
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Increases max bow charge level by one.
1: Activates skill effect.";
    }
 }
            
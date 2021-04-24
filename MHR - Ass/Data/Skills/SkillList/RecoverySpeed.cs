
namespace MHR___Ass.Data.Skills.SkillList
{
    public class RecoverySpeed : Skill
    {
        public RecoverySpeed(int value) : base(value)
        {
        }

        public RecoverySpeed() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new RecoverySpeed
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
Speeds healing of recoverable damage (the red portion of the health gauge).
1: Doubles the speed at which you heal recoverable damage.
2: Triples the speed at which you heal recoverable damage.
3: Quadruples the speed at which you heal recoverable damage.";
    }
 }
            
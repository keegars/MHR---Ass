
namespace MHR___Ass.Data.Skills.SkillList
{
    public class RecoveryUp : Skill
    {
        public RecoveryUp(int value) : base(value)
        {
        }

        public RecoveryUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new RecoveryUp
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
Increases the amount recovered when restoring health.
1: Slightly increases recovery.
2: Increases recovery.
3: Greatly increases recovery.";
    }
 }
            
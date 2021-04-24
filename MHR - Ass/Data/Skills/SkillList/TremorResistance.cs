
namespace MHR___Ass.Data.Skills.SkillList
{
    public class TremorResistance : Skill
    {
        public TremorResistance(int value) : base(value)
        {
        }

        public TremorResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new TremorResistance
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
Grants protection against ground tremors.
1: Nullifies minor ground tremors.
2: Nullifies minor ground tremors and reduces the effects of major ground tremors.
3: Nullifies minor and major ground tremors.";
    }
 }
            
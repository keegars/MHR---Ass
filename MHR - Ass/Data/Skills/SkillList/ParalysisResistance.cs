
namespace MHR___Ass.Data.Skills.SkillList
{
    public class ParalysisResistance : Skill
    {
        public ParalysisResistance(int value) : base(value)
        {
        }

        public ParalysisResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ParalysisResistance
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
Reduces the duration of paralysis.
1: Reduces the duration of paralysis by 30%.
2: Reduces the duration of paralysis by 60%.
3: Prevents paralysis.";
    }
 }
            
namespace MHR___Ass.Data.Skills.SkillList
{
    public class BlastResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Grants protection against blastblight.
1: Delays blastblight and reduces blast damage.
2: Greatly delays blastblight and greatly reduces blast damage.
3: Prevents blastblight.";

        public BlastResistance(int value) : base(value)
        {
        }

        public BlastResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BlastResistance
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }
    }
}
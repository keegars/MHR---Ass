namespace MHR___Ass.Data.Skills.SkillList
{
    public class BlightResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Grants protection against all elemental blights.
1: Reduces the duration of all elemental blights by 50%.
2: Reduces the duration of all elemental blights by 75%.
3: Nullifies all elemental blights.";

        public BlightResistance(int value) : base(value)
        {
        }

        public BlightResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BlightResistance
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
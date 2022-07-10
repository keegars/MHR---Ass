namespace MHR___Ass.Data.Skills.SkillList
{
    public class Grinder_S : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
When recovering sharpness, grants a boost to sharpness properties based on the number of levels recovered.

1: Requires 3 tiers of sharpness, lasts 60 seconds
2: Requires 2 tiers sharpness, lasts 60 seconds
3: Requires 2 tiers of sharpness, lasts 90 seconds.
";

        public Grinder_S(int value) : base(value)
        {
        }

        public Grinder_S() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Grinder_S
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
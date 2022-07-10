namespace MHR___Ass.Data.Skills.SkillList
{
    public class Foray : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Increases attack power and affinity when attacking a large monster affected by poison, paralysis, or an elemental blight.

When attacking a poisoned/paralyzed/blighted monster gain Attack up by 10/15/25, Affinity up by 0/10/20%.
";

        public Foray(int value) : base(value)
        {
        }

        public Foray() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Foray
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
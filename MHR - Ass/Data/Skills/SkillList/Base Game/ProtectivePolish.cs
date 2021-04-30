namespace MHR___Ass.Data.Skills.SkillList
{
    public class ProtectivePolish : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Weapon sharpness does not decrease for a set time after sharpening.
1: Effect lasts 30 seconds.
2: Effect lasts 60 seconds.
3: Effect lasts 90 seconds.";

        public ProtectivePolish(int value) : base(value)
        {
        }

        public ProtectivePolish() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ProtectivePolish
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
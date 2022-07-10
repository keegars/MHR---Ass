namespace MHR___Ass.Data.Skills.SkillList
{
    public class BloodRite : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
A proportion of damage dealt is converted to health when striking a broken monster part.";

        public BloodRite(int value) : base(value)
        {
        }

        public BloodRite() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BloodRite
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
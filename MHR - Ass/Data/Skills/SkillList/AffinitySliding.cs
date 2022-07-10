namespace MHR___Ass.Data.Skills.SkillList
{
    public class AffinitySliding : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Sliding increases your affinity for a short time.
1: Enables skill use.";

        public AffinitySliding(int value) : base(value)
        {
        }

        public AffinitySliding() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new AffinitySliding
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
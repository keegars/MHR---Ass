namespace MHR___Ass.Data.Skills.SkillList
{
    public class CaptureMaster : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
High chance of increased capture rewards. (No effect when joining mid-quest.)
1: Activates skill effect.";

        public CaptureMaster(int value) : base(value)
        {
        }

        public CaptureMaster() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new CaptureMaster
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
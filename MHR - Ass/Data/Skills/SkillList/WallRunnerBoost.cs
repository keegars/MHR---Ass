namespace MHR___Ass.Data.Skills.SkillList
{
    public class WallRunnerBoost : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Wirebug Gauge recovers faster while wall running.";

        public WallRunnerBoost(int value) : base(value)
        {
        }

        public WallRunnerBoost() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WallRunnerBoost
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
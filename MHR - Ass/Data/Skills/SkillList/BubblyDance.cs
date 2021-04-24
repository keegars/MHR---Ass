namespace MHR___Ass.Data.Skills.SkillList
{
    public class BubblyDance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Reduces bubbleblight and grants increased evasion when afflicted.
1: Reduces the effects of weak bubbleblight.
2: Nullifies major and minor bubbleblight and increases evasiveness while afflicted with bubbleblight.
3: Evading further attacks will inflicts bubbleblight.";

        public BubblyDance(int value) : base(value)
        {
        }

        public BubblyDance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BubblyDance
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
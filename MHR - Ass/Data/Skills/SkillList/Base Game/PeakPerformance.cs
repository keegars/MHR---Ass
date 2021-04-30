namespace MHR___Ass.Data.Skills.SkillList
{
    public class PeakPerformance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases attack when your health is full.
1: Attack +5 while active.
2: Attack +10 while active.
3: Attack +20 while active.";

        public PeakPerformance(int value) : base(value)
        {
        }

        public PeakPerformance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new PeakPerformance
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
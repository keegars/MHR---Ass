namespace MHR___Ass.Data.Skills.SkillList
{
    public class HungerResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Reduces maximum stamina depletion over time.
1: Extends the time until your stamina cap reduces by 50%.
2: Extends the time until your stamina cap reduces by 100%.
3: Prevents your stamina cap from decreasing.";

        public HungerResistance(int value) : base(value)
        {
        }

        public HungerResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new HungerResistance
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
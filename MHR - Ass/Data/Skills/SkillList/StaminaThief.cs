namespace MHR___Ass.Data.Skills.SkillList
{
    public class StaminaThief : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases certain attacks' ability to exhaust monsters.
1: Exhaust power +20%
2: Exhaust power +30%
3: Exhaust power +40%";

        public StaminaThief(int value) : base(value)
        {
        }

        public StaminaThief() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new StaminaThief
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
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Guard : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Reduces knockbacks and stamina depletion when guarding.
1: Very slightly decreases the impact of attacks.
2: Slightly decreases the impact of attacks and reduces stamina depletion by 15%.
3: Decreases the impact of attacks and reduces stamina depletion by 15%.
4: Decreases the impact of attacks and reduces stamina depletion by 30%.
5: Greatly decreases the impact of attacks and reduces stamina depletion by 30%.";

        public Guard(int value) : base(value)
        {
        }

        public Guard() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Guard
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
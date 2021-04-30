namespace MHR___Ass.Data.Skills.SkillList
{
    public class Constitution : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Reduces stamina depletion when evading, blocking, or doing certain other actions.
1: Reduces fixed stamina depletion by 10%.
2: Reduces fixed stamina depletion by 20%.
3: Reduces fixed stamina depletion by 30%.
4: Reduces fixed stamina depletion by 40%.
5: Reduces fixed stamina depletion by 50%.";

        public Constitution(int value) : base(value)
        {
        }

        public Constitution() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Constitution
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
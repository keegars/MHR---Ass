namespace MHR___Ass.Data.Skills.SkillList
{
    public class MarathonRunner : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Slows down stamina depletion for actions which continuously drain stamina (such as dashing).
1: Reduces continuous stamina depletion by 15%.
2: Reduces continuous stamina depletion by 30%.
3: Reduces continuous stamina depletion by 50%.";

        public MarathonRunner(int value) : base(value)
        {
        }

        public MarathonRunner() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MarathonRunner
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
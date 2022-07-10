namespace MHR___Ass.Data.Skills.SkillList
{
    public class Dereliction : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Qurio will drain health, but also bolster your attacks. Multiple Qurio further bolster attacks and let you recover health when performing a Switch Skill Swap.

1. Red Scroll: Atk Up by 10/15/20, Stun Up by 0/5/10% Blue Scroll: Status and Element Up by 3/5/8
2. Red Scroll: Atk Up by 10/20/25, Stun Up by 0/10/15% Blue Scroll: Status and Element Up by 3/8/10
3. Red Scroll: Atk Up by 10/25/30, Stun Up by 0/10/20% Blue Scroll: Status and Element Up by 3/10/15
";

        public Dereliction(int value) : base(value)
        {
        }

        public Dereliction() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Dereliction
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
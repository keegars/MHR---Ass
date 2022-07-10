namespace MHR___Ass.Data.Skills.SkillList
{
    public class ChainCrit : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Continuously landing hits gradually increases attack and elemental attack. (The amount of increase depends on the weapon.)

1: Attack up by 10, Elemental Attack up by 4
2: Attack up by 12, Elemental Attack up by 6
3: Attack up by 15, Elemental Attack up by 8
";

        public ChainCrit(int value) : base(value)
        {
        }

        public ChainCrit() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ChainCrit
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
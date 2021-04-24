namespace MHR___Ass.Data.Skills.SkillList
{
    public class Focus : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases the fill rate for weapons with gauges and the charge rate for weapons with charge attacks.
1: 5% faster gauge fill rate and 5% faster charge times.
2: 10% faster gauge fill rate and 10% faster charge times.
3: 20% faster gauge fill rate and 15% faster charge times.";

        public Focus(int value) : base(value)
        {
        }

        public Focus() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Focus
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
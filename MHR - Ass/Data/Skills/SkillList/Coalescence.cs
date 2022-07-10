namespace MHR___Ass.Data.Skills.SkillList
{
    public class Coalescence : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Temporarily enhances attacks after recovering from blights or abnormal status.

1: 12 Atk /2 Element /5% Status
2: 15 Atk /3 Element /10% Status
3: 18 Atk/4 Element /15% Status

";

        public Coalescence(int value) : base(value)
        {
        }

        public Coalescence() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Coalescence
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
namespace MHR___Ass.Data.Skills.SkillList
{
    public class WideRange : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Allows the effects of certain items to also affect nearby allies.
1: Items affect nearby allies with 33% of their efficacy.
2: Items affect nearby allies in a wider radius with 33% of their efficacy.
3: Items affect nearby allies in a wider radius with 66% of their efficacy.
4: Items affect nearby allies in a much wider radius with 66% of their efficacy.
5: Items affect nearby allies in a much wider radius with full efficacy.";

        public WideRange(int value) : base(value)
        {
        }

        public WideRange() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WideRange
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

namespace MHR___Ass.Data.Skills.SkillList
{
    public class Wide_Range : Skill
    {
        public Wide_Range(int value) : base(value)
        {
        }

        public Wide_Range() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Wide_Range
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Allows the effects of certain items to also affect nearby allies.
1: Items affect nearby allies with 33% of their efficacy.
2: Items affect nearby allies in a wider radius with 33% of their efficacy.
3: Items affect nearby allies in a wider radius with 66% of their efficacy.
4: Items affect nearby allies in a much wider radius with 66% of their efficacy.
5: Items affect nearby allies in a much wider radius with full efficacy.";
    }
 }
            
namespace MHR___Ass.Data.Skills.SkillList
{
    public class MastersTouch : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Prevents your weapon from losing sharpness during critical hits.
1. Grants a 20% change of no sharpness loss while active.
2. Grants a 40% change of no sharpness loss while active.
3. Grants a 80% change of no sharpness loss while active.";

        public MastersTouch(int value) : base(value)
        {
        }

        public MastersTouch() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MastersTouch
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
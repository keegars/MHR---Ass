namespace MHR___Ass.Data.Skills.SkillList
{
    public class FlinchFree : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Prevents knockbacks and other reactions to small damage.
1: Prevents knockbacks.
2: Prevents knockbacks. Tripping is reduced to a knockback instead.
3: Prevents knockbacks and tripping.";

        public FlinchFree(int value) : base(value)
        {
        }

        public FlinchFree() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new FlinchFree
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
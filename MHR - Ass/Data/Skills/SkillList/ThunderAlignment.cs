namespace MHR___Ass.Data.Skills.SkillList
{
    public class ThunderAlignment : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Gain the power of the elder dragon Thunder Serpent Narwa.
1: Thunder resistance +1
2: Thunder resistance +2
3: Thunder resistance +3
4: Thunder resistance +4
5: Also grants the effect Fortunate.";

        public ThunderAlignment(int value) : base(value)
        {
        }

        public ThunderAlignment() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ThunderAlignment
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
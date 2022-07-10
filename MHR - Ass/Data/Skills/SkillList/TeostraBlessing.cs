namespace MHR___Ass.Data.Skills.SkillList
{
    public class TeostraBlessing : Skill
    {
        public override int MaxValue { get; set; } = 4;
        public override string Description { get; set; } = @"
Gain the power of the elder dragon Teostra.
1. Fire attack and blast buildup +5%
2. Fire attack and blast buildup + 10%
3. Also prevents poison and venom.
4. Also negates theft.";

        public TeostraBlessing(int value) : base(value)
        {
        }

        public TeostraBlessing() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new TeostraBlessing
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
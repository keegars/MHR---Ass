namespace MHR___Ass.Data.Skills.SkillList
{
    public class KushalaBlessing : Skill
    {
        public override int MaxValue { get; set; } = 4;
        public override string Description { get; set; } = @"
Gain the power of the elder dragon Kushala Daora
1. Water and ice attack +5%
2. Water and ice attack + 10%
3. Also allows recovery to exceed the red portion of the health gauge
4. Also nullifies head damage.";

        public KushalaBlessing(int value) : base(value)
        {
        }

        public KushalaBlessing() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new KushalaBlessing
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
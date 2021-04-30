namespace MHR___Ass.Data.Skills.SkillList
{
    public class ChameleosBlessing : Skill
    {
        public override int MaxValue { get; set; } = 4;
        public override string Description { get; set; } = @"
Gain the power of the elder dragon Chameleos.
1. Sometimes increases the effects of Spiribirds.
2. Also negates minor and major wind pressure.
3. Also extends the duration of your poison's effect on monsters.
4. Also negates all wind pressure.";

        public ChameleosBlessing(int value) : base(value)
        {
        }

        public ChameleosBlessing() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ChameleosBlessing
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
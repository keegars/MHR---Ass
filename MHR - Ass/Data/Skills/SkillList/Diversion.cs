namespace MHR___Ass.Data.Skills.SkillList
{
    public class Diversion : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Increases the attention drawn when attacking a monster.
1: Activates skill effect.";

        public Diversion(int value) : base(value)
        {
        }

        public Diversion() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Diversion
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
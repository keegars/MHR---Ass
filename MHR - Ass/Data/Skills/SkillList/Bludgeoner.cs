namespace MHR___Ass.Data.Skills.SkillList
{
    public class Bludgeoner : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases attack power when your weapon sharpness is low.
1: +5% attack power when your weapon sharpness gauge is yellow or lower.
2: +10% attack power when your sharpness gauge is yellow or lower.
3: +10% attack power when your sharpness gauge is green or lower.";

        public Bludgeoner(int value) : base(value)
        {
        }

        public Bludgeoner() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Bludgeoner
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
namespace MHR___Ass.Data.Skills.SkillList
{
    public class RapidMorph : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases switch speed and power for switch axes and charge blades.
1: Speed +10%
2: Speed +20% Morph attack damage +10%
3: Speed +30% Morph attack damage +20%";

        public RapidMorph(int value) : base(value)
        {
        }

        public RapidMorph() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new RapidMorph
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
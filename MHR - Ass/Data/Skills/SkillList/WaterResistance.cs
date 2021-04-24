namespace MHR___Ass.Data.Skills.SkillList
{
    public class WaterResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases water resistance. Also improves defense at higher levels.
1: Water resistance +6
2: Water resistance +12
3: Water resistance +20 Defense +10";

        public WaterResistance(int value) : base(value)
        {
        }

        public WaterResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WaterResistance
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
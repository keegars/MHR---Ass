namespace MHR___Ass.Data.Skills.SkillList
{
    public class DragonResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases dragon resistance. Also improves defense at higher levels.
1: Dragon resistance +6
2: Dragon resistance +12
3: Dragon resistance +20 Defense +10";

        public DragonResistance(int value) : base(value)
        {
        }

        public DragonResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new DragonResistance
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
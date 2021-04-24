namespace MHR___Ass.Data.Skills.SkillList
{
    public class FireResistance : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases fire resistance. Also improves defense at higher levels.
1: Fire resistance +6
2: Fire resistance +12
3: Fire resistance +20 Defense +10";

        public FireResistance(int value) : base(value)
        {
        }

        public FireResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new FireResistance
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
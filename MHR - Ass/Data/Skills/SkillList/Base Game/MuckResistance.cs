namespace MHR___Ass.Data.Skills.SkillList
{
    public class MuckResistance : Skill
    {
        public override int MaxValue { get; set; } = 2;
        public override string Description { get; set; } = @"
Reduces impairments to mobility while stuck in monster muck or deep snow.
1: Reduces limits on movement speed.
2: Negates limits to movement speed.";

        public MuckResistance(int value) : base(value)
        {
        }

        public MuckResistance() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MuckResistance
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
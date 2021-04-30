namespace MHR___Ass.Data.Skills.SkillList
{
    public class HellfireCloak : Skill
    {
        public override int MaxValue { get; set; } = 4;
        public override string Description { get; set; } = @"
Grants hellfire resistance and confers explosive hellfire power to your attacks.
1: Reduces damage from hellfire.
2: Increases damage from hellfire blasts.
3: Inflicts hellfireblight when monsters are enraged.
4: Effect persists for one minute after a monster's rage has subsided.";

        public HellfireCloak(int value) : base(value)
        {
        }

        public HellfireCloak() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new HellfireCloak
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
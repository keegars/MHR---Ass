namespace MHR___Ass.Data.Skills.SkillList
{
    public class Windproof : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Grants protection against wind pressure.
1: Negates minor wind pressure.
2: Negates minor and major wind pressure.
3: Negates minor and major wind pressure and reduces the effects of dragon wind pressure.";

        public Windproof(int value) : base(value)
        {
        }

        public Windproof() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Windproof
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
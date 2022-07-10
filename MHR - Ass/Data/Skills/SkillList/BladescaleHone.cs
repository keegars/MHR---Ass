namespace MHR___Ass.Data.Skills.SkillList
{
    public class BladescaleHone : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Dodge rolling to evade an attack with your weapon drawn will recover sharpness, refill bowgun ammo, or give Close-range Coatings a temporary boost.";

        public BladescaleHone(int value) : base(value)
        {
        }

        public BladescaleHone() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new BladescaleHone
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
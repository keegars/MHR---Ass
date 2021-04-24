namespace MHR___Ass.Data.Skills.SkillList
{
    public class AimBooster : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Shortens the distance before ammo and arrows reach maximum power.
1: Slightly extends range.
2: Extends range.
3: Greatly extends range.";

        public AimBooster(int value) : base(value)
        {
        }

        public AimBooster() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new AimBooster
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
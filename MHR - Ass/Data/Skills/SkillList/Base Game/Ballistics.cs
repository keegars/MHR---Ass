namespace MHR___Ass.Data.Skills.SkillList
{
    public class Ballistics : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Shortens the distance before ammo and arrows reach maximum power.
1: Slightly extends range.
2: Extends range.
3: Greatly extends range.";

        public Ballistics(int value) : base(value)
        {
        }

        public Ballistics() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Ballistics
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
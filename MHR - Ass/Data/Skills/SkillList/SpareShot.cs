namespace MHR___Ass.Data.Skills.SkillList
{
    public class SpareShot : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Bow and bowgun shots have a chance not to expend coatings or ammo.
1: Activates 3% of the time.
2: Activates 10% of the time.
3: Activates 20% of the time.";

        public SpareShot(int value) : base(value)
        {
        }

        public SpareShot() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SpareShot
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
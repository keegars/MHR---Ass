namespace MHR___Ass.Data.Skills.SkillList
{
    public class Heroics : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases attack power and defense when health drops to 35% or lower.
1: While active, increases defense by 50 points.
2: Attack +5% and defense +50 while active.
3: Attack +5% and defense +100 while active.
4: Attack +10% and defense +100 while active.
5: While active, attack power +30% and defense-increasing effects are negated.";

        public Heroics(int value) : base(value)
        {
        }

        public Heroics() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Heroics
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
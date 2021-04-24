namespace MHR___Ass.Data.Skills.SkillList
{
    public class AttackBoost : Skill
    {
        public override int MaxValue { get; set; } = 7;
        public override string Description { get; set; } = @"
Increases attack power.
1: Attack +3
2: Attack +6
3: Attack +9
4: Attack +5% Bonus: +7
5: Attack +6% Bonus: +8
6: Attack +8% Bonus: +9
7: Attack +10% Bonus: +10";

        public AttackBoost(int value) : base(value)
        {
        }

        public AttackBoost() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new AttackBoost
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
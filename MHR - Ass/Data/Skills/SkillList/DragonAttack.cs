namespace MHR___Ass.Data.Skills.SkillList
{
    public class DragonAttack : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases dragon element attack power. (Elemental attack power has a maximum limit.)
1: Dragon attack +2
2: Dragon attack +3
3: Dragon attack +5% Bonus: +4
4: Dragon attack +10% Bonus: +4
5: Dragon attack +20% Bonus: +4";

        public DragonAttack(int value) : base(value)
        {
        }

        public DragonAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new DragonAttack
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
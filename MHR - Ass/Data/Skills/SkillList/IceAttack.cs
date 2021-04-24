namespace MHR___Ass.Data.Skills.SkillList
{
    public class IceAttack : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases ice element attack power. (Elemental attack power has a maximum limit.)
1: Ice attack +2
2: Ice attack +3
3: Ice attack +5% Bonus: +4
4: Ice attack +10% Bonus: +4
5: Ice attack +20% Bonus: +4";

        public IceAttack(int value) : base(value)
        {
        }

        public IceAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new IceAttack
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
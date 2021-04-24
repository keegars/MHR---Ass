
namespace MHR___Ass.Data.Skills.SkillList
{
    public class FireAttack : Skill
    {
        public FireAttack(int value) : base(value)
        {
        }

        public FireAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new FireAttack
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Increases fire element attack power. (Elemental attack power has a maximum limit.)
1: Fire attack +2
2: Fire attack +3
3: Fire attack +5% Bonus: +4
4: Fire attack +10% Bonus: +4
5: Fire attack +20% Bonus: +4";
    }
 }
            

namespace MHR___Ass.Data.Skills.SkillList
{
    public class SleepAttack : Skill
    {
        public SleepAttack(int value) : base(value)
        {
        }

        public SleepAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new SleepAttack
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases sleep element attack power. (Elemental attack power has a maximum limit.)
1: Sleep buildup +5% Bonus: +1
2: Sleep buildup +10% Bonus: +2
3: Sleep buildup +20% Bonus: +5";
    }
 }
            
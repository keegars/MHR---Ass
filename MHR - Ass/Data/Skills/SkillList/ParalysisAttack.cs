
namespace MHR___Ass.Data.Skills.SkillList
{
    public class ParalysisAttack : Skill
    {
        public ParalysisAttack(int value) : base(value)
        {
        }

        public ParalysisAttack() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ParalysisAttack
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
Increases paralysis element attack power. (Elemental attack power has a maximum limit.)
1: Paralysis buildup +5% Bonus: +1
2: Paralysis buildup +10% Bonus: +2
3: Paralysis buildup +20% Bonus: +5";
    }
 }
            
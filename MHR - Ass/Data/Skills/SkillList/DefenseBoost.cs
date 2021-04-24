
namespace MHR___Ass.Data.Skills.SkillList
{
    public class DefenseBoost : Skill
    {
        public DefenseBoost(int value) : base(value)
        {
        }

        public DefenseBoost() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new DefenseBoost
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 7;
        public override string Description { get; set; } = @"
Increases defense. Resistances will also improve as the level increases.
1: Defense +5
2: Defense +10
3: Defense +5% Bonus: +10
4: Defense +5% Bonus: +20 All elemental resistances +3
5: Defense +8% Bonus: +20 All elemental resistances +3
6: Defense +8% Bonus: +35 All elemental resistances +5
7: Defense +10% Bonus: +35 All elemental resistances +5";
    }
 }
            

namespace MHR___Ass.Data.Skills.SkillList
{
    public class CriticalBoost : Skill
    {
        public CriticalBoost(int value) : base(value)
        {
        }

        public CriticalBoost() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new CriticalBoost
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
Increases the damage of critical hits.
1: Increases damage dealt by critical hits to 30%.
2: Increases damage dealt by critical hits to 35%.
3: Increases damage dealt by critical hits to 40%.";
    }
 }
            
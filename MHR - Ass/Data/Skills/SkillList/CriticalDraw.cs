
namespace MHR___Ass.Data.Skills.SkillList
{
    public class CriticalDraw : Skill
    {
        public CriticalDraw(int value) : base(value)
        {
        }

        public CriticalDraw() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new CriticalDraw
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
Increases affinity for a short time after performing a draw attack. (Does not include Silkbind attacks.)
1: Affinity +10%
2: Affinity +20%
3: Affinity +40%";
    }
 }
            
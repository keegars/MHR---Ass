
namespace MHR___Ass.Data.Skills.SkillList
{
    public class WindAlignment : Skill
    {
        public WindAlignment(int value) : base(value)
        {
        }

        public WindAlignment() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new WindAlignment
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
Gain the power of the elder dragon Wind Serpent Ibushi.
1: Dragon resistance +1
2: Dragon resistance +2
3: Dragon resistance +3
4: Dragon resistance +4
5: Also grants the effect Fortunate.";
    }
 }
            
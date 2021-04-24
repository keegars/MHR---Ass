
namespace MHR___Ass.Data.Skills.SkillList
{
    public class LatentPower : Skill
    {
        public LatentPower(int value) : base(value)
        {
        }

        public LatentPower() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new LatentPower
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
Temporarily increases affinity and reduces stamina depletion when certain conditions are met.
1: While active, increases affinity by 10% and reduces stamina depletion by 30%.
2: While active, increases affinity by 20% and reduces stamina depletion by 30%.
3: While active, increases affinity by 30% and reduces stamina depletion by 50%.
4: While active, increases affinity by 40% and reduces stamina depletion by 50%.
5: While active, increases affinity by 50% and reduces stamina depletion by 50%.";
    }
 }
            
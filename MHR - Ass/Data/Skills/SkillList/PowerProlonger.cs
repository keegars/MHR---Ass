
namespace MHR___Ass.Data.Skills.SkillList
{
    public class PowerProlonger : Skill
    {
        public PowerProlonger(int value) : base(value)
        {
        }

        public PowerProlonger() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new PowerProlonger
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
Long swords, dual blades, insect glaives, switch axes, and charge blades stay powered up longer.
1: Slightly boosts the duration weapons are powered up.
2: Boosts the duration weapons are powered up.
3: Greatly boosts the duration weapons are powered up.";
    }
 }
            
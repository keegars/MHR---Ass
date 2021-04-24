
namespace MHR___Ass.Data.Skills.SkillList
{
    public class NormalRapidUp : Skill
    {
        public NormalRapidUp(int value) : base(value)
        {
        }

        public NormalRapidUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new NormalRapidUp
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
Increases the attack power of Normal Ammo and Rapid-type arrows.
1: Slightly increases the power of Normal Ammo and Rapid-type arrows.
2: Increases the power of Normal Ammo and Rapid-type arrows.
3: Greatly increases the power of Normal Ammo and Rapid-type arrows.";
    }
 }
            
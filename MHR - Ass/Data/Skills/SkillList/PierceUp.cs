
namespace MHR___Ass.Data.Skills.SkillList
{
    public class PierceUp : Skill
    {
        public PierceUp(int value) : base(value)
        {
        }

        public PierceUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new PierceUp
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
Increases the attack power of Piercing Ammo and Piercing-type arrows.
1: Slightly increases the power of Piercing Ammo and Piercing-type arrows.
2: Increases the power of Piercing Ammo and Piercing-type arrows.
3: Greatly increases the power of Piercing Ammo and Piercing-type arrows.";
    }
 }
            
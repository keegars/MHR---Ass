
namespace MHR___Ass.Data.Skills.SkillList
{
    public class StaminaSurge : Skill
    {
        public StaminaSurge(int value) : base(value)
        {
        }

        public StaminaSurge() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new StaminaSurge
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
Speeds up stamina recovery.
1: Stamina recovery speed +10%
2: Stamina recovery speed +20%
3: Stamina recovery speed +40%";
    }
 }
            
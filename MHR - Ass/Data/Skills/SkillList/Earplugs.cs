
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Earplugs : Skill
    {
        public Earplugs(int value) : base(value)
        {
        }

        public Earplugs() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Earplugs
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
Grants protection from large monsters' roars.
1: Reduces the effects of weak monster roars.
2: Nullifies weak monster roars.
3: Nullifies weak monster roars and reduces the effects of strong monster roars.
4: Nullifies weak and strong monster roars.
5: Nullifies weak and strong monster roars. Reduces the effects of powerful monster roars.";
    }
 }
            
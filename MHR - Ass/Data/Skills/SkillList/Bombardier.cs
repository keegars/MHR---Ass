
namespace MHR___Ass.Data.Skills.SkillList
{
    public class Bombardier : Skill
    {
        public Bombardier(int value) : base(value)
        {
        }

        public Bombardier() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Bombardier
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
Increases the damage of explosive items.
1: Explosive power +10%
2: Explosive power +20%
3: Explosive power +30%";
    }
 }
            
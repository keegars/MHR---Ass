
namespace MHR___Ass.Data.Skills.SkillList
{
    public class DivineBlessing : Skill
    {
        public DivineBlessing(int value) : base(value)
        {
        }

        public DivineBlessing() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new DivineBlessing
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
Has a predetermined chance of reducing the damage you take.
1: While active, reduces damage taken by 15%.
2: While active, reduces damage taken by 30%.
3: While active, reduces damage taken by 50%.";
    }
 }
            
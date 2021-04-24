
namespace MHR___Ass.Data.Skills.SkillList
{
    public class MindsEye : Skill
    {
        public MindsEye(int value) : base(value)
        {
        }

        public MindsEye() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new MindsEye
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
Your attacks are deflected less and deal more damage to hard targets.
1: +10% damage to hard targets and a 50% reduction to your attacks being deflected.
2: +15% damage to hard targets and a 100% reduction to your attacks being deflected.
3: +30% damage to hard targets and a 100% reduction to your attacks being deflected.";
    }
 }
            
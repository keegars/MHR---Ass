
namespace MHR___Ass.Data.Skills.SkillList
{
    public class HornMaestro : Skill
    {
        public HornMaestro(int value) : base(value)
        {
        }

        public HornMaestro() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new HornMaestro
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Increases overall performance speed and shockwave damage.
1: Activates skill effect.";
    }
 }
            
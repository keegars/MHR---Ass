
namespace MHR___Ass.Data.Skills.SkillList
{
    public class LoadShells : Skill
    {
        public LoadShells(int value) : base(value)
        {
        }

        public LoadShells() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new LoadShells
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }

        public override int MaxValue { get; set; } = 2;
        public override string Description { get; set; } = @"
Improves reloading, and increases the gunlance's shell capacity and charge blade's phial capacity.
1: Increases ammo and coating reloading speed.
2: Gunlance loading capacity +1 Increases charge blade phials";
    }
 }
            
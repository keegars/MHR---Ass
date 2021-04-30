namespace MHR___Ass.Data.Skills.SkillList
{
    public class JumpMaster : Skill
    {
        public override int MaxValue { get; set; } = 1;
        public override string Description { get; set; } = @"
Prevents attacks from knocking you back during a jump.
1: Negates knockback during jumps.";

        public JumpMaster(int value) : base(value)
        {
        }

        public JumpMaster() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new JumpMaster
            {
                Description = Description,
                MaxValue = MaxValue,
                Name = Name,
                Value = value
            };

            return tmp;
        }
    }
}
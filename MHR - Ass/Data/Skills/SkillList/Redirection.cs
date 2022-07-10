namespace MHR___Ass.Data.Skills.SkillList
{
    public class Redirection : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Perform a perfectly-timed Switch Skill Swap just as a monster attacks to reduce the damage and negate damage reactions.

1: Grants a 'guard point' when performing a Skill Swap
2: Perform an automatic evade when activating the 'guard point' and recover half a wirebug.
3: You are no longer forced to perform an evade, restore half a wirebug.

";

        public Redirection(int value) : base(value)
        {
        }

        public Redirection() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Redirection
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
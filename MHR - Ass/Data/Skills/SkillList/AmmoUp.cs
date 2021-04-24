namespace MHR___Ass.Data.Skills.SkillList
{
    public class AmmoUp : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases bowgun loading capacity. (There is a cap to loading capacity.)
1: Expands clip size for some ammo types.
2: Expands clip size for many ammo types.
3: Expands clip size for most ammo types.";

        public AmmoUp(int value) : base(value)
        {
        }

        public AmmoUp() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new AmmoUp
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
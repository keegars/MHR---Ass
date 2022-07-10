namespace MHR___Ass.Data.Skills.SkillList
{
    public class ReloadSpeed : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Increases bowgun reloading and bow coating loading speed.
1: Bowgun speed +1. Improves bow handling.
2: Bowgun speed +2. Loads bow coating automatically.
3: Bowgun speed +3.";

        public ReloadSpeed(int value) : base(value)
        {
        }

        public ReloadSpeed() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new ReloadSpeed
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
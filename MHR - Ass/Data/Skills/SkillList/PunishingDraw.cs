namespace MHR___Ass.Data.Skills.SkillList
{
    public class PunishingDraw : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
Adds a stun effect to draw attacks and slightly increases attack power. (Does not include Silkbind attacks.)
1: Applies a minor chance to stun. Attack power of draw attacks +3
2: Applies a chance to stun. Attack power of draw attacks +5
3: Applies a great chance to stun. Attack power of draw attacks +7";

        public PunishingDraw(int value) : base(value)
        {
        }

        public PunishingDraw() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new PunishingDraw
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
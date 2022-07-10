namespace MHR___Ass.Data.Skills.SkillList
{
    public class Bloodlust : Skill
    {
        public override int MaxValue { get; set; } = 3;
        public override string Description { get; set; } = @"
The effects of the Frenzy virus change. Health is gradually reduced, but you gain a variety of effects. Frenzy virus occurs regularly when in combat.

1: with the Virus: +10 Atk, +5 Element/Status, -10% Stamina Consumed, Evade Window 1; after overcoming the Virus: +20% Affinity for 60 seconds.
2: with the Virus: +15 Atk, +7 Element/Status, -20% Stamina Consumed, Evade Window 2; after overcoming the Virus: +25% Affinity for 60 seconds.
3: with the Virus: +20 Atk, +10 Element/Status, -30% Stamina Consumed, Evade Window 3; after overcoming the Virus: +25% Affinity for 90 seconds.
";

        public Bloodlust(int value) : base(value)
        {
        }

        public Bloodlust() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Bloodlust
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
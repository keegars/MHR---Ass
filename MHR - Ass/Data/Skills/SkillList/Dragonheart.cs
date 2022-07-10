namespace MHR___Ass.Data.Skills.SkillList
{
    public class Dragonheart : Skill
    {
        public override int MaxValue { get; set; } = 5;
        public override string Description { get; set; } = @"
Draconic energy fills you after losing a certain amount of health. Weapons lose all non-dragon effects.

Lv 1 When your health is at 50% or less, you contract dragonblight, and all elemental resistances are set to 30.
Lv 2 When your health is at 50% or less, you contract dragonblight, and all elemental resistances are set to 50.
Lv 3 When your health is at 70% or less, you contract dragonblight, and all elemental resistances are set to 50.
Lv 4 Contract dragonblight when at 70% health or less. Sets Elemental resistances to 50 and gain +5% attack power.
Lv 5 Contract dragonblight when at 80% health or less. Sets Elemental resistances to 50 and gain +10% attack power.";

        public Dragonheart(int value) : base(value)
        {
        }

        public Dragonheart() : base()
        {
        }

        public override Skill Clone(int value)
        {
            var tmp = new Dragonheart
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
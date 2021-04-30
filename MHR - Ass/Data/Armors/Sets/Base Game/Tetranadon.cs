using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Tetranadon : ArmorSet
    {
        public Tetranadon()
        {
            Name = "Tetranadon";

            //Base values
            BaseDefense = 18;
            Fire.Value = -1;
            Water.Value = 4;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new SpeedEating(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new NormalRapidUp(1));

            Arm = new ArmArmor(this)
                .AddSkill(new SpecialAmmoBoost(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Heroics(1));

            Leg = new LegArmor(this)
                .AddSkill(new HungerResistance(1));
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Sinister : ArmorSet
    {
        public Sinister()
        {
            Name = "Sinister";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = -3;
            Ice.Value = 1;
            Thunder.Value = -2;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Resentment(1))
                .AddSkill(new Counterstrike(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new HellfireCloak(1))
                .AddSkill(new Resentment(1));

            Arm = new ArmArmor(this)
                .AddSkill(new HellfireCloak(1));

            Waist = new WaistArmor(this)
                .AddSkill(new HellfireCloak(1))
                .AddSkill(new Counterstrike(1));

            Leg = new LegArmor(this)
                .AddSkill(new Resentment(1));
        }
    }
}
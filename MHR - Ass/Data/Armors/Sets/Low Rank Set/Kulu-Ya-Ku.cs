using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KuluYaKu : ArmorSet
    {
        public KuluYaKu()
        {
            Name = "Kulu-Ya-Ku";

            ArmorRank = ArmorRank.Low;

            //Base values
            BaseDefense = 68;
            Fire.Value = 0;
            Water.Value = -3;
            Ice.Value = 1;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new MaximumMight(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new HornMaestro(1));

            Arm = new ArmArmor(this)
                .AddSkill(new Slugger(1));

            Waist = new WaistArmor(this)
                .AddSkill(new StaminaThief(1));

            Leg = new LegArmor(this)
                .AddSkill(new StunResistance(1))
                .AddSkill(new CriticalEye(1));
        }
    }
}
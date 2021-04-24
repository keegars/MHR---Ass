using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Edel : ArmorSet
    {
        public Edel()
        {
            Name = "Edel";
            

            //Base values
            BaseDefense = 12;
            Fire.Value = -1;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonResistance(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new RecoveryUp(1));

            Arm = new ArmArmor(this)
                .AddSkill(new PoisonResistance(1));

            Waist = new WaistArmor(this)
                .AddSkill(new ThunderResistance(1));

            Leg = new LegArmor(this)
                .AddSkill(new ThunderResistance(1));
        }
    }
}
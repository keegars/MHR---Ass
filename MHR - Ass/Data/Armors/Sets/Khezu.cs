using MHR___Ass.Data.Skills.SkillList;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Khezu : ArmorSet
    {
        public Khezu()
        {
            Name = "Khezu";
            

            //Base values
            BaseDefense = 16;
            Fire.Value = -4;
            Water.Value = 1;
            Ice.Value = 2;
            Thunder.Value = 4;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RecoveryUp(1));

            Torso = new TorsoArmor(this)
                .AddSkill(new WallRunner(1));

            Arm = new ArmArmor(this)
                .AddSkill(new WallRunner(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new ThunderAttack(1));

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1));

            Leg = new LegArmor(this)
                .AddSkill(new RecoverySpeed(1));
        }
    }
}
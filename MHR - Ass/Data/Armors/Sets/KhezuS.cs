using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KhezuS : ArmorSet
    {
        public KhezuS()
        {
            Name = "Khezu S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 38;
            Fire.Value = -4;
            Water.Value = 1;
            Ice.Value = 2;
            Thunder.Value = 4;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WallRunner(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WallRunner(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new ThunderAttack(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}
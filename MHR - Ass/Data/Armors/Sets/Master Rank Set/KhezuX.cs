using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KhezuX : ArmorSet
    {
        public KhezuX()
        {
            Name = "Khezu X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 104;
            Fire.Value = -4;
            Water.Value = 1;
            Ice.Value = 2;
            Thunder.Value = 4;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new RecoveryUp(1))
                .AddSkill(new ThunderAttack(1))
                .AddSlot(new ExtraLargeSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WallRunner(2))
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WallRunner(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSkill(new ThunderAttack(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new Slugger(1))
                .AddSkill(new RecoverySpeed(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}
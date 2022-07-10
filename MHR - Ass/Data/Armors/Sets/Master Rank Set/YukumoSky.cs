using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class YukumoSky : ArmorSet
    {
        public YukumoSky()
        {
            Name = "Yukumo Sky";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 100;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Earplugs(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalEye(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());
        }
    }
}
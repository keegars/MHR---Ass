using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class KamuraS : ArmorSet
    {
        public KamuraS()
        {
            Name = "Kamura S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 30;
            Fire.Value = 2;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new DivineBlessing(1))
                .AddSkill(new Resuscitate(1))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WirebugWhisperer(2))
                .AddSkill(new WallRunner(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalEye(2))
                .AddSkill(new Heroics(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WirebugWhisperer(1))
                .AddSkill(new CriticalEye(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WallRunner(2))
                .AddSkill(new Resuscitate(1))
                .AddSlot(new SmallSlot());
        }
    }
}
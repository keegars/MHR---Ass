using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class EdelS : ArmorSet
    {
        public EdelS()
        {
            Name = "Edel S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 40;
            Fire.Value = -1;
            Water.Value = 3;
            Ice.Value = 0;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new PoisonResistance(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RecoveryUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CaptureMaster(1));

            Waist = new WaistArmor(this)
                .AddSkill(new RecoveryUp(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PoisonResistance(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}
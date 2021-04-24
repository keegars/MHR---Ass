using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class VaikS : ArmorSet
    {
        public VaikS()
        {
            Name = "Vaik S";
            
            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 52;
            Fire.Value = 0;
            Water.Value = 3;
            Ice.Value = -1;
            Thunder.Value = -2;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new AmmoUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new NormalRapidUp(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new NormalRapidUp(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new AmmoUp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}
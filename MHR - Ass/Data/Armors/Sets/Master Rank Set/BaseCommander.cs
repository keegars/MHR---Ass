using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class BaseCommander : ArmorSet
    {
        public BaseCommander()
        {
            Name = "Base Commander";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 136;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WideRange(4))
                .AddSkill(new ChargeMaster(4))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new Focus(3))
                .AddSkill(new CriticalDraw(3))
                .AddSlot(new LargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new ChargeMaster(2))
                .AddSkill(new QuickSheath(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new PunishingDraw(3))
                .AddSkill(new QuickSheath(3))
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new CriticalDraw(2))
                .AddSkill(new QuickSheath(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());
        }
    }
}
using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class GossHaragS : ArmorSet
    {
        public GossHaragS()
        {
            Name = "Goss Harag S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 64;
            Fire.Value = -4;
            Water.Value = 1;
            Ice.Value = 4;
            Thunder.Value = -1;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new CriticalDraw(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new CriticalDraw(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new CriticalDraw(1))
                .AddSkill(new PunishingDraw(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new PunishingDraw(1))
                .AddSkill(new Resentment(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new PunishingDraw(1))
                .AddSkill(new Agitator(3))
                .AddSlot(new SmallSlot());
        }
    }
}
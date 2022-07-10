using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class ChannelerS : ArmorSet
    {
        public ChannelerS()
        {
            Name = "Channeler S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 72;
            Fire.Value = 3;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RazorSharp(2))
                .AddSkill(new SpareShot(2))
                .AddSkill(new WirebugWhisperer(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RazorSharp(1))
                .AddSkill(new SpareShot(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new WirebugWhisperer(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Agitator(2))
                .AddSkill(new WirebugWhisperer(2))
                .AddSlot(new SmallSlot());

            Leg = new LegArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Agitator(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());
        }
    }
}
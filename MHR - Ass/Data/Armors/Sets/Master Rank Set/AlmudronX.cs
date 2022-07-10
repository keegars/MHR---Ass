using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AlmudronX : ArmorSet
    {
        public AlmudronX()
        {
            Name = "Almudron X";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 116;
            Fire.Value = -4;
            Water.Value = 3;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RapidMorph(2))
                .AddSkill(new PowerProlonger(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RazorSharp(2))
                .AddSkill(new PowerProlonger(2))
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new EvadeWindow(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new EvadeWindow(2))
                .AddSkill(new PowerProlonger(2))
                .AddSkill(new SpareShot(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RazorSharp(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new SpareShot(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new ExtraLargeSlot());
        }
    }
}
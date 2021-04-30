using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class AlmudronS : ArmorSet
    {
        public AlmudronS()
        {
            Name = "Almudron S";

            ArmorRank = ArmorRank.High;

            //Base values
            BaseDefense = 64;
            Fire.Value = -4;
            Water.Value = 3;
            Ice.Value = -2;
            Thunder.Value = 3;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new RapidMorph(2))
                .AddSlot(new MediumSlot())
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RazorSharp(2))
                .AddSkill(new PowerProlonger(1))
                .AddSlot(new SmallSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new EvadeWindow(2))
                .AddSlot(new SmallSlot())
                .AddSlot(new SmallSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new PowerProlonger(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RazorSharp(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new LargeSlot());
        }
    }
}
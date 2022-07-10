using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class Dignified : ArmorSet
    {
        public Dignified()
        {
            Name = "Dignified";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 128;
            Fire.Value = 1;
            Water.Value = 1;
            Ice.Value = 1;
            Thunder.Value = 1;
            Dragon.Value = 1;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new Focus(2))
                .AddSkill(new PowerProlonger(2))
                .AddSkill(new EvadeExtender(2))
                .AddSlot(new SmallSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new EvadeExtender(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new RazorSharp(1))
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new Focus(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new RazorSharp(1))
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new RapidMorph(1))
                .AddSkill(new PowerProlonger(1))
                .AddSkill(new RazorSharp(1))
                .AddSlot(new ExtraLargeSlot());
        }
    }
}
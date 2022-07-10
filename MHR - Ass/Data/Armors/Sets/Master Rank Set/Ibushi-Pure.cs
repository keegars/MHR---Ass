using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class IbushiPure : ArmorSet
    {
        public IbushiPure()
        {
            Name = "Ibushi - Pure";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 140;
            Fire.Value = -1;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = -2;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new WindAlignment(1))
                .AddSkill(new Focus(1))
                .AddSkill(new EvadeExtender(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Torso = new TorsoArmor(this)
                .AddSkill(new WindAlignment(1))
                .AddSkill(new Guard(1))
                .AddSkill(new FlinchFree(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new WindAlignment(1))
                .AddSkill(new Constitution(1))
                .AddSkill(new StaminaSurge(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new WindAlignment(1))
                .AddSkill(new PowerProlonger(1))
                .AddSkill(new EvadeWindow(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());

            Leg = new LegArmor(this)
                .AddSkill(new WindAlignment(1))
                .AddSkill(new Slugger(1))
                .AddSkill(new GuardUp(1))
                .AddSkill(new Stormsoul(1))
                .AddSlot(new MediumSlot());
        }
    }
}
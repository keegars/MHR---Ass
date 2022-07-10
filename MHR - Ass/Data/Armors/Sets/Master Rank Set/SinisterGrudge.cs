using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Armors.Sets
{
    public class SinisterGrudge : ArmorSet
    {
        public SinisterGrudge()
        {
            Name = "Sinister Grudge";

            ArmorRank = ArmorRank.Master;

            //Base values
            BaseDefense = 142;
            Fire.Value = 0;
            Water.Value = 0;
            Ice.Value = 0;
            Thunder.Value = 0;
            Dragon.Value = 0;

            //Armor skills/slots

            Head = new HeadArmor(this)
                .AddSkill(new HellfireCloak(2))
                .AddSkill(new Coalescence(2))
                .AddSkill(new Redirection(2));

            Torso = new TorsoArmor(this)
                .AddSkill(new MailOfHellfire(1))
                .AddSkill(new WirebugWhisperer(1))
                .AddSlot(new SmallSlot())
                .AddSlot(new ExtraLargeSlot());

            Arm = new ArmArmor(this)
                .AddSkill(new MailOfHellfire(1))
                .AddSkill(new Counterstrike(1))
                .AddSkill(new Redirection(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Waist = new WaistArmor(this)
                .AddSkill(new MailOfHellfire(1))
                .AddSkill(new Coalescence(1))
                .AddSlot(new MediumSlot())
                .AddSlot(new LargeSlot());

            Leg = new LegArmor(this)
                .AddSkill(new HellfireCloak(2))
                .AddSkill(new Counterstrike(2))
                .AddSkill(new WirebugWhisperer(2));
        }
    }
}
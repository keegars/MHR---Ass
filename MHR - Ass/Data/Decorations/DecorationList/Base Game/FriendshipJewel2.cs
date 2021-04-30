using MHR___Ass.Data.Skills.SkillList;
using MHR___Ass.Data.Slots;

namespace MHR___Ass.Data.Decorations.DecorationList
{
    public class FriendshipJewel2 : Decoration
    {
        public FriendshipJewel2()
        {
            Name = "Friendship Jewel 2";
            Skill = new Wide_Range(1);
            Type = SlotType.Medium;
        }
    }
}
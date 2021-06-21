using System;
using Il2CppDummyDll;
using Serialize;

namespace MonsterHut
{
	// Token: 0x02000F03 RID: 3843
	[Token(Token = "0x20009D4")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x149750", Offset = "0x149851")]
	public class FriendMonsterIDAndHouseID : KeyAndValue<int, uint>
	{
		// Token: 0x060064D2 RID: 25810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x1E610F0", Offset = "0x1E611F1", VA = "0x1E610F0")]
		public FriendMonsterIDAndHouseID(int houseID, uint friendMonsterID)
		{
		}
	}
}

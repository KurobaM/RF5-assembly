using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MonsterHut
{
	// Token: 0x02000EFB RID: 3835
	[Token(Token = "0x20009D2")]
	public interface MonsterHutAreaInterface
	{
		// Token: 0x060064A1 RID: 25761
		[Token(Token = "0x60053A7")]
		int GetFreePointIndex();

		// Token: 0x060064A2 RID: 25762
		[Token(Token = "0x60053A8")]
		void LockPointIndex(int index);

		// Token: 0x060064A3 RID: 25763
		[Token(Token = "0x60053A9")]
		void RelesePointIndex(int index);

		// Token: 0x060064A4 RID: 25764
		[Token(Token = "0x60053AA")]
		void UpdateLoveLv(int index, int loveLv);

		// Token: 0x060064A5 RID: 25765
		[Token(Token = "0x60053AB")]
		bool IsMostLoveLvMonster(int index);

		// Token: 0x060064A6 RID: 25766
		[Token(Token = "0x60053AC")]
		Transform GetPointTransfrom(int index);
	}
}

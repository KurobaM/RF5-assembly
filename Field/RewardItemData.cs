using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200113C RID: 4412
	[Token(Token = "0x2000B1B")]
	[Serializable]
	public class RewardItemData
	{
		// Token: 0x06006FA9 RID: 28585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0x202F930", Offset = "0x202FA31", VA = "0x202F930")]
		public RewardItemData()
		{
		}

		// Token: 0x06006FAA RID: 28586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x20305E0", Offset = "0x20306E1", VA = "0x20305E0")]
		public RewardItemData(int itemId, int amount, int level)
		{
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x202FBE0", Offset = "0x202FCE1", VA = "0x202FBE0")]
		public void SetData(int itemId, int amount, int level)
		{
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x202FDC0", Offset = "0x202FEC1", VA = "0x202FDC0")]
		public void ClearData()
		{
		}

		// Token: 0x0401825F RID: 98911
		[Token(Token = "0x4014CED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int ItemID;

		// Token: 0x04018260 RID: 98912
		[Token(Token = "0x4014CEE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public int Amount;

		// Token: 0x04018261 RID: 98913
		[Token(Token = "0x4014CEF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int Level;
	}
}

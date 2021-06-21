using System;
using Define;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

namespace Field
{
	// Token: 0x02001117 RID: 4375
	[Token(Token = "0x2000B01")]
	public class VisibleChangeByFlagExtend : VisibleChangeByFlag
	{
		// Token: 0x06006EA0 RID: 28320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB5")]
		[Address(RVA = "0x2032740", Offset = "0x2032841", VA = "0x2032740", Slot = "5")]
		public override void UpdateObjectVisible()
		{
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x00026040 File Offset: 0x00024240
		[Token(Token = "0x6005BB6")]
		[Address(RVA = "0x2032860", Offset = "0x2032961", VA = "0x2032860")]
		private int GetBuildValidCount()
		{
			return 0;
		}

		// Token: 0x06006EA2 RID: 28322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB7")]
		[Address(RVA = "0x2032910", Offset = "0x2032A11", VA = "0x2032910")]
		private void SetBuildActive(int count)
		{
		}

		// Token: 0x06006EA3 RID: 28323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BB8")]
		[Address(RVA = "0x2032B10", Offset = "0x2032C11", VA = "0x2032B10")]
		public VisibleChangeByFlagExtend()
		{
		}

		// Token: 0x04018132 RID: 98610
		[Token(Token = "0x4014BEF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public BuilderId[] BuilderIds;

		// Token: 0x04018133 RID: 98611
		[Token(Token = "0x4014BF0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public MakingID MakingID;

		// Token: 0x04018134 RID: 98612
		[Token(Token = "0x4014BF1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] OnBuildLevels;

		// Token: 0x04018135 RID: 98613
		[Token(Token = "0x4014BF2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject[] OffBuildLevels;

		// Token: 0x04018136 RID: 98614
		[Token(Token = "0x4014BF3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject[] JustBuildLevels;
	}
}

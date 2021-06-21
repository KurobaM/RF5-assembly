using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200114F RID: 4431
	[Token(Token = "0x2000B27")]
	public class FieldWoodBoxSpawner : FieldTreasureBoxSpawner
	{
		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x00026CD0 File Offset: 0x00024ED0
		// (set) Token: 0x0600705C RID: 28764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1C")]
		public FieldWoodBoxSpawnID WoodBoxSpawnID
		{
			[Token(Token = "0x6005D22")]
			[Address(RVA = "0x1F92990", Offset = "0x1F92A91", VA = "0x1F92990")]
			get
			{
				return FieldWoodBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005D23")]
			[Address(RVA = "0x1F929A0", Offset = "0x1F92AA1", VA = "0x1F929A0")]
			private set
			{
			}
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D24")]
		[Address(RVA = "0x1F929B0", Offset = "0x1F92AB1", VA = "0x1F929B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D25")]
		[Address(RVA = "0x1F92AF0", Offset = "0x1F92BF1", VA = "0x1F92AF0", Slot = "6")]
		public override void Spawn()
		{
		}

		// Token: 0x0600705F RID: 28767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D26")]
		[Address(RVA = "0x1F92E50", Offset = "0x1F92F51", VA = "0x1F92E50")]
		public FieldWoodBoxSpawner()
		{
		}

		// Token: 0x040182C4 RID: 99012
		[Token(Token = "0x4014D38")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FieldWoodBoxSpawnID _WoodBoxSpawnID;

		// Token: 0x040182C5 RID: 99013
		[Token(Token = "0x4014D39")]
		[FieldOffset(Offset = "0x40")]
		private WoodenBox WoodenBox;

		// Token: 0x040182C6 RID: 99014
		[Token(Token = "0x4014D3A")]
		[FieldOffset(Offset = "0x48")]
		private SnowmanBox SnowmanBox;
	}
}

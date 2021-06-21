using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200114D RID: 4429
	[Token(Token = "0x2000B25")]
	public class FieldUniqueTreasureBoxSpawner : FieldTreasureBoxSpawner
	{
		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x0600704C RID: 28748 RVA: 0x00026C88 File Offset: 0x00024E88
		// (set) Token: 0x0600704D RID: 28749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1B")]
		public FieldUniqueTreasureBoxSpawnID UniqueBoxSpawnID
		{
			[Token(Token = "0x6005D13")]
			[Address(RVA = "0x1F921F0", Offset = "0x1F922F1", VA = "0x1F921F0")]
			get
			{
				return FieldUniqueTreasureBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005D14")]
			[Address(RVA = "0x1F92200", Offset = "0x1F92301", VA = "0x1F92200")]
			private set
			{
			}
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x1F92210", Offset = "0x1F92311", VA = "0x1F92210")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600704F RID: 28751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D16")]
		[Address(RVA = "0x1F92390", Offset = "0x1F92491", VA = "0x1F92390", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06007050 RID: 28752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D17")]
		[Address(RVA = "0x1F8A220", Offset = "0x1F8A321", VA = "0x1F8A220", Slot = "6")]
		public override void Spawn()
		{
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D18")]
		[Address(RVA = "0x1F90E90", Offset = "0x1F90F91", VA = "0x1F90E90")]
		public void SetGateController(GateController gate)
		{
		}

		// Token: 0x06007052 RID: 28754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D19")]
		[Address(RVA = "0x1F92460", Offset = "0x1F92561", VA = "0x1F92460")]
		private void OnGateEnamyDead(GateController monster)
		{
		}

		// Token: 0x06007053 RID: 28755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1A")]
		[Address(RVA = "0x1F92620", Offset = "0x1F92721", VA = "0x1F92620")]
		private void TreasureBoxSpawn(Vector3 position, Quaternion rotation, Vector3 offset)
		{
		}

		// Token: 0x06007054 RID: 28756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1B")]
		[Address(RVA = "0x1F8F160", Offset = "0x1F8F261", VA = "0x1F8F160")]
		public void OnChangeHideDetectFlag(bool visible)
		{
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1C")]
		[Address(RVA = "0x1F8A720", Offset = "0x1F8A821", VA = "0x1F8A720")]
		public FieldUniqueTreasureBoxSpawner()
		{
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D1D")]
		[Address(RVA = "0x1F927E0", Offset = "0x1F928E1", VA = "0x1F927E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF330", Offset = "0x1AF431")]
		private void <TreasureBoxSpawn>b__12_0()
		{
		}

		// Token: 0x040182BF RID: 99007
		[Token(Token = "0x4014D33")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FieldUniqueTreasureBoxSpawnID _UniqueBoxSpawnID;

		// Token: 0x040182C0 RID: 99008
		[Token(Token = "0x4014D34")]
		[FieldOffset(Offset = "0x40")]
		private FieldTreasureBox TreasureBox;

		// Token: 0x040182C1 RID: 99009
		[Token(Token = "0x4014D35")]
		[FieldOffset(Offset = "0x48")]
		public GateController GateController;

		// Token: 0x040182C2 RID: 99010
		[Token(Token = "0x4014D36")]
		[FieldOffset(Offset = "0x50")]
		private bool isAddSpawnEvent;
	}
}

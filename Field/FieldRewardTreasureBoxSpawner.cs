using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200112C RID: 4396
	[Token(Token = "0x2000B0E")]
	public class FieldRewardTreasureBoxSpawner : FieldTreasureBoxSpawner
	{
		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06006F2A RID: 28458 RVA: 0x00026430 File Offset: 0x00024630
		// (set) Token: 0x06006F2B RID: 28459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B07")]
		public FieldRewardTreasureBoxSpawnID RewardBoxSpawnID
		{
			[Token(Token = "0x6005C24")]
			[Address(RVA = "0x1F88FB0", Offset = "0x1F890B1", VA = "0x1F88FB0")]
			get
			{
				return FieldRewardTreasureBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005C25")]
			[Address(RVA = "0x1F88FC0", Offset = "0x1F890C1", VA = "0x1F88FC0")]
			private set
			{
			}
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C26")]
		[Address(RVA = "0x1F88FD0", Offset = "0x1F890D1", VA = "0x1F88FD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C27")]
		[Address(RVA = "0x1F89230", Offset = "0x1F89331", VA = "0x1F89230", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C28")]
		[Address(RVA = "0x1F89370", Offset = "0x1F89471", VA = "0x1F89370", Slot = "6")]
		public override void Spawn()
		{
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C29")]
		[Address(RVA = "0x1F89A20", Offset = "0x1F89B21", VA = "0x1F89A20")]
		public void SpawnRewardBox()
		{
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0x1F89BC0", Offset = "0x1F89CC1", VA = "0x1F89BC0")]
		private void TreasureBoxSpawn(Vector3 position, Quaternion rotation, Vector3 offset)
		{
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0x1F89DB0", Offset = "0x1F89EB1", VA = "0x1F89DB0")]
		public void RemoveSpawnObject()
		{
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0x1F89E90", Offset = "0x1F89F91", VA = "0x1F89E90")]
		public FieldRewardTreasureBoxSpawner()
		{
		}

		// Token: 0x06006F34 RID: 28468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0x1F89F90", Offset = "0x1F8A091", VA = "0x1F89F90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEFC0", Offset = "0x1AF0C1")]
		private void <TreasureBoxSpawn>b__10_0()
		{
		}

		// Token: 0x0401820F RID: 98831
		[Token(Token = "0x4014CA8")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FieldRewardTreasureBoxSpawnID _RewardBoxSpawnID;

		// Token: 0x04018210 RID: 98832
		[Token(Token = "0x4014CA9")]
		[FieldOffset(Offset = "0x40")]
		private FieldTreasureBox TreasureBox;

		// Token: 0x04018211 RID: 98833
		[Token(Token = "0x4014CAA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 TreasureSmokeOffset;
	}
}

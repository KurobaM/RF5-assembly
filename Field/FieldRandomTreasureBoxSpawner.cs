using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200112A RID: 4394
	[Token(Token = "0x2000B0D")]
	public class FieldRandomTreasureBoxSpawner : FieldTreasureBoxSpawner
	{
		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06006F15 RID: 28437 RVA: 0x00026400 File Offset: 0x00024600
		// (set) Token: 0x06006F16 RID: 28438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B04")]
		public FieldRandomTreasureBoxSpawnID RandomBoxSpawnID
		{
			[Token(Token = "0x6005C11")]
			[Address(RVA = "0x1F86780", Offset = "0x1F86881", VA = "0x1F86780")]
			get
			{
				return FieldRandomTreasureBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005C12")]
			[Address(RVA = "0x1F86790", Offset = "0x1F86891", VA = "0x1F86790")]
			private set
			{
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06006F17 RID: 28439 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006F18 RID: 28440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B05")]
		public MonsterControllerBase MonsterControllerBase
		{
			[Token(Token = "0x6005C13")]
			[Address(RVA = "0x1F867A0", Offset = "0x1F868A1", VA = "0x1F867A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEF80", Offset = "0x1AF081")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C14")]
			[Address(RVA = "0x1F867B0", Offset = "0x1F868B1", VA = "0x1F867B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEF90", Offset = "0x1AF091")]
			private set
			{
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06006F19 RID: 28441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006F1A RID: 28442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B06")]
		public EnemyBehaviorController EnemyBehaviorController
		{
			[Token(Token = "0x6005C15")]
			[Address(RVA = "0x1F867C0", Offset = "0x1F868C1", VA = "0x1F867C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEFA0", Offset = "0x1AF0A1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C16")]
			[Address(RVA = "0x1F867D0", Offset = "0x1F868D1", VA = "0x1F867D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEFB0", Offset = "0x1AF0B1")]
			private set
			{
			}
		}

		// Token: 0x06006F1B RID: 28443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x1F867E0", Offset = "0x1F868E1", VA = "0x1F867E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0x1F86B90", Offset = "0x1F86C91", VA = "0x1F86B90", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x1F86CD0", Offset = "0x1F86DD1", VA = "0x1F86CD0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x1F86EC0", Offset = "0x1F86FC1", VA = "0x1F86EC0", Slot = "6")]
		public override void Spawn()
		{
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0x1F88060", Offset = "0x1F88161", VA = "0x1F88060")]
		public void SetBossStageManager(BossStageManager stage)
		{
		}

		// Token: 0x06006F20 RID: 28448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1C")]
		[Address(RVA = "0x1F88160", Offset = "0x1F88261", VA = "0x1F88160")]
		private void OnDeadBossStage(BossStageManager stage)
		{
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0x1F88340", Offset = "0x1F88441", VA = "0x1F88340")]
		private void TreasureBoxSpawn(FieldTreasureBox treasureBox, Vector3 position, Quaternion rotation, Vector3 offset)
		{
		}

		// Token: 0x06006F22 RID: 28450 RVA: 0x00026418 File Offset: 0x00024618
		[Token(Token = "0x6005C1E")]
		[Address(RVA = "0x1F879F0", Offset = "0x1F87AF1", VA = "0x1F879F0")]
		private int GetBoxType(int[] ratios)
		{
			return 0;
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1F")]
		[Address(RVA = "0x1F88560", Offset = "0x1F88661", VA = "0x1F88560")]
		public void SetEnemyInit(MonsterControllerBase setMonsterControllerBase, EnemyBehaviorController setEnemyBehaviorController)
		{
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C20")]
		[Address(RVA = "0x1F88680", Offset = "0x1F88781", VA = "0x1F88680")]
		private void OnFinishDead(MonsterControllerBase monsterControllerBase)
		{
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x1F88760", Offset = "0x1F88861", VA = "0x1F88760")]
		public void RemoveBox()
		{
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x1F888C0", Offset = "0x1F889C1", VA = "0x1F888C0")]
		public FieldRandomTreasureBoxSpawner()
		{
		}

		// Token: 0x04018205 RID: 98821
		[Token(Token = "0x4014C9F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private FieldRandomTreasureBoxSpawnID _RandomBoxSpawnID;

		// Token: 0x04018206 RID: 98822
		[Token(Token = "0x4014CA0")]
		[FieldOffset(Offset = "0x40")]
		private FieldUniqueTreasureBoxSpawner UniqueBoxSpawner;

		// Token: 0x04018207 RID: 98823
		[Token(Token = "0x4014CA1")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181560", Offset = "0x181661")]
		private MonsterControllerBase <MonsterControllerBase>k__BackingField;

		// Token: 0x04018208 RID: 98824
		[Token(Token = "0x4014CA2")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181570", Offset = "0x181671")]
		private EnemyBehaviorController <EnemyBehaviorController>k__BackingField;

		// Token: 0x04018209 RID: 98825
		[Token(Token = "0x4014CA3")]
		[FieldOffset(Offset = "0x58")]
		private MonsterDataID SpawnMonsterDataID;

		// Token: 0x0401820A RID: 98826
		[Token(Token = "0x4014CA4")]
		[FieldOffset(Offset = "0x5C")]
		private bool IsSpawnMonster;

		// Token: 0x0401820B RID: 98827
		[Token(Token = "0x4014CA5")]
		[FieldOffset(Offset = "0x5D")]
		private bool IsDefeatMonster;

		// Token: 0x0401820C RID: 98828
		[Token(Token = "0x4014CA6")]
		[FieldOffset(Offset = "0x5E")]
		private bool isAddSpawnEvent;

		// Token: 0x0401820D RID: 98829
		[Token(Token = "0x4014CA7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly FieldTreasureBoxType[] BoxPrefabType;

		// Token: 0x0200112B RID: 4395
		[Token(Token = "0x2001589")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A210", Offset = "0x15A311")]
		private sealed class <>c__DisplayClass24_0
		{
			// Token: 0x06006F28 RID: 28456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB3")]
			[Address(RVA = "0x1F88550", Offset = "0x1F88651", VA = "0x1F88550")]
			public <>c__DisplayClass24_0()
			{
			}

			// Token: 0x06006F29 RID: 28457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DB4")]
			[Address(RVA = "0x1F88A20", Offset = "0x1F88B21", VA = "0x1F88A20")]
			internal void <TreasureBoxSpawn>b__0()
			{
			}

			// Token: 0x0401820E RID: 98830
			[Token(Token = "0x401C172")]
			[FieldOffset(Offset = "0x10")]
			public FieldTreasureBox treasureBox;
		}
	}
}

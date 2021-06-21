using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BossData
{
	// Token: 0x02000F44 RID: 3908
	[Token(Token = "0x20009EE")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1499C0", Offset = "0x149AC1")]
	public class GandageBossDataAsset : BossDataAssetBase
	{
		// Token: 0x0600657A RID: 25978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544B")]
		[Address(RVA = "0x245C590", Offset = "0x245C691", VA = "0x245C590", Slot = "9")]
		public override BossBehaviorController AddBossBehaviorControllerBase(GameObject monster)
		{
			return null;
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600544C")]
		[Address(RVA = "0x245C5F0", Offset = "0x245C6F1", VA = "0x245C5F0", Slot = "10")]
		public override CalcLotteryBossBehavior GetCalcLotteryBossBehavior()
		{
			return null;
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544D")]
		[Address(RVA = "0x245CA50", Offset = "0x245CB51", VA = "0x245CA50")]
		public GandageBossDataAsset()
		{
		}

		// Token: 0x0400C566 RID: 50534
		[Token(Token = "0x4009368")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList NormalAction_1_List;

		// Token: 0x0400C567 RID: 50535
		[Token(Token = "0x4009369")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList NormalAction_1_Close_List;

		// Token: 0x0400C568 RID: 50536
		[Token(Token = "0x400936A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList NormalAction_1_Middle_List;

		// Token: 0x0400C569 RID: 50537
		[Token(Token = "0x400936B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList NormalAction_1_Long_List;

		// Token: 0x0400C56A RID: 50538
		[Token(Token = "0x400936C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Normal_2;

		// Token: 0x0400C56B RID: 50539
		[Token(Token = "0x400936D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Normal_2_Dash;

		// Token: 0x0400C56C RID: 50540
		[Token(Token = "0x400936E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Normal_2_Jump;

		// Token: 0x0400C56D RID: 50541
		[Token(Token = "0x400936F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_A_1_ActionList;

		// Token: 0x0400C56E RID: 50542
		[Token(Token = "0x4009370")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_A_1_FlyswatterList;

		// Token: 0x0400C56F RID: 50543
		[Token(Token = "0x4009371")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_A_1_RushUpperList;

		// Token: 0x0400C570 RID: 50544
		[Token(Token = "0x4009372")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_A_1_JumpList;

		// Token: 0x0400C571 RID: 50545
		[Token(Token = "0x4009373")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_A_2_ActionList;

		// Token: 0x0400C572 RID: 50546
		[Token(Token = "0x4009374")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_B_1_ActionList;

		// Token: 0x0400C573 RID: 50547
		[Token(Token = "0x4009375")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Check_MadnessPattern_B_2List;

		// Token: 0x0400C574 RID: 50548
		[Token(Token = "0x4009376")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_B_2_CloseList;

		// Token: 0x0400C575 RID: 50549
		[Token(Token = "0x4009377")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_B_2_MiddleList;

		// Token: 0x0400C576 RID: 50550
		[Token(Token = "0x4009378")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GandageBossDataAsset.LotteryBossBehaviorPramsList Madness_B_2_LongList;

		// Token: 0x02000F45 RID: 3909
		[Token(Token = "0x20014C2")]
		[Serializable]
		public enum LotteryType
		{
			// Token: 0x0400C578 RID: 50552
			[Token(Token = "0x401BE0B")]
			None,
			// Token: 0x0400C579 RID: 50553
			[Token(Token = "0x401BE0C")]
			ComboAttack,
			// Token: 0x0400C57A RID: 50554
			[Token(Token = "0x401BE0D")]
			RowShockWave31,
			// Token: 0x0400C57B RID: 50555
			[Token(Token = "0x401BE0E")]
			RowShockWave32,
			// Token: 0x0400C57C RID: 50556
			[Token(Token = "0x401BE0F")]
			ColumnShockWave,
			// Token: 0x0400C57D RID: 50557
			[Token(Token = "0x401BE10")]
			SwordGround,
			// Token: 0x0400C57E RID: 50558
			[Token(Token = "0x401BE11")]
			Flyswatter,
			// Token: 0x0400C57F RID: 50559
			[Token(Token = "0x401BE12")]
			RushUpper51,
			// Token: 0x0400C580 RID: 50560
			[Token(Token = "0x401BE13")]
			RushUpper52,
			// Token: 0x0400C581 RID: 50561
			[Token(Token = "0x401BE14")]
			CrackArea,
			// Token: 0x0400C582 RID: 50562
			[Token(Token = "0x401BE15")]
			Flyingkick,
			// Token: 0x0400C583 RID: 50563
			[Token(Token = "0x401BE16")]
			Beatup,
			// Token: 0x0400C584 RID: 50564
			[Token(Token = "0x401BE17")]
			AroundMove,
			// Token: 0x0400C585 RID: 50565
			[Token(Token = "0x401BE18")]
			CloseStep,
			// Token: 0x0400C586 RID: 50566
			[Token(Token = "0x401BE19")]
			LeaveStep,
			// Token: 0x0400C587 RID: 50567
			[Token(Token = "0x401BE1A")]
			CloseDash,
			// Token: 0x0400C588 RID: 50568
			[Token(Token = "0x401BE1B")]
			LeaveDash,
			// Token: 0x0400C589 RID: 50569
			[Token(Token = "0x401BE1C")]
			EscapeJump,
			// Token: 0x0400C58A RID: 50570
			[Token(Token = "0x401BE1D")]
			TakeBehindJump,
			// Token: 0x0400C58B RID: 50571
			[Token(Token = "0x401BE1E")]
			Jump,
			// Token: 0x0400C58C RID: 50572
			[Token(Token = "0x401BE1F")]
			Guard,
			// Token: 0x0400C58D RID: 50573
			[Token(Token = "0x401BE20")]
			Check_Normal_1,
			// Token: 0x0400C58E RID: 50574
			[Token(Token = "0x401BE21")]
			Normal_1_Close,
			// Token: 0x0400C58F RID: 50575
			[Token(Token = "0x401BE22")]
			Normal_1_Middle,
			// Token: 0x0400C590 RID: 50576
			[Token(Token = "0x401BE23")]
			Normal_1_Long,
			// Token: 0x0400C591 RID: 50577
			[Token(Token = "0x401BE24")]
			Check_Normal_2,
			// Token: 0x0400C592 RID: 50578
			[Token(Token = "0x401BE25")]
			Normal_2_Dash,
			// Token: 0x0400C593 RID: 50579
			[Token(Token = "0x401BE26")]
			Normal_2_Jump,
			// Token: 0x0400C594 RID: 50580
			[Token(Token = "0x401BE27")]
			Check_MadnessPattern_A_1,
			// Token: 0x0400C595 RID: 50581
			[Token(Token = "0x401BE28")]
			Madness_A_1_Flyswatter,
			// Token: 0x0400C596 RID: 50582
			[Token(Token = "0x401BE29")]
			Madness_A_1_RushUpper,
			// Token: 0x0400C597 RID: 50583
			[Token(Token = "0x401BE2A")]
			Madness_A_1_Jump,
			// Token: 0x0400C598 RID: 50584
			[Token(Token = "0x401BE2B")]
			MadnessPattern_A_2,
			// Token: 0x0400C599 RID: 50585
			[Token(Token = "0x401BE2C")]
			MadnessPattern_B_1,
			// Token: 0x0400C59A RID: 50586
			[Token(Token = "0x401BE2D")]
			Check_MadnessPattern_B_2,
			// Token: 0x0400C59B RID: 50587
			[Token(Token = "0x401BE2E")]
			Madness_B_2_Close,
			// Token: 0x0400C59C RID: 50588
			[Token(Token = "0x401BE2F")]
			Madness_B_2_Middle,
			// Token: 0x0400C59D RID: 50589
			[Token(Token = "0x401BE30")]
			Madness_B_2_Long,
			// Token: 0x0400C59E RID: 50590
			[Token(Token = "0x401BE31")]
			BackBehavior,
			// Token: 0x0400C59F RID: 50591
			[Token(Token = "0x401BE32")]
			CrackArea_Ready,
			// Token: 0x0400C5A0 RID: 50592
			[Token(Token = "0x401BE33")]
			LastBossLaser
		}

		// Token: 0x02000F46 RID: 3910
		[Token(Token = "0x20014C3")]
		[Serializable]
		public class LotteryBossBehavior : LotteryBossBehavior<GandageBossDataAsset.LotteryType>
		{
			// Token: 0x0600657D RID: 25981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BDE")]
			[Address(RVA = "0x245CAE0", Offset = "0x245CBE1", VA = "0x245CAE0")]
			public LotteryBossBehavior()
			{
			}
		}

		// Token: 0x02000F47 RID: 3911
		[Token(Token = "0x20014C4")]
		[Serializable]
		public class LotteryBossBehaviorParams : LotteryBossBehaviorParams<GandageBossDataAsset.LotteryBossBehavior, GandageBossDataAsset.LotteryType>
		{
			// Token: 0x0600657E RID: 25982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BDF")]
			[Address(RVA = "0x245CB30", Offset = "0x245CC31", VA = "0x245CB30")]
			public LotteryBossBehaviorParams()
			{
			}
		}

		// Token: 0x02000F48 RID: 3912
		[Token(Token = "0x20014C5")]
		[Serializable]
		public class LotteryBossBehaviorPramsList : LotteryBossBehaviorPramsList<GandageBossDataAsset.LotteryBossBehaviorParams, GandageBossDataAsset.LotteryBossBehavior, GandageBossDataAsset.LotteryType>
		{
			// Token: 0x0600657F RID: 25983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007BE0")]
			[Address(RVA = "0x245CB80", Offset = "0x245CC81", VA = "0x245CB80")]
			public LotteryBossBehaviorPramsList()
			{
			}
		}
	}
}

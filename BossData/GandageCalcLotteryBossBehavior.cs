using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F49 RID: 3913
	[Token(Token = "0x20009EF")]
	public class GandageCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006580 RID: 25984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544E")]
		[Address(RVA = "0x245C900", Offset = "0x245CA01", VA = "0x245C900")]
		public GandageCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600544F")]
		[Address(RVA = "0x245CBD0", Offset = "0x245CCD1", VA = "0x245CBD0", Slot = "5")]
		public override void OnMadness()
		{
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x00022140 File Offset: 0x00020340
		[Token(Token = "0x6005450")]
		[Address(RVA = "0x245CC50", Offset = "0x245CD51", VA = "0x245CC50")]
		private bool IsCheckState(int gandageListType)
		{
			return default(bool);
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x00022158 File Offset: 0x00020358
		[Token(Token = "0x6005451")]
		[Address(RVA = "0x245CC80", Offset = "0x245CD81", VA = "0x245CC80")]
		private bool IsCheckStatePatternA(int gandageListType)
		{
			return default(bool);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x00022170 File Offset: 0x00020370
		[Token(Token = "0x6005452")]
		[Address(RVA = "0x245CCB0", Offset = "0x245CDB1", VA = "0x245CCB0", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x00022188 File Offset: 0x00020388
		[Token(Token = "0x6005453")]
		[Address(RVA = "0x245CD30", Offset = "0x245CE31", VA = "0x245CD30")]
		public int GetBehaviorType()
		{
			return 0;
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005454")]
		[Address(RVA = "0x245CEE0", Offset = "0x245CFE1", VA = "0x245CEE0")]
		private void UpdateBehaviorList(int behaviorType)
		{
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005455")]
		[Address(RVA = "0x245CE90", Offset = "0x245CF91", VA = "0x245CE90")]
		private void UpdatePatternAFlag(int behaviorType)
		{
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005456")]
		[Address(RVA = "0x245CF90", Offset = "0x245D091", VA = "0x245CF90", Slot = "8")]
		protected override void OnLoop()
		{
		}

		// Token: 0x0400C5A1 RID: 50593
		[Token(Token = "0x4009379")]
		[FieldOffset(Offset = "0x40")]
		private List<BossBehaviorParams> CurrentBehaviorParamsList;

		// Token: 0x02000F4A RID: 3914
		[Token(Token = "0x20014C6")]
		public enum GandageBossDataBitArrayIndex
		{
			// Token: 0x0400C5A3 RID: 50595
			[Token(Token = "0x401BE35")]
			IsEscape = 1,
			// Token: 0x0400C5A4 RID: 50596
			[Token(Token = "0x401BE36")]
			IsGuard,
			// Token: 0x0400C5A5 RID: 50597
			[Token(Token = "0x401BE37")]
			IsHitAttack,
			// Token: 0x0400C5A6 RID: 50598
			[Token(Token = "0x401BE38")]
			IsPatternA,
			// Token: 0x0400C5A7 RID: 50599
			[Token(Token = "0x401BE39")]
			e_Count
		}
	}
}

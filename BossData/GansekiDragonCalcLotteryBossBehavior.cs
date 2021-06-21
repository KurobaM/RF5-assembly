using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BossData
{
	// Token: 0x02000F50 RID: 3920
	[Token(Token = "0x20009F1")]
	public class GansekiDragonCalcLotteryBossBehavior : CalcLotteryBossBehavior
	{
		// Token: 0x06006590 RID: 26000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600545B")]
		[Address(RVA = "0x245D270", Offset = "0x245D371", VA = "0x245D270")]
		public GansekiDragonCalcLotteryBossBehavior(Dictionary<int, List<BossBehaviorParams>> bossBehaviorListDic)
		{
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x000221B8 File Offset: 0x000203B8
		// (set) Token: 0x06006592 RID: 26002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A59")]
		public bool IsMimicry
		{
			[Token(Token = "0x600545C")]
			[Address(RVA = "0x245D4E0", Offset = "0x245D5E1", VA = "0x245D4E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACDF0", Offset = "0x1ACEF1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600545D")]
			[Address(RVA = "0x245D4F0", Offset = "0x245D5F1", VA = "0x245D4F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ACE00", Offset = "0x1ACF01")]
			set
			{
			}
		}

		// Token: 0x06006593 RID: 26003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600545E")]
		[Address(RVA = "0x245D500", Offset = "0x245D601", VA = "0x245D500", Slot = "4")]
		public override void Setup(int bitArraybits)
		{
		}

		// Token: 0x06006594 RID: 26004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600545F")]
		[Address(RVA = "0x245D5A0", Offset = "0x245D6A1", VA = "0x245D5A0", Slot = "5")]
		public override void OnMadness()
		{
		}

		// Token: 0x06006595 RID: 26005 RVA: 0x000221D0 File Offset: 0x000203D0
		[Token(Token = "0x6005460")]
		[Address(RVA = "0x245D5C0", Offset = "0x245D6C1", VA = "0x245D5C0", Slot = "6")]
		public override int Lottery()
		{
			return 0;
		}

		// Token: 0x06006596 RID: 26006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005461")]
		[Address(RVA = "0x245D720", Offset = "0x245D821", VA = "0x245D720", Slot = "8")]
		protected override void OnLoop()
		{
		}

		// Token: 0x0400C5CA RID: 50634
		[Token(Token = "0x4009384")]
		[FieldOffset(Offset = "0x40")]
		public int NormalLoopPattenMax;

		// Token: 0x0400C5CB RID: 50635
		[Token(Token = "0x4009385")]
		[FieldOffset(Offset = "0x44")]
		public int MadnessLoopPattenMax;

		// Token: 0x0400C5CC RID: 50636
		[Token(Token = "0x4009386")]
		[FieldOffset(Offset = "0x48")]
		private int MimicryCounter;

		// Token: 0x0400C5CD RID: 50637
		[Token(Token = "0x4009387")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17FCF0", Offset = "0x17FDF1")]
		private bool <IsMimicry>k__BackingField;

		// Token: 0x02000F51 RID: 3921
		[Token(Token = "0x20014CB")]
		public enum GansekiDragonBossDataBitArrayIndex
		{
			// Token: 0x0400C5CF RID: 50639
			[Token(Token = "0x401BE53")]
			IsMimicryRelease = 1,
			// Token: 0x0400C5D0 RID: 50640
			[Token(Token = "0x401BE54")]
			IsNextSkip,
			// Token: 0x0400C5D1 RID: 50641
			[Token(Token = "0x401BE55")]
			IsAfterNextSkip,
			// Token: 0x0400C5D2 RID: 50642
			[Token(Token = "0x401BE56")]
			e_Count
		}
	}
}

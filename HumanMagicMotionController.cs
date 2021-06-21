using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000247 RID: 583
[Token(Token = "0x20001D5")]
public class HumanMagicMotionController : CharaMagicMotionController<HumanController, HumanMagicMotionType>
{
	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x17000287")]
	public override bool IsPlaying
	{
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x2222B10", Offset = "0x2222C11", VA = "0x2222B10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x2222B20", Offset = "0x2222C21", VA = "0x2222B20", Slot = "6")]
	public override bool DoPlay(int no, MagicID magicId, int level)
	{
		return default(bool);
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00006780 File Offset: 0x00004980
	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x2222B30", Offset = "0x2222C31", VA = "0x2222B30", Slot = "11")]
	public override bool DoPlay(HumanMagicMotionType motionType, MagicID magicId, int level)
	{
		return default(bool);
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x2222DE0", Offset = "0x2222EE1", VA = "0x2222DE0", Slot = "7")]
	public override void DoStop()
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x2222E10", Offset = "0x2222F11", VA = "0x2222E10", Slot = "8")]
	public override void DoCancel()
	{
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00006798 File Offset: 0x00004998
	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x2222E40", Offset = "0x2222F41", VA = "0x2222E40", Slot = "9")]
	public override bool DoShot()
	{
		return default(bool);
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x2222F70", Offset = "0x2223071", VA = "0x2222F70")]
	public HumanMagicMotionController()
	{
	}

	// Token: 0x04000822 RID: 2082
	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<HumanMagicMotionType, HumanMagicMotionController.HumanMagicMotion> m_MotionDataTable;

	// Token: 0x04000823 RID: 2083
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x20")]
	private HumanMagicMotionType m_CurrentMotionType;

	// Token: 0x04000824 RID: 2084
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x24")]
	private MagicID m_MagicID;

	// Token: 0x04000825 RID: 2085
	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x28")]
	private int m_MagicLevel;

	// Token: 0x04000826 RID: 2086
	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x2C")]
	private AttackAttribute m_AttackAttribute;

	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000FFB")]
	private class HumanMagicMotion
	{
		// Token: 0x06000E1D RID: 3613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4C")]
		[Address(RVA = "0x2223390", Offset = "0x2223491", VA = "0x2223390")]
		public HumanMagicMotion(string play, bool seal)
		{
		}

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4018E05")]
		[FieldOffset(Offset = "0x10")]
		public int PlayState;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4018E06")]
		[FieldOffset(Offset = "0x14")]
		public bool SealMotion;
	}
}

using System;
using Il2CppDummyDll;

// Token: 0x02000AA6 RID: 2726
[Token(Token = "0x2000727")]
public class SeedPointManager
{
	// Token: 0x1700097B RID: 2427
	// (get) Token: 0x060046EE RID: 18158 RVA: 0x00017340 File Offset: 0x00015540
	[Token(Token = "0x1700079D")]
	private static bool PatrolBatchEquiped
	{
		[Token(Token = "0x6003B70")]
		[Address(RVA = "0x1E2F9E0", Offset = "0x1E2FAE1", VA = "0x1E2F9E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060046EF RID: 18159 RVA: 0x00017358 File Offset: 0x00015558
	[Token(Token = "0x6003B71")]
	[Address(RVA = "0x1E2FA50", Offset = "0x1E2FB51", VA = "0x1E2FA50")]
	private static int CalcBatchPoint(int basePoint)
	{
		return 0;
	}

	// Token: 0x060046F0 RID: 18160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B72")]
	[Address(RVA = "0x1E2FB50", Offset = "0x1E2FC51", VA = "0x1E2FB50")]
	public static void AddBoardQuestComplete(int addPoint)
	{
	}

	// Token: 0x060046F1 RID: 18161 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B73")]
	[Address(RVA = "0x1E2FD50", Offset = "0x1E2FE51", VA = "0x1E2FD50")]
	public static void AddNPCQuestComplete(int addPoint)
	{
	}

	// Token: 0x060046F2 RID: 18162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B74")]
	[Address(RVA = "0x1E2FE40", Offset = "0x1E2FF41", VA = "0x1E2FE40")]
	public static void AddWantedClear(int addPoint)
	{
	}

	// Token: 0x060046F3 RID: 18163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B75")]
	[Address(RVA = "0x1E2FEB0", Offset = "0x1E2FFB1", VA = "0x1E2FEB0")]
	public static void AddWantedComplete(int addPoint)
	{
	}

	// Token: 0x060046F4 RID: 18164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B76")]
	[Address(RVA = "0x1E2FF20", Offset = "0x1E30021", VA = "0x1E2FF20")]
	public static void AddShipping(int totalPrice)
	{
	}

	// Token: 0x060046F5 RID: 18165 RVA: 0x00017370 File Offset: 0x00015570
	[Token(Token = "0x6003B77")]
	[Address(RVA = "0x1E2FC40", Offset = "0x1E2FD41", VA = "0x1E2FC40")]
	private static int GetBasePoint(SeedPointManager.Type type)
	{
		return 0;
	}

	// Token: 0x060046F6 RID: 18166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B78")]
	[Address(RVA = "0x1E30000", Offset = "0x1E30101", VA = "0x1E30000")]
	public static void Add(SeedPointManager.Type type)
	{
	}

	// Token: 0x060046F7 RID: 18167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B79")]
	[Address(RVA = "0x1E30170", Offset = "0x1E30271", VA = "0x1E30170")]
	public SeedPointManager()
	{
	}

	// Token: 0x0400A5EA RID: 42474
	[Token(Token = "0x4007D69")]
	private const int MonsterMaxCountInOneDay = 50;

	// Token: 0x0400A5EB RID: 42475
	[Token(Token = "0x4007D6A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int[] QuestPointTable;

	// Token: 0x0400A5EC RID: 42476
	[Token(Token = "0x4007D6B")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int[,] BasePointTable;

	// Token: 0x02000AA7 RID: 2727
	[Token(Token = "0x2001301")]
	public enum Type
	{
		// Token: 0x0400A5EE RID: 42478
		[Token(Token = "0x401B4E5")]
		Festival_1st,
		// Token: 0x0400A5EF RID: 42479
		[Token(Token = "0x401B4E6")]
		Festival_2nd,
		// Token: 0x0400A5F0 RID: 42480
		[Token(Token = "0x401B4E7")]
		Festival_3rd,
		// Token: 0x0400A5F1 RID: 42481
		[Token(Token = "0x401B4E8")]
		FirstTalk,
		// Token: 0x0400A5F2 RID: 42482
		[Token(Token = "0x401B4E9")]
		Shipping,
		// Token: 0x0400A5F3 RID: 42483
		[Token(Token = "0x401B4EA")]
		SubEvent,
		// Token: 0x0400A5F4 RID: 42484
		[Token(Token = "0x401B4EB")]
		BoardQuestClear,
		// Token: 0x0400A5F5 RID: 42485
		[Token(Token = "0x401B4EC")]
		NPCQuestClear,
		// Token: 0x0400A5F6 RID: 42486
		[Token(Token = "0x401B4ED")]
		Monster,
		// Token: 0x0400A5F7 RID: 42487
		[Token(Token = "0x401B4EE")]
		Boss,
		// Token: 0x0400A5F8 RID: 42488
		[Token(Token = "0x401B4EF")]
		TwinWorks,
		// Token: 0x0400A5F9 RID: 42489
		[Token(Token = "0x401B4F0")]
		WantedClear,
		// Token: 0x0400A5FA RID: 42490
		[Token(Token = "0x401B4F1")]
		Max
	}
}

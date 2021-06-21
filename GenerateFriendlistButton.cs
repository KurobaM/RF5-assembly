using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A0F RID: 2575
[Token(Token = "0x20006C1")]
public class GenerateFriendlistButton : UIScrollBoxBase
{
	// Token: 0x06004375 RID: 17269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003874")]
	[Address(RVA = "0x1FA4240", Offset = "0x1FA4341", VA = "0x1FA4240")]
	private void OnEnable()
	{
	}

	// Token: 0x06004376 RID: 17270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003875")]
	[Address(RVA = "0x1FA4800", Offset = "0x1FA4901", VA = "0x1FA4800", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x06004377 RID: 17271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003876")]
	[Address(RVA = "0x1FA4400", Offset = "0x1FA4501", VA = "0x1FA4400")]
	private void GenerateFriendData()
	{
	}

	// Token: 0x06004378 RID: 17272 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003877")]
	[Address(RVA = "0x1FA4B40", Offset = "0x1FA4C41", VA = "0x1FA4B40")]
	private void InputSubmit()
	{
	}

	// Token: 0x06004379 RID: 17273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003878")]
	[Address(RVA = "0x1FA4CE0", Offset = "0x1FA4DE1", VA = "0x1FA4CE0")]
	private void SetSortType()
	{
	}

	// Token: 0x0600437A RID: 17274 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003879")]
	[Address(RVA = "0x1FA4AD0", Offset = "0x1FA4BD1", VA = "0x1FA4AD0")]
	private void ChangeSortType()
	{
	}

	// Token: 0x0600437B RID: 17275 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387A")]
	[Address(RVA = "0x1FA5530", Offset = "0x1FA5631", VA = "0x1FA5530")]
	public void ChangePage(GenerateFriendlistButton.FriendType newType, CursorLinker PageButton)
	{
	}

	// Token: 0x0600437C RID: 17276 RVA: 0x00016860 File Offset: 0x00014A60
	[Token(Token = "0x600387B")]
	[Address(RVA = "0x1FA4A50", Offset = "0x1FA4B51", VA = "0x1FA4A50")]
	public int GetFriendCount()
	{
		return 0;
	}

	// Token: 0x0600437D RID: 17277 RVA: 0x00016878 File Offset: 0x00014A78
	[Token(Token = "0x600387C")]
	[Address(RVA = "0x1FA5620", Offset = "0x1FA5721", VA = "0x1FA5620")]
	public ActorID GetActorID(int PageNo)
	{
		return ActorID.act000;
	}

	// Token: 0x0600437E RID: 17278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387D")]
	[Address(RVA = "0x1FA56A0", Offset = "0x1FA57A1", VA = "0x1FA56A0")]
	public void CloseFriendObj(int pageId)
	{
	}

	// Token: 0x0600437F RID: 17279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600387E")]
	[Address(RVA = "0x1FA4380", Offset = "0x1FA4481", VA = "0x1FA4380")]
	private void SetOnOffChild(bool state)
	{
	}

	// Token: 0x06004380 RID: 17280 RVA: 0x00016890 File Offset: 0x00014A90
	[Token(Token = "0x600387F")]
	[Address(RVA = "0x1FA58B0", Offset = "0x1FA59B1", VA = "0x1FA58B0", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x06004381 RID: 17281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003880")]
	[Address(RVA = "0x1FA5930", Offset = "0x1FA5A31", VA = "0x1FA5930", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x06004382 RID: 17282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003881")]
	[Address(RVA = "0x1FA5AB0", Offset = "0x1FA5BB1", VA = "0x1FA5AB0", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x06004383 RID: 17283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003882")]
	[Address(RVA = "0x1FA5AC0", Offset = "0x1FA5BC1", VA = "0x1FA5AC0")]
	public GenerateFriendlistButton()
	{
	}

	// Token: 0x0400A255 RID: 41557
	[Token(Token = "0x4007AAC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject HasDataObject;

	// Token: 0x0400A256 RID: 41558
	[Token(Token = "0x4007AAD")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject NoDataObject;

	// Token: 0x0400A257 RID: 41559
	[Token(Token = "0x4007AAE")]
	[FieldOffset(Offset = "0x78")]
	private ButtonLinker menuButton;

	// Token: 0x0400A258 RID: 41560
	[Token(Token = "0x4007AAF")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject[] childObjects;

	// Token: 0x0400A259 RID: 41561
	[Token(Token = "0x4007AB0")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private FriendPageStatusDisp FriendPageStatusDispPrefabs;

	// Token: 0x0400A25A RID: 41562
	[Token(Token = "0x4007AB1")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UISortBlock sortBlock;

	// Token: 0x0400A25B RID: 41563
	[Token(Token = "0x4007AB2")]
	[FieldOffset(Offset = "0x98")]
	private GenerateFriendlistButton.SortType sortType;

	// Token: 0x0400A25C RID: 41564
	[Token(Token = "0x4007AB3")]
	[FieldOffset(Offset = "0x9C")]
	private bool sortRevert;

	// Token: 0x0400A25D RID: 41565
	[Token(Token = "0x4007AB4")]
	[FieldOffset(Offset = "0xA0")]
	private GenerateFriendlistButton.FriendType friendType;

	// Token: 0x0400A25E RID: 41566
	[Token(Token = "0x4007AB5")]
	[FieldOffset(Offset = "0xA8")]
	private List<ActorID> ActorIds;

	// Token: 0x0400A25F RID: 41567
	[Token(Token = "0x4007AB6")]
	[FieldOffset(Offset = "0xB0")]
	private List<int> MonsterStatusDataIds;

	// Token: 0x0400A260 RID: 41568
	[Token(Token = "0x4007AB7")]
	[FieldOffset(Offset = "0xB8")]
	private readonly List<ActorID> CanGenerateActorIDTable;

	// Token: 0x0400A261 RID: 41569
	[Token(Token = "0x4007AB8")]
	[FieldOffset(Offset = "0xC0")]
	private readonly int[] FriendMeetCheckFlag;

	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x20012D0")]
	public enum FriendType
	{
		// Token: 0x0400A263 RID: 41571
		[Token(Token = "0x401B40D")]
		NPC,
		// Token: 0x0400A264 RID: 41572
		[Token(Token = "0x401B40E")]
		Monster
	}

	// Token: 0x02000A11 RID: 2577
	[Token(Token = "0x20012D1")]
	public enum SortType
	{
		// Token: 0x0400A266 RID: 41574
		[Token(Token = "0x401B410")]
		Auto,
		// Token: 0x0400A267 RID: 41575
		[Token(Token = "0x401B411")]
		LoveLv,
		// Token: 0x0400A268 RID: 41576
		[Token(Token = "0x401B412")]
		Max
	}

	// Token: 0x02000A12 RID: 2578
	[Token(Token = "0x20012D2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159020", Offset = "0x159121")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004385 RID: 17285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075E6")]
		[Address(RVA = "0x1FA5DF0", Offset = "0x1FA5EF1", VA = "0x1FA5DF0")]
		public <>c()
		{
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x000168A8 File Offset: 0x00014AA8
		[Token(Token = "0x60075E7")]
		[Address(RVA = "0x1FA5E00", Offset = "0x1FA5F01", VA = "0x1FA5E00")]
		internal int <SetSortType>b__19_0(ActorID a, ActorID b)
		{
			return 0;
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x60075E8")]
		[Address(RVA = "0x1FA5E10", Offset = "0x1FA5F11", VA = "0x1FA5E10")]
		internal int <SetSortType>b__19_1(ActorID a, ActorID b)
		{
			return 0;
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x000168D8 File Offset: 0x00014AD8
		[Token(Token = "0x60075E9")]
		[Address(RVA = "0x1FA5E20", Offset = "0x1FA5F21", VA = "0x1FA5E20")]
		internal int <SetSortType>b__19_2(ActorID a, ActorID b)
		{
			return 0;
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000168F0 File Offset: 0x00014AF0
		[Token(Token = "0x60075EA")]
		[Address(RVA = "0x1FA5E30", Offset = "0x1FA5F31", VA = "0x1FA5E30")]
		internal int <SetSortType>b__19_3(ActorID a, ActorID b)
		{
			return 0;
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x00016908 File Offset: 0x00014B08
		[Token(Token = "0x60075EB")]
		[Address(RVA = "0x1FA5EE0", Offset = "0x1FA5FE1", VA = "0x1FA5EE0")]
		internal int <SetSortType>b__19_4(ActorID a, ActorID b)
		{
			return 0;
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x00016920 File Offset: 0x00014B20
		[Token(Token = "0x60075EC")]
		[Address(RVA = "0x1FA5EF0", Offset = "0x1FA5FF1", VA = "0x1FA5EF0")]
		internal int <SetSortType>b__19_5(ActorID a, ActorID b)
		{
			return 0;
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x00016938 File Offset: 0x00014B38
		[Token(Token = "0x60075ED")]
		[Address(RVA = "0x1FA5FA0", Offset = "0x1FA60A1", VA = "0x1FA5FA0")]
		internal int <SetSortType>b__19_6(int a, int b)
		{
			return 0;
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00016950 File Offset: 0x00014B50
		[Token(Token = "0x60075EE")]
		[Address(RVA = "0x1FA5FB0", Offset = "0x1FA60B1", VA = "0x1FA5FB0")]
		internal int <SetSortType>b__19_7(int a, int b)
		{
			return 0;
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x00016968 File Offset: 0x00014B68
		[Token(Token = "0x60075EF")]
		[Address(RVA = "0x1FA5FC0", Offset = "0x1FA60C1", VA = "0x1FA5FC0")]
		internal int <SetSortType>b__19_8(int a, int b)
		{
			return 0;
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00016980 File Offset: 0x00014B80
		[Token(Token = "0x60075F0")]
		[Address(RVA = "0x1FA5FD0", Offset = "0x1FA60D1", VA = "0x1FA5FD0")]
		internal int <SetSortType>b__19_9(int a, int b)
		{
			return 0;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00016998 File Offset: 0x00014B98
		[Token(Token = "0x60075F1")]
		[Address(RVA = "0x1FA60B0", Offset = "0x1FA61B1", VA = "0x1FA60B0")]
		internal int <SetSortType>b__19_10(int a, int b)
		{
			return 0;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x000169B0 File Offset: 0x00014BB0
		[Token(Token = "0x60075F2")]
		[Address(RVA = "0x1FA60C0", Offset = "0x1FA61C1", VA = "0x1FA60C0")]
		internal int <SetSortType>b__19_11(int a, int b)
		{
			return 0;
		}

		// Token: 0x0400A269 RID: 41577
		[Token(Token = "0x401B413")]
		[FieldOffset(Offset = "0x0")]
		public static readonly GenerateFriendlistButton.<>c <>9;

		// Token: 0x0400A26A RID: 41578
		[Token(Token = "0x401B414")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<ActorID> <>9__19_0;

		// Token: 0x0400A26B RID: 41579
		[Token(Token = "0x401B415")]
		[FieldOffset(Offset = "0x10")]
		public static Comparison<ActorID> <>9__19_1;

		// Token: 0x0400A26C RID: 41580
		[Token(Token = "0x401B416")]
		[FieldOffset(Offset = "0x18")]
		public static Comparison<ActorID> <>9__19_2;

		// Token: 0x0400A26D RID: 41581
		[Token(Token = "0x401B417")]
		[FieldOffset(Offset = "0x20")]
		public static Comparison<ActorID> <>9__19_3;

		// Token: 0x0400A26E RID: 41582
		[Token(Token = "0x401B418")]
		[FieldOffset(Offset = "0x28")]
		public static Comparison<ActorID> <>9__19_4;

		// Token: 0x0400A26F RID: 41583
		[Token(Token = "0x401B419")]
		[FieldOffset(Offset = "0x30")]
		public static Comparison<ActorID> <>9__19_5;

		// Token: 0x0400A270 RID: 41584
		[Token(Token = "0x401B41A")]
		[FieldOffset(Offset = "0x38")]
		public static Comparison<int> <>9__19_6;

		// Token: 0x0400A271 RID: 41585
		[Token(Token = "0x401B41B")]
		[FieldOffset(Offset = "0x40")]
		public static Comparison<int> <>9__19_7;

		// Token: 0x0400A272 RID: 41586
		[Token(Token = "0x401B41C")]
		[FieldOffset(Offset = "0x48")]
		public static Comparison<int> <>9__19_8;

		// Token: 0x0400A273 RID: 41587
		[Token(Token = "0x401B41D")]
		[FieldOffset(Offset = "0x50")]
		public static Comparison<int> <>9__19_9;

		// Token: 0x0400A274 RID: 41588
		[Token(Token = "0x401B41E")]
		[FieldOffset(Offset = "0x58")]
		public static Comparison<int> <>9__19_10;

		// Token: 0x0400A275 RID: 41589
		[Token(Token = "0x401B41F")]
		[FieldOffset(Offset = "0x60")]
		public static Comparison<int> <>9__19_11;
	}
}

using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000549 RID: 1353
[Token(Token = "0x20003D4")]
[Attribute(Name = "ExecuteAlways", RVA = "0x145F50", Offset = "0x146051")]
public class DoorController : MonoBehaviour
{
	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
	// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000451")]
	private DoorController.State m_State
	{
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x1DFCBC0", Offset = "0x1DFCCC1", VA = "0x1DFCBC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A05C0", Offset = "0x1A06C1")]
		get
		{
			return DoorController.State.Close;
		}
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x1DFCBD0", Offset = "0x1DFCCD1", VA = "0x1DFCBD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A05D0", Offset = "0x1A06D1")]
		set
		{
		}
	}

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
	// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000452")]
	private DoorController.State m_PrevState
	{
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x1DFCBE0", Offset = "0x1DFCCE1", VA = "0x1DFCBE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A05E0", Offset = "0x1A06E1")]
		get
		{
			return DoorController.State.Close;
		}
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x1DFCBF0", Offset = "0x1DFCCF1", VA = "0x1DFCBF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A05F0", Offset = "0x1A06F1")]
		set
		{
		}
	}

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
	// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000453")]
	private bool IsForward
	{
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x1DFCC00", Offset = "0x1DFCD01", VA = "0x1DFCC00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0600", Offset = "0x1A0701")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x1DFCC10", Offset = "0x1DFCD11", VA = "0x1DFCC10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0610", Offset = "0x1A0711")]
		set
		{
		}
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x060020C6 RID: 8390 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
	// (set) Token: 0x060020C7 RID: 8391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000454")]
	private float ElapsedTime
	{
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x1DFCC20", Offset = "0x1DFCD21", VA = "0x1DFCC20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0620", Offset = "0x1A0721")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x1DFCC30", Offset = "0x1DFCD31", VA = "0x1DFCC30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0630", Offset = "0x1A0731")]
		set
		{
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0000D710 File Offset: 0x0000B910
	// (set) Token: 0x060020C9 RID: 8393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000455")]
	private float DoorAlpha
	{
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x1DFCC40", Offset = "0x1DFCD41", VA = "0x1DFCC40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0640", Offset = "0x1A0741")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x1DFCC50", Offset = "0x1DFCD51", VA = "0x1DFCC50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0650", Offset = "0x1A0751")]
		set
		{
		}
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x0000D728 File Offset: 0x0000B928
	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0x1DFCC60", Offset = "0x1DFCD61", VA = "0x1DFCC60")]
	private bool ChangeState(DoorController.State state)
	{
		return default(bool);
	}

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x060020CB RID: 8395 RVA: 0x0000D740 File Offset: 0x0000B940
	[Token(Token = "0x17000456")]
	private bool IsOpened
	{
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x1DFD180", Offset = "0x1DFD281", VA = "0x1DFD180")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x060020CC RID: 8396 RVA: 0x0000D758 File Offset: 0x0000B958
	[Token(Token = "0x17000457")]
	private bool IsClosed
	{
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x1DFD1A0", Offset = "0x1DFD2A1", VA = "0x1DFD1A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x1DFD1C0", Offset = "0x1DFD2C1", VA = "0x1DFD1C0")]
	public void DoOpen(bool isForward)
	{
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x1DFD210", Offset = "0x1DFD311", VA = "0x1DFD210")]
	public void DoClose()
	{
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x1DFD2A0", Offset = "0x1DFD3A1", VA = "0x1DFD2A0")]
	public void ImmediateClose()
	{
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x1DFD2C0", Offset = "0x1DFD3C1", VA = "0x1DFD2C0")]
	private void Update()
	{
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x1DFCCF0", Offset = "0x1DFCDF1", VA = "0x1DFCCF0")]
	private void Close_Enter()
	{
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x1DFDDC0", Offset = "0x1DFDEC1", VA = "0x1DFDDC0")]
	private void Close_Update()
	{
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x1DFCE20", Offset = "0x1DFCF21", VA = "0x1DFCE20")]
	private void AnimOpen_Enter()
	{
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x1DFDDD0", Offset = "0x1DFDED1", VA = "0x1DFDDD0")]
	private void AnimOpen_Update(float deltaTime)
	{
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x1DFCEC0", Offset = "0x1DFCFC1", VA = "0x1DFCEC0")]
	private void Open_Enter()
	{
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x1DFE130", Offset = "0x1DFE231", VA = "0x1DFE130")]
	private void Open_Update()
	{
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDC")]
	[Address(RVA = "0x1DFD0D0", Offset = "0x1DFD1D1", VA = "0x1DFD0D0")]
	private void DelayClose_Enter()
	{
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x1DFE140", Offset = "0x1DFE241", VA = "0x1DFE140")]
	private void DelayClose_Update()
	{
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x1DFD0E0", Offset = "0x1DFD1E1", VA = "0x1DFD0E0")]
	private void AnimClose_Enter()
	{
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x1DFE190", Offset = "0x1DFE291", VA = "0x1DFE190")]
	private void AnimClose_Update(float deltaTime)
	{
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x1DFE4E0", Offset = "0x1DFE5E1", VA = "0x1DFE4E0")]
	private void UpdateCollision()
	{
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x0000D770 File Offset: 0x0000B970
	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x1DFE7A0", Offset = "0x1DFE8A1", VA = "0x1DFE7A0")]
	private static bool TimeCheck(int hour, int start, int end)
	{
		return default(bool);
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x0000D788 File Offset: 0x0000B988
	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x1DFE7F0", Offset = "0x1DFE8F1", VA = "0x1DFE7F0")]
	public static bool CanOpenByTime(Place placeid, bool isNeedLove)
	{
		return default(bool);
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x1DFD9A0", Offset = "0x1DFDAA1", VA = "0x1DFD9A0")]
	public static bool CanOpen(Place placeid, ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x1DFEC90", Offset = "0x1DFED91", VA = "0x1DFEC90")]
	private void Reset()
	{
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x1DFECF0", Offset = "0x1DFEDF1", VA = "0x1DFECF0")]
	public DoorController()
	{
	}

	// Token: 0x0400679D RID: 26525
	[Token(Token = "0x400618B")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165EB0", Offset = "0x165FB1")]
	private DoorController.State <m_State>k__BackingField;

	// Token: 0x0400679E RID: 26526
	[Token(Token = "0x400618C")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165EC0", Offset = "0x165FC1")]
	private DoorController.State <m_PrevState>k__BackingField;

	// Token: 0x0400679F RID: 26527
	[Token(Token = "0x400618D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Place Place;

	// Token: 0x040067A0 RID: 26528
	[Token(Token = "0x400618E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform Door_R;

	// Token: 0x040067A1 RID: 26529
	[Token(Token = "0x400618F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Quaternion CloseRotation_R;

	// Token: 0x040067A2 RID: 26530
	[Token(Token = "0x4006190")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Quaternion OpenRotation_R;

	// Token: 0x040067A3 RID: 26531
	[Token(Token = "0x4006191")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform Door_L;

	// Token: 0x040067A4 RID: 26532
	[Token(Token = "0x4006192")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Quaternion CloseRotation_L;

	// Token: 0x040067A5 RID: 26533
	[Token(Token = "0x4006193")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Quaternion OpenRotation_L;

	// Token: 0x040067A6 RID: 26534
	[Token(Token = "0x4006194")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private AnimationCurve AnimationCurve;

	// Token: 0x040067A7 RID: 26535
	[Token(Token = "0x4006195")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float AnimTime;

	// Token: 0x040067A8 RID: 26536
	[Token(Token = "0x4006196")]
	private const float CloseDelayTime = 6f;

	// Token: 0x040067A9 RID: 26537
	[Token(Token = "0x4006197")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165F60", Offset = "0x166061")]
	private bool <IsForward>k__BackingField;

	// Token: 0x040067AA RID: 26538
	[Token(Token = "0x4006198")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private BoxCollider BoxCollider;

	// Token: 0x040067AB RID: 26539
	[Token(Token = "0x4006199")]
	[FieldOffset(Offset = "0x90")]
	private HashSet<ActorController> InSideCollisions;

	// Token: 0x040067AC RID: 26540
	[Token(Token = "0x400619A")]
	[FieldOffset(Offset = "0x98")]
	private HashSet<ActorController> OpenedCharacters;

	// Token: 0x040067AD RID: 26541
	[Token(Token = "0x400619B")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165F80", Offset = "0x166081")]
	private float <ElapsedTime>k__BackingField;

	// Token: 0x040067AE RID: 26542
	[Token(Token = "0x400619C")]
	[FieldOffset(Offset = "0xA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165F90", Offset = "0x166091")]
	private float <DoorAlpha>k__BackingField;

	// Token: 0x040067AF RID: 26543
	[Token(Token = "0x400619D")]
	[FieldOffset(Offset = "0x0")]
	private static bool prev_FLAG_ALLDOOR_CLOSED;

	// Token: 0x040067B0 RID: 26544
	[Token(Token = "0x400619E")]
	[FieldOffset(Offset = "0x1")]
	private static bool doorOpenEvent;

	// Token: 0x040067B1 RID: 26545
	[Token(Token = "0x400619F")]
	[FieldOffset(Offset = "0xA8")]
	private List<ActorController> DeleteList;

	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x20010FE")]
	private enum State
	{
		// Token: 0x040067B3 RID: 26547
		[Token(Token = "0x4019286")]
		Close,
		// Token: 0x040067B4 RID: 26548
		[Token(Token = "0x4019287")]
		AnimOpen,
		// Token: 0x040067B5 RID: 26549
		[Token(Token = "0x4019288")]
		Open,
		// Token: 0x040067B6 RID: 26550
		[Token(Token = "0x4019289")]
		DelayClose,
		// Token: 0x040067B7 RID: 26551
		[Token(Token = "0x401928A")]
		AnimClose
	}
}

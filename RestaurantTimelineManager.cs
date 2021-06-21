using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020004D3 RID: 1235
[Token(Token = "0x200038E")]
public class RestaurantTimelineManager : MonoBehaviour
{
	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E6A RID: 7786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700040F")]
	public static RestaurantTimelineManager Instance
	{
		[Token(Token = "0x6001A34")]
		[Address(RVA = "0x248AFD0", Offset = "0x248B0D1", VA = "0x248AFD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F470", Offset = "0x19F571")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x248B020", Offset = "0x248B121", VA = "0x248B020")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F480", Offset = "0x19F581")]
		private set
		{
		}
	}

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001E6C RID: 7788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000410")]
	private Action CallBack
	{
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x248B080", Offset = "0x248B181", VA = "0x248B080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F490", Offset = "0x19F591")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x248B090", Offset = "0x248B191", VA = "0x248B090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F4A0", Offset = "0x19F5A1")]
		set
		{
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x06001E6D RID: 7789 RVA: 0x0000CF78 File Offset: 0x0000B178
	// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000411")]
	private ActorID SubActor
	{
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x248B0A0", Offset = "0x248B1A1", VA = "0x248B0A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F4B0", Offset = "0x19F5B1")]
		get
		{
			return ActorID.act000;
		}
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x248B0B0", Offset = "0x248B1B1", VA = "0x248B0B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F4C0", Offset = "0x19F5C1")]
		set
		{
		}
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x06001E6F RID: 7791 RVA: 0x0000CF90 File Offset: 0x0000B190
	// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000412")]
	private ItemID ItemID
	{
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x248B0C0", Offset = "0x248B1C1", VA = "0x248B0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F4D0", Offset = "0x19F5D1")]
		get
		{
			return ItemID.ITEM_EMPTY;
		}
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x248B0D0", Offset = "0x248B1D1", VA = "0x248B0D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F4E0", Offset = "0x19F5E1")]
		set
		{
		}
	}

	// Token: 0x06001E71 RID: 7793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x248B0E0", Offset = "0x248B1E1", VA = "0x248B0E0")]
	private void Start()
	{
	}

	// Token: 0x06001E72 RID: 7794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x248B140", Offset = "0x248B241", VA = "0x248B140")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001E73 RID: 7795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x248B240", Offset = "0x248B341", VA = "0x248B240")]
	public static void Play(ActorID subActor, ItemID itemid, Action callback)
	{
	}

	// Token: 0x06001E74 RID: 7796 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x248B380", Offset = "0x248B481", VA = "0x248B380")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F4F0", Offset = "0x19F5F1")]
	private IEnumerator Load()
	{
		return null;
	}

	// Token: 0x06001E75 RID: 7797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x248B430", Offset = "0x248B531", VA = "0x248B430")]
	private void PlayTimeline()
	{
	}

	// Token: 0x06001E76 RID: 7798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x248B9E0", Offset = "0x248BAE1", VA = "0x248B9E0")]
	private void TimeLineEnd()
	{
	}

	// Token: 0x06001E77 RID: 7799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x248BD70", Offset = "0x248BE71", VA = "0x248BD70")]
	public RestaurantTimelineManager()
	{
	}

	// Token: 0x06001E78 RID: 7800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x248BD80", Offset = "0x248BE81", VA = "0x248BD80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F560", Offset = "0x19F661")]
	private void <PlayTimeline>b__22_1(PlayableDirector director)
	{
	}

	// Token: 0x04006450 RID: 25680
	[Token(Token = "0x4005EF9")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x164EE0", Offset = "0x164FE1")]
	private static RestaurantTimelineManager <Instance>k__BackingField;

	// Token: 0x04006451 RID: 25681
	[Token(Token = "0x4005EFA")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x164EF0", Offset = "0x164FF1")]
	private Action <CallBack>k__BackingField;

	// Token: 0x04006452 RID: 25682
	[Token(Token = "0x4005EFB")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x164F00", Offset = "0x165001")]
	private ActorID <SubActor>k__BackingField;

	// Token: 0x04006453 RID: 25683
	[Token(Token = "0x4005EFC")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x164F10", Offset = "0x165011")]
	private ItemID <ItemID>k__BackingField;

	// Token: 0x04006454 RID: 25684
	[Token(Token = "0x4005EFD")]
	[FieldOffset(Offset = "0x28")]
	private bool IsSwitchSPCBase;

	// Token: 0x04006455 RID: 25685
	[Token(Token = "0x4005EFE")]
	[FieldOffset(Offset = "0x30")]
	private PlayableDirector Director;

	// Token: 0x020004D4 RID: 1236
	[Token(Token = "0x20010CE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B60", Offset = "0x157C61")]
	private sealed class <Load>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F20")]
		[Address(RVA = "0x248B400", Offset = "0x248B501", VA = "0x248B400")]
		[DebuggerHidden]
		public <Load>d__21(int <>1__state)
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F21")]
		[Address(RVA = "0x248BE80", Offset = "0x248BF81", VA = "0x248BE80", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x6006F22")]
		[Address(RVA = "0x248BE90", Offset = "0x248BF91", VA = "0x248BE90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8D")]
		private object Current
		{
			[Token(Token = "0x6006F23")]
			[Address(RVA = "0x248C1E0", Offset = "0x248C2E1", VA = "0x248C1E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F24")]
		[Address(RVA = "0x248C1F0", Offset = "0x248C2F1", VA = "0x248C1F0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8E")]
		private object Current
		{
			[Token(Token = "0x6006F25")]
			[Address(RVA = "0x248C250", Offset = "0x248C351", VA = "0x248C250", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006456 RID: 25686
		[Token(Token = "0x40191CA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006457 RID: 25687
		[Token(Token = "0x40191CB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006458 RID: 25688
		[Token(Token = "0x40191CC")]
		[FieldOffset(Offset = "0x20")]
		public RestaurantTimelineManager <>4__this;

		// Token: 0x04006459 RID: 25689
		[Token(Token = "0x40191CD")]
		[FieldOffset(Offset = "0x28")]
		private Actor <subActor>5__2;
	}

	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20010CF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B70", Offset = "0x157C71")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001E80 RID: 7808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F27")]
		[Address(RVA = "0x248BE00", Offset = "0x248BF01", VA = "0x248BE00")]
		public <>c()
		{
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F28")]
		[Address(RVA = "0x248BE10", Offset = "0x248BF11", VA = "0x248BE10")]
		internal void <PlayTimeline>b__22_0(PlayableDirector director)
		{
		}

		// Token: 0x0400645A RID: 25690
		[Token(Token = "0x40191CE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RestaurantTimelineManager.<>c <>9;

		// Token: 0x0400645B RID: 25691
		[Token(Token = "0x40191CF")]
		[FieldOffset(Offset = "0x8")]
		public static Action<PlayableDirector> <>9__22_0;
	}
}

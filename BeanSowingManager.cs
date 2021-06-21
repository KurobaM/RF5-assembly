using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020004FA RID: 1274
[Token(Token = "0x20003A5")]
public class BeanSowingManager : SingletonMonoBehaviour<BeanSowingManager>
{
	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x06001F1B RID: 7963 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000421")]
	public BeanSowingCamera Camera
	{
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x2209060", Offset = "0x2209161", VA = "0x2209060")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000422")]
	public ObjectPooler ObjectPooler
	{
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x2209070", Offset = "0x2209171", VA = "0x2209070")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0000D218 File Offset: 0x0000B418
	// (set) Token: 0x06001F1E RID: 7966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000423")]
	public Vector3 StartForward
	{
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x2209080", Offset = "0x2209181", VA = "0x2209080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F9B0", Offset = "0x19FAB1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x2209090", Offset = "0x2209191", VA = "0x2209090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F9C0", Offset = "0x19FAC1")]
		private set
		{
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001F20 RID: 7968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000424")]
	public BeanSowingDataTable BeanSowingDataTable
	{
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x22090A0", Offset = "0x22091A1", VA = "0x22090A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F9D0", Offset = "0x19FAD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x22090B0", Offset = "0x22091B1", VA = "0x22090B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19F9E0", Offset = "0x19FAE1")]
		private set
		{
		}
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x22090C0", Offset = "0x22091C1", VA = "0x22090C0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x2209130", Offset = "0x2209231", VA = "0x2209130")]
	private void Start()
	{
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x2209440", Offset = "0x2209541", VA = "0x2209440")]
	private void OnLoadingBean(int i)
	{
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x2209570", Offset = "0x2209671", VA = "0x2209570")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x2209670", Offset = "0x2209771", VA = "0x2209670")]
	private void CharaSetup()
	{
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x0000D230 File Offset: 0x0000B430
	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x22099D0", Offset = "0x2209AD1", VA = "0x22099D0")]
	private bool IsLoading()
	{
		return default(bool);
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x2209BE0", Offset = "0x2209CE1", VA = "0x2209BE0")]
	private void Update()
	{
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0x220A0A0", Offset = "0x220A1A1", VA = "0x220A0A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F9F0", Offset = "0x19FAF1")]
	private IEnumerator BeanSowingGame()
	{
		return null;
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x220A150", Offset = "0x220A251", VA = "0x220A150")]
	public void ResetNpc()
	{
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x220A340", Offset = "0x220A441", VA = "0x220A340")]
	public BeanSowingManager()
	{
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x220A480", Offset = "0x220A581", VA = "0x220A480")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FA60", Offset = "0x19FB61")]
	private void <Start>b__23_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006606 RID: 26118
	[Token(Token = "0x400607F")]
	[FieldOffset(Offset = "0x18")]
	private readonly int[] BEAN_PREFAB_ID;

	// Token: 0x04006607 RID: 26119
	[Token(Token = "0x4006080")]
	[FieldOffset(Offset = "0x20")]
	private readonly int UI_SCORE_ID;

	// Token: 0x04006608 RID: 26120
	[Token(Token = "0x4006081")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BeanSowingCamera beanSowingCamera;

	// Token: 0x04006609 RID: 26121
	[Token(Token = "0x4006082")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ObjectPooler objectPooler;

	// Token: 0x0400660A RID: 26122
	[Token(Token = "0x4006083")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1656E0", Offset = "0x1657E1")]
	private Vector3 <StartForward>k__BackingField;

	// Token: 0x0400660B RID: 26123
	[Token(Token = "0x4006084")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1656F0", Offset = "0x1657F1")]
	private BeanSowingDataTable <BeanSowingDataTable>k__BackingField;

	// Token: 0x0400660C RID: 26124
	[Token(Token = "0x4006085")]
	[FieldOffset(Offset = "0x50")]
	private BeanSowingActionDataTable beanSowingActionDataTable;

	// Token: 0x0400660D RID: 26125
	[Token(Token = "0x4006086")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject playerPos;

	// Token: 0x0400660E RID: 26126
	[Token(Token = "0x4006087")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private BeanSowingNPC[] npc;

	// Token: 0x0400660F RID: 26127
	[Token(Token = "0x4006088")]
	[FieldOffset(Offset = "0x68")]
	private List<ActorID> actorID;

	// Token: 0x04006610 RID: 26128
	[Token(Token = "0x4006089")]
	[FieldOffset(Offset = "0x70")]
	private BeanSowingManager.State state;

	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20010DE")]
	private enum State
	{
		// Token: 0x04006612 RID: 26130
		[Token(Token = "0x40191FB")]
		None,
		// Token: 0x04006613 RID: 26131
		[Token(Token = "0x40191FC")]
		Begin,
		// Token: 0x04006614 RID: 26132
		[Token(Token = "0x40191FD")]
		Load,
		// Token: 0x04006615 RID: 26133
		[Token(Token = "0x40191FE")]
		CountDown,
		// Token: 0x04006616 RID: 26134
		[Token(Token = "0x40191FF")]
		Main,
		// Token: 0x04006617 RID: 26135
		[Token(Token = "0x4019200")]
		End
	}

	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20010DF")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C40", Offset = "0x157D41")]
	private sealed class <>c__DisplayClass24_0
	{
		// Token: 0x06001F2C RID: 7980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F63")]
		[Address(RVA = "0x2209560", Offset = "0x2209661", VA = "0x2209560")]
		public <>c__DisplayClass24_0()
		{
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x220A540", Offset = "0x220A641", VA = "0x220A540")]
		internal void <OnLoadingBean>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x04006618 RID: 26136
		[Token(Token = "0x4019201")]
		[FieldOffset(Offset = "0x10")]
		public BeanSowingManager <>4__this;

		// Token: 0x04006619 RID: 26137
		[Token(Token = "0x4019202")]
		[FieldOffset(Offset = "0x18")]
		public int i;
	}

	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20010E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157C50", Offset = "0x157D51")]
	private sealed class <BeanSowingGame>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001F2E RID: 7982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F65")]
		[Address(RVA = "0x220A120", Offset = "0x220A221", VA = "0x220A120")]
		[DebuggerHidden]
		public <BeanSowingGame>d__29(int <>1__state)
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F66")]
		[Address(RVA = "0x220A680", Offset = "0x220A781", VA = "0x220A680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x220A690", Offset = "0x220A791", VA = "0x220A690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9D")]
		private object Current
		{
			[Token(Token = "0x6006F68")]
			[Address(RVA = "0x220AFF0", Offset = "0x220B0F1", VA = "0x220AFF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F69")]
		[Address(RVA = "0x220B000", Offset = "0x220B101", VA = "0x220B000", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C9E")]
		private object Current
		{
			[Token(Token = "0x6006F6A")]
			[Address(RVA = "0x220B060", Offset = "0x220B161", VA = "0x220B060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400661A RID: 26138
		[Token(Token = "0x4019203")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400661B RID: 26139
		[Token(Token = "0x4019204")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400661C RID: 26140
		[Token(Token = "0x4019205")]
		[FieldOffset(Offset = "0x20")]
		public BeanSowingManager <>4__this;

		// Token: 0x0400661D RID: 26141
		[Token(Token = "0x4019206")]
		[FieldOffset(Offset = "0x28")]
		private int <term>5__2;

		// Token: 0x0400661E RID: 26142
		[Token(Token = "0x4019207")]
		[FieldOffset(Offset = "0x2C")]
		private int <count>5__3;
	}
}

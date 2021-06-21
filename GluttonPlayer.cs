using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000523 RID: 1315
[Token(Token = "0x20003BE")]
public class GluttonPlayer : MonoBehaviour
{
	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
	// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000435")]
	public GluttonTablePos CharaPos
	{
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x1FF2BF0", Offset = "0x1FF2CF1", VA = "0x1FF2BF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FFD0", Offset = "0x1A00D1")]
		get
		{
			return GluttonTablePos.Left;
		}
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x1FF2C00", Offset = "0x1FF2D01", VA = "0x1FF2C00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FFE0", Offset = "0x1A00E1")]
		private set
		{
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0000D410 File Offset: 0x0000B610
	// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000436")]
	public GluttonCharaState CharaState
	{
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x1FF2C10", Offset = "0x1FF2D11", VA = "0x1FF2C10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19FFF0", Offset = "0x1A00F1")]
		get
		{
			return GluttonCharaState.Walk;
		}
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x1FF2C20", Offset = "0x1FF2D21", VA = "0x1FF2C20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0000", Offset = "0x1A0101")]
		private set
		{
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000437")]
	public GluttonFood[] CurrentFood
	{
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x1FF2C30", Offset = "0x1FF2D31", VA = "0x1FF2C30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0010", Offset = "0x1A0111")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x1FF2C40", Offset = "0x1FF2D41", VA = "0x1FF2C40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0020", Offset = "0x1A0121")]
		private set
		{
		}
	}

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000438")]
	public GameObject[] FoodDish
	{
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x1FF2C50", Offset = "0x1FF2D51", VA = "0x1FF2C50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0030", Offset = "0x1A0131")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x1FF2C60", Offset = "0x1FF2D61", VA = "0x1FF2C60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0040", Offset = "0x1A0141")]
		private set
		{
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0000D428 File Offset: 0x0000B628
	// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000439")]
	public bool IsMoving
	{
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x1FF2C70", Offset = "0x1FF2D71", VA = "0x1FF2C70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0050", Offset = "0x1A0151")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x1FF2C80", Offset = "0x1FF2D81", VA = "0x1FF2C80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0060", Offset = "0x1A0161")]
		set
		{
		}
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x1FF2C90", Offset = "0x1FF2D91", VA = "0x1FF2C90")]
	private void Start()
	{
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x1FF2F50", Offset = "0x1FF3051", VA = "0x1FF2F50")]
	private void Update()
	{
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x1FF0420", Offset = "0x1FF0521", VA = "0x1FF0420")]
	public void Init(FestivalCharacterController _controller)
	{
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x1FF1100", Offset = "0x1FF1201", VA = "0x1FF1100")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0070", Offset = "0x1A0171")]
	public IEnumerator Run(GluttonTablePos _pos)
	{
		return null;
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B31")]
	[Address(RVA = "0x1FF12B0", Offset = "0x1FF13B1", VA = "0x1FF12B0")]
	public void Eat()
	{
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x1FF3490", Offset = "0x1FF3591", VA = "0x1FF3490")]
	private void DishGenerator()
	{
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x1FF37C0", Offset = "0x1FF38C1", VA = "0x1FF37C0")]
	private void ResetCoolTime()
	{
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x1FF32D0", Offset = "0x1FF33D1", VA = "0x1FF32D0")]
	private void UpdateNpcTimer()
	{
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x0000D440 File Offset: 0x0000B640
	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x1FF0F10", Offset = "0x1FF1011", VA = "0x1FF0F10")]
	public bool CheckNpcTimer()
	{
		return default(bool);
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B36")]
	[Address(RVA = "0x1FF0FF0", Offset = "0x1FF10F1", VA = "0x1FF0FF0")]
	public void ResetNpcTimer()
	{
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B37")]
	[Address(RVA = "0x1FF37E0", Offset = "0x1FF38E1", VA = "0x1FF37E0")]
	public GluttonPlayer()
	{
	}

	// Token: 0x040066C1 RID: 26305
	[Token(Token = "0x40060F4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool isPlayer;

	// Token: 0x040066C2 RID: 26306
	[Token(Token = "0x40060F5")]
	[FieldOffset(Offset = "0x20")]
	private FestivalCharacterController controller;

	// Token: 0x040066C3 RID: 26307
	[Token(Token = "0x40060F6")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165AA0", Offset = "0x165BA1")]
	private GluttonTablePos <CharaPos>k__BackingField;

	// Token: 0x040066C4 RID: 26308
	[Token(Token = "0x40060F7")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165AB0", Offset = "0x165BB1")]
	private GluttonCharaState <CharaState>k__BackingField;

	// Token: 0x040066C5 RID: 26309
	[Token(Token = "0x40060F8")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165AC0", Offset = "0x165BC1")]
	private GluttonFood[] <CurrentFood>k__BackingField;

	// Token: 0x040066C6 RID: 26310
	[Token(Token = "0x40060F9")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165AD0", Offset = "0x165BD1")]
	private GameObject[] <FoodDish>k__BackingField;

	// Token: 0x040066C7 RID: 26311
	[Token(Token = "0x40060FA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject tablePos;

	// Token: 0x040066C8 RID: 26312
	[Token(Token = "0x40060FB")]
	[FieldOffset(Offset = "0x48")]
	private readonly Vector3 PLAYER_BASE_POS;

	// Token: 0x040066C9 RID: 26313
	[Token(Token = "0x40060FC")]
	[FieldOffset(Offset = "0x58")]
	private readonly Vector3[] DISH_POS;

	// Token: 0x040066CA RID: 26314
	[Token(Token = "0x40060FD")]
	[FieldOffset(Offset = "0x60")]
	private Vector3[] playerPos;

	// Token: 0x040066CB RID: 26315
	[Token(Token = "0x40060FE")]
	[FieldOffset(Offset = "0x68")]
	private FoodID pastEated;

	// Token: 0x040066CC RID: 26316
	[Token(Token = "0x40060FF")]
	[FieldOffset(Offset = "0x70")]
	private int[] dishCount;

	// Token: 0x040066CD RID: 26317
	[Token(Token = "0x4006100")]
	[FieldOffset(Offset = "0x78")]
	private int currentFoodLife;

	// Token: 0x040066CE RID: 26318
	[Token(Token = "0x4006101")]
	[FieldOffset(Offset = "0x7C")]
	private int combo;

	// Token: 0x040066CF RID: 26319
	[Token(Token = "0x4006102")]
	[FieldOffset(Offset = "0x80")]
	private bool enableEat;

	// Token: 0x040066D0 RID: 26320
	[Token(Token = "0x4006103")]
	private const float COOL_TIME = 1f;

	// Token: 0x040066D1 RID: 26321
	[Token(Token = "0x4006104")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float actTimeInterval;

	// Token: 0x040066D2 RID: 26322
	[Token(Token = "0x4006105")]
	[FieldOffset(Offset = "0x88")]
	private float actTimeCount;

	// Token: 0x040066D3 RID: 26323
	[Token(Token = "0x4006106")]
	[FieldOffset(Offset = "0x8C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x165B00", Offset = "0x165C01")]
	private bool <IsMoving>k__BackingField;

	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x20010EE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D10", Offset = "0x157E11")]
	private sealed class <Run>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA5")]
		[Address(RVA = "0x1FF3310", Offset = "0x1FF3411", VA = "0x1FF3310")]
		[DebuggerHidden]
		public <Run>d__37(int <>1__state)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA6")]
		[Address(RVA = "0x1FF39E0", Offset = "0x1FF3AE1", VA = "0x1FF39E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6006FA7")]
		[Address(RVA = "0x1FF39F0", Offset = "0x1FF3AF1", VA = "0x1FF39F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CAF")]
		private object Current
		{
			[Token(Token = "0x6006FA8")]
			[Address(RVA = "0x1FF3F30", Offset = "0x1FF4031", VA = "0x1FF3F30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FA9")]
		[Address(RVA = "0x1FF3F40", Offset = "0x1FF4041", VA = "0x1FF3F40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB0")]
		private object Current
		{
			[Token(Token = "0x6006FAA")]
			[Address(RVA = "0x1FF3FA0", Offset = "0x1FF40A1", VA = "0x1FF3FA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040066D4 RID: 26324
		[Token(Token = "0x4019240")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040066D5 RID: 26325
		[Token(Token = "0x4019241")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040066D6 RID: 26326
		[Token(Token = "0x4019242")]
		[FieldOffset(Offset = "0x20")]
		public GluttonPlayer <>4__this;

		// Token: 0x040066D7 RID: 26327
		[Token(Token = "0x4019243")]
		[FieldOffset(Offset = "0x28")]
		public GluttonTablePos _pos;

		// Token: 0x040066D8 RID: 26328
		[Token(Token = "0x4019244")]
		[FieldOffset(Offset = "0x2C")]
		private float <time>5__2;

		// Token: 0x040066D9 RID: 26329
		[Token(Token = "0x4019245")]
		[FieldOffset(Offset = "0x30")]
		private float <speed>5__3;

		// Token: 0x040066DA RID: 26330
		[Token(Token = "0x4019246")]
		[FieldOffset(Offset = "0x34")]
		private float <timeCount>5__4;
	}
}

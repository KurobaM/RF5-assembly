using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x0200025F RID: 607
[Token(Token = "0x20001E6")]
public class PlayerInput : CharacterInput
{
	// Token: 0x06000ED0 RID: 3792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D60")]
	[Address(RVA = "0x2148430", Offset = "0x2148531", VA = "0x2148430")]
	protected void UpdateInputState()
	{
	}

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D61")]
	[Address(RVA = "0x2148610", Offset = "0x2148711", VA = "0x2148610")]
	public void ClearAllInput()
	{
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x06000ED2 RID: 3794 RVA: 0x00006A50 File Offset: 0x00004C50
	// (set) Token: 0x06000ED3 RID: 3795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A8")]
	public static bool Enable
	{
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x2148680", Offset = "0x2148781", VA = "0x2148680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C150", Offset = "0x19C251")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x21486F0", Offset = "0x21487F1", VA = "0x21486F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C160", Offset = "0x19C261")]
		set
		{
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002A9")]
	public static PlayerInput Instance
	{
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x2148760", Offset = "0x2148861", VA = "0x2148760")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C170", Offset = "0x19C271")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x21487D0", Offset = "0x21488D1", VA = "0x21487D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C180", Offset = "0x19C281")]
		private set
		{
		}
	}

	// Token: 0x170002CD RID: 717
	// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002AA")]
	private PlayerInput.InputUpdate inputUpdate
	{
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x2148840", Offset = "0x2148941", VA = "0x2148840")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C190", Offset = "0x19C291")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x2148850", Offset = "0x2148951", VA = "0x2148850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C1A0", Offset = "0x19C2A1")]
		set
		{
		}
	}

	// Token: 0x170002CE RID: 718
	// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002AB")]
	private HumanController humanController
	{
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x2148860", Offset = "0x2148961", VA = "0x2148860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C1B0", Offset = "0x19C2B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x2148870", Offset = "0x2148971", VA = "0x2148870")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C1C0", Offset = "0x19C2C1")]
		set
		{
		}
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x06000EDA RID: 3802 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000EDB RID: 3803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002AC")]
	private MonsterControllerBase monsterController
	{
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x2148880", Offset = "0x2148981", VA = "0x2148880")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C1D0", Offset = "0x19C2D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x2148890", Offset = "0x2148991", VA = "0x2148890")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C1E0", Offset = "0x19C2E1")]
		set
		{
		}
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6C")]
	[Address(RVA = "0x21488A0", Offset = "0x21489A1", VA = "0x21488A0", Slot = "6")]
	public override void SetCharacter(Character character)
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6D")]
	[Address(RVA = "0x2148B30", Offset = "0x2148C31", VA = "0x2148B30")]
	private void Awake()
	{
	}

	// Token: 0x06000EDE RID: 3806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6E")]
	[Address(RVA = "0x2148C10", Offset = "0x2148D11", VA = "0x2148C10", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D6F")]
	[Address(RVA = "0x2148CE0", Offset = "0x2148DE1", VA = "0x2148CE0")]
	protected void OnDisable()
	{
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D70")]
	[Address(RVA = "0x2148DF0", Offset = "0x2148EF1", VA = "0x2148DF0", Slot = "5")]
	protected override void Reset()
	{
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x00006A68 File Offset: 0x00004C68
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x2148E00", Offset = "0x2148F01", VA = "0x2148E00")]
	public bool CanInput()
	{
		return default(bool);
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00006A80 File Offset: 0x00004C80
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x2149110", Offset = "0x2149211", VA = "0x2149110")]
	private Vector3 InputDirection()
	{
		return default(Vector3);
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x2149410", Offset = "0x2149511", VA = "0x2149410")]
	private void Update()
	{
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x2149420", Offset = "0x2149521", VA = "0x2149420")]
	public void UpdateInput()
	{
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x21497B0", Offset = "0x21498B1", VA = "0x21497B0")]
	private void UpdateHumanInput()
	{
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x214A600", Offset = "0x214A701", VA = "0x214A600")]
	private void ChangeWeaponSlot(EquipSlotType weaponType)
	{
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x214A8C0", Offset = "0x214A9C1", VA = "0x214A8C0")]
	public void StartBattleMode(bool attack = false)
	{
	}

	// Token: 0x06000EE8 RID: 3816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x214A930", Offset = "0x214AA31", VA = "0x214A930")]
	private void UpdateMonsterInput()
	{
	}

	// Token: 0x06000EE9 RID: 3817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x214A850", Offset = "0x214A951", VA = "0x214A850")]
	public void StartBattleMode()
	{
	}

	// Token: 0x06000EEA RID: 3818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x214A810", Offset = "0x214A911", VA = "0x214A810")]
	private void EndBattleMode()
	{
	}

	// Token: 0x06000EEB RID: 3819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x214A750", Offset = "0x214A851", VA = "0x214A750")]
	private void LockonAutoUpdate()
	{
	}

	// Token: 0x06000EEC RID: 3820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x214A460", Offset = "0x214A561", VA = "0x214A460")]
	public void ClearLockonTarget()
	{
	}

	// Token: 0x06000EED RID: 3821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x214A4F0", Offset = "0x214A5F1", VA = "0x214A4F0")]
	public void PlayLockonStartSE()
	{
	}

	// Token: 0x06000EEE RID: 3822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0x214A450", Offset = "0x214A551", VA = "0x214A450")]
	public void PlayLockonStopSE()
	{
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7F")]
	[Address(RVA = "0x214B240", Offset = "0x214B341", VA = "0x214B240")]
	private void PadDataClear()
	{
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D80")]
	[Address(RVA = "0x214B350", Offset = "0x214B451", VA = "0x214B350")]
	public static void PadReset()
	{
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D81")]
	[Address(RVA = "0x214B4F0", Offset = "0x214B5F1", VA = "0x214B4F0")]
	public static void SetEnable()
	{
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x214B5C0", Offset = "0x214B6C1", VA = "0x214B5C0")]
	public static void SetDisable()
	{
	}

	// Token: 0x06000EF3 RID: 3827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x214B820", Offset = "0x214B921", VA = "0x214B820")]
	public PlayerInput()
	{
	}

	// Token: 0x06000EF5 RID: 3829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x214BC20", Offset = "0x214BD21", VA = "0x214BC20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C1F0", Offset = "0x19C2F1")]
	private void <UpdateHumanInput>b__40_0()
	{
	}

	// Token: 0x06000EF6 RID: 3830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x214BC50", Offset = "0x214BD51", VA = "0x214BC50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C200", Offset = "0x19C301")]
	private void <UpdateHumanInput>b__40_1()
	{
	}

	// Token: 0x06000EF7 RID: 3831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x214BC80", Offset = "0x214BD81", VA = "0x214BC80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C210", Offset = "0x19C311")]
	private void <UpdateMonsterInput>b__43_0()
	{
	}

	// Token: 0x06000EF8 RID: 3832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x214BCB0", Offset = "0x214BDB1", VA = "0x214BCB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C220", Offset = "0x19C321")]
	private void <UpdateMonsterInput>b__43_1()
	{
	}

	// Token: 0x0400089A RID: 2202
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x20")]
	protected PlayerInput.InputState[] m_InputState;

	// Token: 0x0400089B RID: 2203
	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E5B0", Offset = "0x15E6B1")]
	private static bool <Enable>k__BackingField;

	// Token: 0x0400089C RID: 2204
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x28")]
	private bool m_AutoLockon;

	// Token: 0x0400089D RID: 2205
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x4")]
	private static float m_EnableCounter;

	// Token: 0x0400089E RID: 2206
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve m_MoveInputPowerCurve;

	// Token: 0x0400089F RID: 2207
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E5D0", Offset = "0x15E6D1")]
	private static PlayerInput <Instance>k__BackingField;

	// Token: 0x040008A0 RID: 2208
	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E5E0", Offset = "0x15E6E1")]
	private PlayerInput.InputUpdate <inputUpdate>k__BackingField;

	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E5F0", Offset = "0x15E6F1")]
	private HumanController <humanController>k__BackingField;

	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E600", Offset = "0x15E701")]
	private MonsterControllerBase <monsterController>k__BackingField;

	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E610", Offset = "0x15E711")]
	private float m_AvoidInputTimeLimit;

	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2001002")]
	protected enum KeyType
	{
		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x4018E34")]
		A,
		// Token: 0x040008A6 RID: 2214
		[Token(Token = "0x4018E35")]
		B,
		// Token: 0x040008A7 RID: 2215
		[Token(Token = "0x4018E36")]
		X,
		// Token: 0x040008A8 RID: 2216
		[Token(Token = "0x4018E37")]
		Y,
		// Token: 0x040008A9 RID: 2217
		[Token(Token = "0x4018E38")]
		RB,
		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x4018E39")]
		RT,
		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x4018E3A")]
		LB,
		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x4018E3B")]
		LT
	}

	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2001003")]
	protected enum KeyState
	{
		// Token: 0x040008AE RID: 2222
		[Token(Token = "0x4018E3D")]
		Standby,
		// Token: 0x040008AF RID: 2223
		[Token(Token = "0x4018E3E")]
		Entry,
		// Token: 0x040008B0 RID: 2224
		[Token(Token = "0x4018E3F")]
		Press,
		// Token: 0x040008B1 RID: 2225
		[Token(Token = "0x4018E40")]
		Release
	}

	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2001004")]
	protected class InputState
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE0")]
		public Key Key
		{
			[Token(Token = "0x6006C5B")]
			[Address(RVA = "0x214BCE0", Offset = "0x214BDE1", VA = "0x214BCE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFFD0", Offset = "0x1B00D1")]
			get
			{
				return (Key)0;
			}
			[Token(Token = "0x6006C5C")]
			[Address(RVA = "0x214BCF0", Offset = "0x214BDF1", VA = "0x214BCF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFFE0", Offset = "0x1B00E1")]
			private set
			{
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00006AB0 File Offset: 0x00004CB0
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE1")]
		public PlayerInput.KeyState State
		{
			[Token(Token = "0x6006C5D")]
			[Address(RVA = "0x214BD00", Offset = "0x214BE01", VA = "0x214BD00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AFFF0", Offset = "0x1B00F1")]
			get
			{
				return PlayerInput.KeyState.Standby;
			}
			[Token(Token = "0x6006C5E")]
			[Address(RVA = "0x214BD10", Offset = "0x214BE11", VA = "0x214BD10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0000", Offset = "0x1B0101")]
			private set
			{
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x17000BE2")]
		public bool IsStandby
		{
			[Token(Token = "0x6006C5F")]
			[Address(RVA = "0x214A5C0", Offset = "0x214A6C1", VA = "0x214A5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000EFE RID: 3838 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x17000BE3")]
		public bool IsEntry
		{
			[Token(Token = "0x6006C60")]
			[Address(RVA = "0x214A5D0", Offset = "0x214A6D1", VA = "0x214A5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x17000BE4")]
		public bool IsPress
		{
			[Token(Token = "0x6006C61")]
			[Address(RVA = "0x214A5E0", Offset = "0x214A6E1", VA = "0x214A5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x17000BE5")]
		public bool IsRelease
		{
			[Token(Token = "0x6006C62")]
			[Address(RVA = "0x214A5B0", Offset = "0x214A6B1", VA = "0x214A5B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00006B28 File Offset: 0x00004D28
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BE6")]
		public float Elapsed
		{
			[Token(Token = "0x6006C63")]
			[Address(RVA = "0x214BD20", Offset = "0x214BE21", VA = "0x214BD20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0010", Offset = "0x1B0111")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006C64")]
			[Address(RVA = "0x214BD30", Offset = "0x214BE31", VA = "0x214BD30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B0020", Offset = "0x1B0121")]
			set
			{
			}
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C65")]
		[Address(RVA = "0x214BBC0", Offset = "0x214BCC1", VA = "0x214BBC0")]
		public InputState(Key key, bool enablePushEnter)
		{
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C66")]
		[Address(RVA = "0x21484A0", Offset = "0x21485A1", VA = "0x21484A0")]
		public void Update()
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C67")]
		[Address(RVA = "0x214BD40", Offset = "0x214BE41", VA = "0x214BD40")]
		public void Press()
		{
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C68")]
		[Address(RVA = "0x214BD60", Offset = "0x214BE61", VA = "0x214BD60")]
		public void Release()
		{
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C69")]
		[Address(RVA = "0x2148670", Offset = "0x2148771", VA = "0x2148670")]
		public void Clear()
		{
		}

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x4018E41")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194E00", Offset = "0x194F01")]
		private Key <Key>k__BackingField;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x4018E42")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194E10", Offset = "0x194F11")]
		private PlayerInput.KeyState <State>k__BackingField;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x4018E43")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x194E20", Offset = "0x194F21")]
		private float <Elapsed>k__BackingField;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x4018E44")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_EnablePushEnter;
	}

	// Token: 0x02000263 RID: 611
	// (Invoke) Token: 0x06000F09 RID: 3849
	[Token(Token = "0x2001005")]
	private delegate void InputUpdate();
}

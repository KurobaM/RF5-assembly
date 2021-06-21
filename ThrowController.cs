using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000257 RID: 599
[Token(Token = "0x20001E2")]
public class ThrowController : MonoBehaviour
{
	// Token: 0x170002B5 RID: 693
	// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E79 RID: 3705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000294")]
	private HoldableInterface HoldObj
	{
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x205ED60", Offset = "0x205EE61", VA = "0x205ED60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BEB0", Offset = "0x19BFB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D10")]
		[Address(RVA = "0x205ED70", Offset = "0x205EE71", VA = "0x205ED70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BEC0", Offset = "0x19BFC1")]
		set
		{
		}
	}

	// Token: 0x170002B6 RID: 694
	// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000295")]
	private Collider Collider
	{
		[Token(Token = "0x6000D11")]
		[Address(RVA = "0x205ED80", Offset = "0x205EE81", VA = "0x205ED80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BED0", Offset = "0x19BFD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D12")]
		[Address(RVA = "0x205ED90", Offset = "0x205EE91", VA = "0x205ED90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BEE0", Offset = "0x19BFE1")]
		set
		{
		}
	}

	// Token: 0x170002B7 RID: 695
	// (get) Token: 0x06000E7C RID: 3708 RVA: 0x00006918 File Offset: 0x00004B18
	[Token(Token = "0x17000296")]
	private float Range
	{
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x205EDA0", Offset = "0x205EEA1", VA = "0x205EDA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00006930 File Offset: 0x00004B30
	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x205EDD0", Offset = "0x205EED1", VA = "0x205EDD0")]
	private bool HasThrowRing()
	{
		return default(bool);
	}

	// Token: 0x170002B8 RID: 696
	// (get) Token: 0x06000E7E RID: 3710 RVA: 0x00006948 File Offset: 0x00004B48
	// (set) Token: 0x06000E7F RID: 3711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000297")]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x205EE50", Offset = "0x205EF51", VA = "0x205EE50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BEF0", Offset = "0x19BFF1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x205EE60", Offset = "0x205EF61", VA = "0x205EE60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF00", Offset = "0x19C001")]
		private set
		{
		}
	}

	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00006960 File Offset: 0x00004B60
	// (set) Token: 0x06000E81 RID: 3713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000298")]
	private int BoundNum
	{
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x205EE70", Offset = "0x205EF71", VA = "0x205EE70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF10", Offset = "0x19C011")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x205EE80", Offset = "0x205EF81", VA = "0x205EE80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF20", Offset = "0x19C021")]
		set
		{
		}
	}

	// Token: 0x170002BA RID: 698
	// (get) Token: 0x06000E82 RID: 3714 RVA: 0x00006978 File Offset: 0x00004B78
	// (set) Token: 0x06000E83 RID: 3715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000299")]
	private Vector3 PrevPos
	{
		[Token(Token = "0x6000D19")]
		[Address(RVA = "0x205EE90", Offset = "0x205EF91", VA = "0x205EE90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF30", Offset = "0x19C031")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D1A")]
		[Address(RVA = "0x205EEA0", Offset = "0x205EFA1", VA = "0x205EEA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF40", Offset = "0x19C041")]
		set
		{
		}
	}

	// Token: 0x170002BB RID: 699
	// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00006990 File Offset: 0x00004B90
	// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700029A")]
	private Vector3 TargetPos
	{
		[Token(Token = "0x6000D1B")]
		[Address(RVA = "0x205EEB0", Offset = "0x205EFB1", VA = "0x205EEB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF50", Offset = "0x19C051")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x205EEC0", Offset = "0x205EFC1", VA = "0x205EEC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF60", Offset = "0x19C061")]
		set
		{
		}
	}

	// Token: 0x170002BC RID: 700
	// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000069A8 File Offset: 0x00004BA8
	// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700029B")]
	private Vector3 LandPlanPoint
	{
		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x205EED0", Offset = "0x205EFD1", VA = "0x205EED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF70", Offset = "0x19C071")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x205EEE0", Offset = "0x205EFE1", VA = "0x205EEE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF80", Offset = "0x19C081")]
		set
		{
		}
	}

	// Token: 0x170002BD RID: 701
	// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000069C0 File Offset: 0x00004BC0
	// (set) Token: 0x06000E89 RID: 3721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700029C")]
	private Vector3 Position
	{
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x205EEF0", Offset = "0x205EFF1", VA = "0x205EEF0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x205EFC0", Offset = "0x205F0C1", VA = "0x205EFC0")]
		set
		{
		}
	}

	// Token: 0x170002BE RID: 702
	// (get) Token: 0x06000E8A RID: 3722 RVA: 0x000069D8 File Offset: 0x00004BD8
	// (set) Token: 0x06000E8B RID: 3723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700029D")]
	public bool IsThrow
	{
		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x205F090", Offset = "0x205F191", VA = "0x205F090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BF90", Offset = "0x19C091")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x205F0A0", Offset = "0x205F1A1", VA = "0x205F0A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BFA0", Offset = "0x19C0A1")]
		protected set
		{
		}
	}

	// Token: 0x170002BF RID: 703
	// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E8D RID: 3725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700029E")]
	public HumanController ThrowOwner
	{
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x205F0B0", Offset = "0x205F1B1", VA = "0x205F0B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BFB0", Offset = "0x19C0B1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x205F0C0", Offset = "0x205F1C1", VA = "0x205F0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BFC0", Offset = "0x19C0C1")]
		private set
		{
		}
	}

	// Token: 0x170002C0 RID: 704
	// (get) Token: 0x06000E8E RID: 3726 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700029F")]
	private HashSet<GameObject> TriggerChecks
	{
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x205F0D0", Offset = "0x205F1D1", VA = "0x205F0D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BFD0", Offset = "0x19C0D1")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D26")]
	[Address(RVA = "0x205F0E0", Offset = "0x205F1E1", VA = "0x205F0E0")]
	private void Awake()
	{
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D27")]
	[Address(RVA = "0x205F170", Offset = "0x205F271", VA = "0x205F170")]
	public void OnThrow(Vector3 position, HumanController human, [Optional] CharacterBase target)
	{
	}

	// Token: 0x06000E91 RID: 3729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D28")]
	[Address(RVA = "0x205F9E0", Offset = "0x205FAE1", VA = "0x205F9E0")]
	public void OnThrow(HumanController human)
	{
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D29")]
	[Address(RVA = "0x205FB10", Offset = "0x205FC11", VA = "0x205FB10")]
	private void UpdateThrow(float deltaTime)
	{
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2A")]
	[Address(RVA = "0x2060270", Offset = "0x2060371", VA = "0x2060270")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000E94 RID: 3732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D2B")]
	[Address(RVA = "0x20602B0", Offset = "0x20603B1", VA = "0x20602B0")]
	public ThrowController()
	{
	}

	// Token: 0x04000852 RID: 2130
	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E440", Offset = "0x15E541")]
	private HoldableInterface <HoldObj>k__BackingField;

	// Token: 0x04000853 RID: 2131
	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E450", Offset = "0x15E551")]
	private Collider <Collider>k__BackingField;

	// Token: 0x04000854 RID: 2132
	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float TriggerRadius;

	// Token: 0x04000855 RID: 2133
	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float PhysicsRadius;

	// Token: 0x04000856 RID: 2134
	[Token(Token = "0x40006BA")]
	public const int BoundNumMax = -1;

	// Token: 0x04000857 RID: 2135
	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public CharacterBase Target;

	// Token: 0x04000858 RID: 2136
	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E480", Offset = "0x15E581")]
	private Vector3 <Velocity>k__BackingField;

	// Token: 0x04000859 RID: 2137
	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E490", Offset = "0x15E591")]
	private int <BoundNum>k__BackingField;

	// Token: 0x0400085A RID: 2138
	[Token(Token = "0x40006BE")]
	private const float Gravity = 9.8f;

	// Token: 0x0400085B RID: 2139
	[Token(Token = "0x40006BF")]
	private const float BaseRange = 10f;

	// Token: 0x0400085C RID: 2140
	[Token(Token = "0x40006C0")]
	private const float UpRange = 50f;

	// Token: 0x0400085D RID: 2141
	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E4A0", Offset = "0x15E5A1")]
	private Vector3 <PrevPos>k__BackingField;

	// Token: 0x0400085E RID: 2142
	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E4B0", Offset = "0x15E5B1")]
	private Vector3 <TargetPos>k__BackingField;

	// Token: 0x0400085F RID: 2143
	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E4C0", Offset = "0x15E5C1")]
	private Vector3 <LandPlanPoint>k__BackingField;

	// Token: 0x04000860 RID: 2144
	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E4D0", Offset = "0x15E5D1")]
	private bool <IsThrow>k__BackingField;

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E4E0", Offset = "0x15E5E1")]
	private HumanController <ThrowOwner>k__BackingField;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E4F0", Offset = "0x15E5F1")]
	private readonly HashSet<GameObject> <TriggerChecks>k__BackingField;
}

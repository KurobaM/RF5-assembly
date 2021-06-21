using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005F8 RID: 1528
[Token(Token = "0x200044C")]
public class MushroomSpore : MonoBehaviour
{
	// Token: 0x060025C6 RID: 9670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x1E1D890", Offset = "0x1E1D991", VA = "0x1E1D890", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060025C7 RID: 9671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x1E1D940", Offset = "0x1E1DA41", VA = "0x1E1D940", Slot = "5")]
	protected virtual void Erase()
	{
	}

	// Token: 0x060025C8 RID: 9672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x1E1D9C0", Offset = "0x1E1DAC1", VA = "0x1E1D9C0")]
	private void Update()
	{
	}

	// Token: 0x060025C9 RID: 9673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FDF")]
	[Address(RVA = "0x1E1DFA0", Offset = "0x1E1E0A1", VA = "0x1E1DFA0")]
	public MushroomSpore()
	{
	}

	// Token: 0x060025CA RID: 9674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x1E1E050", Offset = "0x1E1E151", VA = "0x1E1E050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A18D0", Offset = "0x1A19D1")]
	private void <Awake>b__6_0()
	{
	}

	// Token: 0x04006D06 RID: 27910
	[Token(Token = "0x400661E")]
	[FieldOffset(Offset = "0x18")]
	public DamageInfo DamageInfo;

	// Token: 0x04006D07 RID: 27911
	[Token(Token = "0x400661F")]
	[FieldOffset(Offset = "0x98")]
	public float Duration;

	// Token: 0x04006D08 RID: 27912
	[Token(Token = "0x4006620")]
	[FieldOffset(Offset = "0xA0")]
	protected SphereCollider AreaCollider;

	// Token: 0x04006D09 RID: 27913
	[Token(Token = "0x4006621")]
	[FieldOffset(Offset = "0xA8")]
	protected Vector3 ColliderPosition;

	// Token: 0x04006D0A RID: 27914
	[Token(Token = "0x4006622")]
	[FieldOffset(Offset = "0xB8")]
	protected HashSet<Character> HitCharacters;

	// Token: 0x04006D0B RID: 27915
	[Token(Token = "0x4006623")]
	[FieldOffset(Offset = "0xC0")]
	private Collider[] results;
}

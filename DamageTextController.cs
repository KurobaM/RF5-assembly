using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000895 RID: 2197
[Token(Token = "0x20005AD")]
public class DamageTextController
{
	// Token: 0x17000807 RID: 2055
	// (get) Token: 0x060039CF RID: 14799 RVA: 0x00013F80 File Offset: 0x00012180
	[Token(Token = "0x1700064C")]
	public int Count
	{
		[Token(Token = "0x600303F")]
		[Address(RVA = "0x1DA3190", Offset = "0x1DA3291", VA = "0x1DA3190")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000808 RID: 2056
	// (get) Token: 0x060039D0 RID: 14800 RVA: 0x00013F98 File Offset: 0x00012198
	// (set) Token: 0x060039D1 RID: 14801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700064D")]
	private float m_Interval
	{
		[Token(Token = "0x6003040")]
		[Address(RVA = "0x1DA31E0", Offset = "0x1DA32E1", VA = "0x1DA31E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5F90", Offset = "0x1A6091")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6003041")]
		[Address(RVA = "0x1DA31F0", Offset = "0x1DA32F1", VA = "0x1DA31F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5FA0", Offset = "0x1A60A1")]
		set
		{
		}
	}

	// Token: 0x060039D2 RID: 14802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003042")]
	[Address(RVA = "0x1DA3200", Offset = "0x1DA3301", VA = "0x1DA3200")]
	public void Update()
	{
	}

	// Token: 0x060039D3 RID: 14803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003043")]
	[Address(RVA = "0x1DA3360", Offset = "0x1DA3461", VA = "0x1DA3360")]
	public void AddText(ref DamageTextInfo info)
	{
	}

	// Token: 0x060039D4 RID: 14804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003044")]
	[Address(RVA = "0x1DA3400", Offset = "0x1DA3501", VA = "0x1DA3400")]
	public DamageTextController()
	{
	}

	// Token: 0x04007D60 RID: 32096
	[Token(Token = "0x4007155")]
	[FieldOffset(Offset = "0x10")]
	private Queue<DamageTextInfo> m_InfoQueue;

	// Token: 0x04007D61 RID: 32097
	[Token(Token = "0x4007156")]
	private const float Interval = 0.2f;

	// Token: 0x04007D62 RID: 32098
	[Token(Token = "0x4007157")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E3F0", Offset = "0x16E4F1")]
	private float <m_Interval>k__BackingField;
}

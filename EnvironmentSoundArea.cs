using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200087C RID: 2172
[Token(Token = "0x20005A0")]
public class EnvironmentSoundArea : MonoBehaviour
{
	// Token: 0x170007F6 RID: 2038
	// (get) Token: 0x06003945 RID: 14661 RVA: 0x00013D70 File Offset: 0x00011F70
	[Token(Token = "0x1700063B")]
	public SoundID SoundID
	{
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x22B4780", Offset = "0x22B4881", VA = "0x22B4780")]
		get
		{
			return SoundID.Sound_EMPTY;
		}
	}

	// Token: 0x170007F7 RID: 2039
	// (get) Token: 0x06003946 RID: 14662 RVA: 0x00013D88 File Offset: 0x00011F88
	[Token(Token = "0x1700063C")]
	public float Volume
	{
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0x22B4790", Offset = "0x22B4891", VA = "0x22B4790")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06003947 RID: 14663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FCB")]
	[Address(RVA = "0x22B47B0", Offset = "0x22B48B1", VA = "0x22B47B0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06003948 RID: 14664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FCC")]
	[Address(RVA = "0x22B4860", Offset = "0x22B4961", VA = "0x22B4860")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06003949 RID: 14665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002FCD")]
	[Address(RVA = "0x22B4910", Offset = "0x22B4A11", VA = "0x22B4910")]
	public EnvironmentSoundArea()
	{
	}

	// Token: 0x04007C9D RID: 31901
	[Token(Token = "0x40070B0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SoundID m_SoundID;

	// Token: 0x04007C9E RID: 31902
	[Token(Token = "0x40070B1")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16E020", Offset = "0x16E121")]
	private float m_Volume;
}

using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005BE RID: 1470
[Token(Token = "0x2000420")]
public class DN17LightArea : MonoBehaviour
{
	// Token: 0x170005E4 RID: 1508
	// (get) Token: 0x06002412 RID: 9234 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004B6")]
	public DN17LightAreaManager DN17LightAreaManager
	{
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x1D9EFE0", Offset = "0x1D9F0E1", VA = "0x1D9EFE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1290", Offset = "0x1A1391")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x1D9EFF0", Offset = "0x1D9F0F1", VA = "0x1D9EFF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A12A0", Offset = "0x1A13A1")]
		set
		{
		}
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5A")]
	[Address(RVA = "0x1D9F000", Offset = "0x1D9F101", VA = "0x1D9F000")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E5B")]
	[Address(RVA = "0x1D9F270", Offset = "0x1D9F371", VA = "0x1D9F270")]
	public DN17LightArea()
	{
	}

	// Token: 0x04006B7C RID: 27516
	[Token(Token = "0x40064D3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Color Color;

	// Token: 0x04006B7D RID: 27517
	[Token(Token = "0x40064D4")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x166BB0", Offset = "0x166CB1")]
	private DN17LightAreaManager <DN17LightAreaManager>k__BackingField;
}

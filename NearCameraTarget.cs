using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A8 RID: 424
[Token(Token = "0x200014D")]
public class NearCameraTarget : MonoBehaviour
{
	// Token: 0x170001AE RID: 430
	// (get) Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000197")]
	private Transform Target
	{
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1E23160", Offset = "0x1E23261", VA = "0x1E23160")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000198")]
	private Transform Parent
	{
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1E23260", Offset = "0x1E23361", VA = "0x1E23260")]
		get
		{
			return null;
		}
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000792")]
	[Address(RVA = "0x1E23290", Offset = "0x1E23391", VA = "0x1E23290")]
	private void Update()
	{
	}

	// Token: 0x060008CE RID: 2254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000793")]
	[Address(RVA = "0x1E23420", Offset = "0x1E23521", VA = "0x1E23420")]
	public NearCameraTarget()
	{
	}

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15C8C0", Offset = "0x15C9C1")]
	private float Percent;
}

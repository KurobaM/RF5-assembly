using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000558 RID: 1368
[Token(Token = "0x20003E1")]
public class RealtimeBakeLight : MonoBehaviour
{
	// Token: 0x17000565 RID: 1381
	// (get) Token: 0x0600212D RID: 8493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700045D")]
	public Light Light
	{
		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0x1F3AEA0", Offset = "0x1F3AFA1", VA = "0x1F3AEA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x1F3AEB0", Offset = "0x1F3AFB1", VA = "0x1F3AEB0")]
	private void Awake()
	{
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x1F3AF40", Offset = "0x1F3B041", VA = "0x1F3AF40")]
	private void Start()
	{
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x1F3B010", Offset = "0x1F3B111", VA = "0x1F3B010")]
	private void OnDestroy()
	{
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C30")]
	[Address(RVA = "0x1F3B0E0", Offset = "0x1F3B1E1", VA = "0x1F3B0E0")]
	public RealtimeBakeLight()
	{
	}

	// Token: 0x040067E4 RID: 26596
	[Token(Token = "0x40061C9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Light _Light;

	// Token: 0x040067E5 RID: 26597
	[Token(Token = "0x40061CA")]
	[FieldOffset(Offset = "0x20")]
	private bool IsSetLight;
}

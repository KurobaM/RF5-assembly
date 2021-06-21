using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D9 RID: 1497
[Token(Token = "0x2000437")]
public class GimmickFallIcicle : MonoBehaviour
{
	// Token: 0x170005F4 RID: 1524
	// (get) Token: 0x060024CC RID: 9420 RVA: 0x0000ED18 File Offset: 0x0000CF18
	[Token(Token = "0x170004C2")]
	private bool IsInsideTarget
	{
		[Token(Token = "0x6001F06")]
		[Address(RVA = "0x1FE2EC0", Offset = "0x1FE2FC1", VA = "0x1FE2EC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060024CD RID: 9421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F07")]
	[Address(RVA = "0x1FE2ED0", Offset = "0x1FE2FD1", VA = "0x1FE2ED0")]
	private void Start()
	{
	}

	// Token: 0x060024CE RID: 9422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x1FE2EE0", Offset = "0x1FE2FE1", VA = "0x1FE2EE0")]
	private void Update()
	{
	}

	// Token: 0x060024CF RID: 9423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x1FE2EF0", Offset = "0x1FE2FF1", VA = "0x1FE2EF0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x1FE3150", Offset = "0x1FE3251", VA = "0x1FE3150")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001F0B")]
	[Address(RVA = "0x1FE33B0", Offset = "0x1FE34B1", VA = "0x1FE33B0")]
	public GimmickFallIcicle()
	{
	}

	// Token: 0x04006C23 RID: 27683
	[Token(Token = "0x4006566")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float Interval;

	// Token: 0x04006C24 RID: 27684
	[Token(Token = "0x4006567")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float Damage;

	// Token: 0x04006C25 RID: 27685
	[Token(Token = "0x4006568")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private IcicleSpawnArea GimmickArea;

	// Token: 0x04006C26 RID: 27686
	[Token(Token = "0x4006569")]
	[FieldOffset(Offset = "0x28")]
	private int InsideCounter;
}

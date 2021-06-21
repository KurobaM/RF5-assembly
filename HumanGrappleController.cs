using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023D RID: 573
[Token(Token = "0x20001CD")]
public class HumanGrappleController : CharaGrappleController<HumanController>
{
	// Token: 0x06000D96 RID: 3478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C35")]
	[Address(RVA = "0x20A5B00", Offset = "0x20A5C01", VA = "0x20A5B00", Slot = "5")]
	public override void Setup()
	{
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C36")]
	[Address(RVA = "0x20A6090", Offset = "0x20A6191", VA = "0x20A6090")]
	private void AddHandTransform(Transform hand)
	{
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C37")]
	[Address(RVA = "0x20A6140", Offset = "0x20A6241", VA = "0x20A6140", Slot = "10")]
	public override void DoRelease()
	{
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C38")]
	[Address(RVA = "0x20A61D0", Offset = "0x20A62D1", VA = "0x20A61D0", Slot = "7")]
	public override void DoCancel()
	{
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x6000C39")]
	[Address(RVA = "0x20A6260", Offset = "0x20A6361", VA = "0x20A6260", Slot = "11")]
	public override bool DoGrap(GrapInterface target)
	{
		return default(bool);
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3A")]
	[Address(RVA = "0x20A6340", Offset = "0x20A6441", VA = "0x20A6340", Slot = "12")]
	public override void DoThrow(float angle, float power, MagicParamID id1, MagicParamID id2 = MagicParamID.EMPTY)
	{
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x6000C3B")]
	[Address(RVA = "0x20A6590", Offset = "0x20A6691", VA = "0x20A6590")]
	private float GetMotionPower(int level)
	{
		return 0f;
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3C")]
	[Address(RVA = "0x20A6670", Offset = "0x20A6771", VA = "0x20A6670", Slot = "15")]
	public override void DoFlung()
	{
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3D")]
	[Address(RVA = "0x20A6770", Offset = "0x20A6871", VA = "0x20A6770", Slot = "13")]
	public override void DoPound()
	{
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3E")]
	[Address(RVA = "0x20A6910", Offset = "0x20A6A11", VA = "0x20A6910", Slot = "16")]
	public override void DoSwing()
	{
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C3F")]
	[Address(RVA = "0x20A6AA0", Offset = "0x20A6BA1", VA = "0x20A6AA0", Slot = "17")]
	public override void DoSlam()
	{
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x00006570 File Offset: 0x00004770
	[Token(Token = "0x6000C40")]
	[Address(RVA = "0x20A6C30", Offset = "0x20A6D31", VA = "0x20A6C30", Slot = "21")]
	protected override DamageInfo CreateDamageInfo(MagicParamID id)
	{
		return default(DamageInfo);
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C41")]
	[Address(RVA = "0x20A6E40", Offset = "0x20A6F41", VA = "0x20A6E40", Slot = "20")]
	protected override void OnTakeDamage(DamageInfo damageInfo, DamageResult damageResult)
	{
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C42")]
	[Address(RVA = "0x20A6FD0", Offset = "0x20A70D1", VA = "0x20A6FD0")]
	public HumanGrappleController()
	{
	}

	// Token: 0x040007D3 RID: 2003
	[Token(Token = "0x400065C")]
	private const float m_ThrowRecoilPower = 1f;

	// Token: 0x040007D4 RID: 2004
	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x50")]
	protected int m_poundCount;
}

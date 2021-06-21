using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000607 RID: 1543
[Token(Token = "0x2000457")]
public class HitMaster : MonoBehaviour
{
	// Token: 0x17000623 RID: 1571
	// (get) Token: 0x0600262A RID: 9770 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E1")]
	public HitController[] HitControllers
	{
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x24F65A0", Offset = "0x24F66A1", VA = "0x24F65A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000624 RID: 1572
	// (get) Token: 0x0600262B RID: 9771 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004E2")]
	public HumanController HumanController
	{
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x24F65B0", Offset = "0x24F66B1", VA = "0x24F65B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002034")]
	[Address(RVA = "0x24F6670", Offset = "0x24F6771", VA = "0x24F6670")]
	public void SetCharId(CharID charID)
	{
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002035")]
	[Address(RVA = "0x24F6680", Offset = "0x24F6781", VA = "0x24F6680")]
	public void ResetPosition(float position)
	{
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002036")]
	[Address(RVA = "0x24F6780", Offset = "0x24F6881", VA = "0x24F6780")]
	public void ResetScale(float scale)
	{
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002037")]
	[Address(RVA = "0x24F6880", Offset = "0x24F6981", VA = "0x24F6880")]
	public void SetMotionType(HumanMotionType motionType)
	{
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002038")]
	[Address(RVA = "0x24F6970", Offset = "0x24F6A71", VA = "0x24F6970")]
	public HitController GetHitController()
	{
		return null;
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002039")]
	[Address(RVA = "0x24F69D0", Offset = "0x24F6AD1", VA = "0x24F69D0")]
	public HitController GetHitController(HumanMotionType motionType)
	{
		return null;
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600203A")]
	[Address(RVA = "0x24F6A10", Offset = "0x24F6B11", VA = "0x24F6A10")]
	private void Awake()
	{
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600203B")]
	[Address(RVA = "0x24F6AD0", Offset = "0x24F6BD1", VA = "0x24F6AD0")]
	public HitMaster()
	{
	}

	// Token: 0x04006D67 RID: 28007
	[Token(Token = "0x400666C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private CharID CharID;

	// Token: 0x04006D68 RID: 28008
	[Token(Token = "0x400666D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HitController[] hitControllers;

	// Token: 0x04006D69 RID: 28009
	[Token(Token = "0x400666E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HumanMotionType activeMotionType;

	// Token: 0x04006D6A RID: 28010
	[Token(Token = "0x400666F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public HumanController Human;
}

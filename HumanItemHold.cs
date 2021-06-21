using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200023F RID: 575
[Token(Token = "0x20001CF")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x145940", Offset = "0x145A41")]
public class HumanItemHold : MonoBehaviour
{
	// Token: 0x1700029B RID: 667
	// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027B")]
	private HumanStatus HumanStatus
	{
		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x20A7A00", Offset = "0x20A7B01", VA = "0x20A7A00")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700029C RID: 668
	// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027C")]
	private HumanModel HumanModel
	{
		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x20A7AB0", Offset = "0x20A7BB1", VA = "0x20A7AB0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700029D RID: 669
	// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027D")]
	public HoldableInterface HoldItem
	{
		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x20A7BA0", Offset = "0x20A7CA1", VA = "0x20A7BA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x20A7BB0", Offset = "0x20A7CB1", VA = "0x20A7BB0")]
	private void SetHoldItem(HoldableInterface value)
	{
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C48")]
	[Address(RVA = "0x20A7E60", Offset = "0x20A7F61", VA = "0x20A7E60")]
	private void SetHoldItemWithItemData(HoldableInterface value)
	{
	}

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700027E")]
	public ItemData HoldItemData
	{
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x209DD30", Offset = "0x209DE31", VA = "0x209DD30")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00006588 File Offset: 0x00004788
	[Token(Token = "0x1700027F")]
	public bool IsHold
	{
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x2095B90", Offset = "0x2095C91", VA = "0x2095B90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x000065A0 File Offset: 0x000047A0
	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x20A7FE0", Offset = "0x20A80E1", VA = "0x20A7FE0")]
	public bool CanHold()
	{
		return default(bool);
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x000065B8 File Offset: 0x000047B8
	[Token(Token = "0x6000C4C")]
	[Address(RVA = "0x20A81D0", Offset = "0x20A82D1", VA = "0x20A81D0")]
	public bool CanGrapple()
	{
		return default(bool);
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x06000DAE RID: 3502 RVA: 0x000065D0 File Offset: 0x000047D0
	// (set) Token: 0x06000DAF RID: 3503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000280")]
	public int FurnitureRotateY
	{
		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x20A81E0", Offset = "0x20A82E1", VA = "0x20A81E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BDB0", Offset = "0x19BEB1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000C4E")]
		[Address(RVA = "0x20A81F0", Offset = "0x20A82F1", VA = "0x20A81F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BDC0", Offset = "0x19BEC1")]
		private set
		{
		}
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x000065E8 File Offset: 0x000047E8
	// (set) Token: 0x06000DB1 RID: 3505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000281")]
	private HoldMotionType CurrentHoldMotionType
	{
		[Token(Token = "0x6000C4F")]
		[Address(RVA = "0x20A8200", Offset = "0x20A8301", VA = "0x20A8200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BDD0", Offset = "0x19BED1")]
		get
		{
			return HoldMotionType.Head;
		}
		[Token(Token = "0x6000C50")]
		[Address(RVA = "0x20A8210", Offset = "0x20A8311", VA = "0x20A8210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BDE0", Offset = "0x19BEE1")]
		set
		{
		}
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00006600 File Offset: 0x00004800
	// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000282")]
	private float y_offset
	{
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x20A8220", Offset = "0x20A8321", VA = "0x20A8220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BDF0", Offset = "0x19BEF1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x20A8230", Offset = "0x20A8331", VA = "0x20A8230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE00", Offset = "0x19BF01")]
		set
		{
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00006618 File Offset: 0x00004818
	// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000283")]
	private float y_offset_yasai_head
	{
		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x20A8240", Offset = "0x20A8341", VA = "0x20A8240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE10", Offset = "0x19BF11")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x20A8250", Offset = "0x20A8351", VA = "0x20A8250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE20", Offset = "0x19BF21")]
		set
		{
		}
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C55")]
	[Address(RVA = "0x209DE00", Offset = "0x209DF01", VA = "0x209DE00")]
	public void Pickup(HoldableInterface holdableInterface)
	{
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C56")]
	[Address(RVA = "0x20A8500", Offset = "0x20A8601", VA = "0x20A8500")]
	public void Hold(HoldableInterface holdableInterface)
	{
	}

	// Token: 0x06000DB8 RID: 3512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C57")]
	[Address(RVA = "0x20A87B0", Offset = "0x20A88B1", VA = "0x20A87B0")]
	public void Present(ItemInteractionInterface itemInteractionInterface)
	{
	}

	// Token: 0x06000DB9 RID: 3513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C58")]
	[Address(RVA = "0x20A87E0", Offset = "0x20A88E1", VA = "0x20A87E0")]
	public void PutIn(ItemInteractionInterface itemInteractionInterface)
	{
	}

	// Token: 0x06000DBA RID: 3514 RVA: 0x00006630 File Offset: 0x00004830
	[Token(Token = "0x6000C59")]
	[Address(RVA = "0x209DF70", Offset = "0x209E071", VA = "0x209DF70")]
	public bool CanPuton()
	{
		return default(bool);
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5A")]
	[Address(RVA = "0x209E060", Offset = "0x209E161", VA = "0x209E060")]
	public void Puton()
	{
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5B")]
	[Address(RVA = "0x209D2D0", Offset = "0x209D3D1", VA = "0x209D2D0")]
	public void RuckOut()
	{
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x6000C5C")]
	[Address(RVA = "0x209E4E0", Offset = "0x209E5E1", VA = "0x209E4E0")]
	public bool CanRuckIn()
	{
		return default(bool);
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5D")]
	[Address(RVA = "0x209E5B0", Offset = "0x209E6B1", VA = "0x209E5B0")]
	public void RuckIn()
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x6000C5E")]
	[Address(RVA = "0x209E1D0", Offset = "0x209E2D1", VA = "0x209E1D0")]
	public bool CanThrow()
	{
		return default(bool);
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C5F")]
	[Address(RVA = "0x209E2C0", Offset = "0x209E3C1", VA = "0x209E2C0")]
	public void Throw()
	{
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00006678 File Offset: 0x00004878
	[Token(Token = "0x6000C60")]
	[Address(RVA = "0x209E9D0", Offset = "0x209EAD1", VA = "0x209E9D0")]
	public bool CanEatOrDrink()
	{
		return default(bool);
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C61")]
	[Address(RVA = "0x209EAB0", Offset = "0x209EBB1", VA = "0x209EAB0")]
	public void EatOrDrink()
	{
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C62")]
	[Address(RVA = "0x20A8810", Offset = "0x20A8911", VA = "0x20A8810")]
	public void Drop()
	{
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C63")]
	[Address(RVA = "0x209CB20", Offset = "0x209CC21", VA = "0x209CB20")]
	public void UpdateHoldItem()
	{
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x00006690 File Offset: 0x00004890
	[Token(Token = "0x6000C64")]
	[Address(RVA = "0x20A8820", Offset = "0x20A8921", VA = "0x20A8820")]
	public bool CheckHoldItemAmount()
	{
		return default(bool);
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x000066A8 File Offset: 0x000048A8
	[Token(Token = "0x6000C65")]
	[Address(RVA = "0x20A8950", Offset = "0x20A8A51", VA = "0x20A8950")]
	public bool EnableOpenMenu()
	{
		return default(bool);
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C66")]
	[Address(RVA = "0x20A8980", Offset = "0x20A8A81", VA = "0x20A8980")]
	public void ItemDestroy()
	{
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C67")]
	[Address(RVA = "0x20A8AF0", Offset = "0x20A8BF1", VA = "0x20A8AF0")]
	public void Clear()
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C68")]
	[Address(RVA = "0x20A8BE0", Offset = "0x20A8CE1", VA = "0x20A8BE0")]
	public void FurnitureRotate(bool rotate)
	{
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x000066C0 File Offset: 0x000048C0
	[Token(Token = "0x6000C69")]
	[Address(RVA = "0x20A8CB0", Offset = "0x20A8DB1", VA = "0x20A8CB0")]
	private bool IsChangeStateEnable()
	{
		return default(bool);
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6A")]
	[Address(RVA = "0x20A8260", Offset = "0x20A8361", VA = "0x20A8260")]
	private void ChangeState(HumanItemHold.State state)
	{
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6B")]
	[Address(RVA = "0x20978F0", Offset = "0x20979F1", VA = "0x20978F0")]
	public void UpdateState()
	{
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x20A8E10", Offset = "0x20A8F11", VA = "0x20A8E10")]
	private void NoHold_Enter()
	{
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x20AA040", Offset = "0x20AA141", VA = "0x20AA040")]
	private void NoHold_Update()
	{
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x20AA6B0", Offset = "0x20AA7B1", VA = "0x20AA6B0")]
	private void NoHold_LateUpdate()
	{
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x20AA6C0", Offset = "0x20AA7C1", VA = "0x20AA6C0")]
	private void NoHold_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x20AA6D0", Offset = "0x20AA7D1", VA = "0x20AA6D0")]
	private void UpdateOnGroundItemOffset(OnGroundItem onGroundItem)
	{
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x20A8E40", Offset = "0x20A8F41", VA = "0x20A8E40")]
	private void RuckOut_Enter()
	{
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x20AA050", Offset = "0x20AA151", VA = "0x20AA050")]
	private void RuckOut_Update()
	{
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x20AAD00", Offset = "0x20AAE01", VA = "0x20AAD00")]
	private void RuckOut_LateUpdate()
	{
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x20AAD10", Offset = "0x20AAE11", VA = "0x20AAD10")]
	private void RuckOut_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x20A91A0", Offset = "0x20A92A1", VA = "0x20A91A0")]
	private void RuckIn_Enter()
	{
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x20AA1D0", Offset = "0x20AA2D1", VA = "0x20AA1D0")]
	private void RuckIn_Update()
	{
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x20AAE30", Offset = "0x20AAF31", VA = "0x20AAE30")]
	private void RuckIn_LateUpdate()
	{
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x20AAE40", Offset = "0x20AAF41", VA = "0x20AAE40")]
	private void RuckIn_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x20A94B0", Offset = "0x20A95B1", VA = "0x20A94B0")]
	private void Pickup_Enter()
	{
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x20AA350", Offset = "0x20AA451", VA = "0x20AA350")]
	private void Pickup_Update()
	{
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x20AB1B0", Offset = "0x20AB2B1", VA = "0x20AB1B0")]
	private void Pickup_LateUpdate()
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x20AB1C0", Offset = "0x20AB2C1", VA = "0x20AB1C0")]
	private void Pickup_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x000066D8 File Offset: 0x000048D8
	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x20AB470", Offset = "0x20AB571", VA = "0x20AB470")]
	private int GetFurnitureR()
	{
		return 0;
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x20A9640", Offset = "0x20A9741", VA = "0x20A9640")]
	private void Puton_Enter()
	{
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C7F")]
	[Address(RVA = "0x20AA360", Offset = "0x20AA461", VA = "0x20AA360")]
	private void Puton_Update()
	{
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x20AB7C0", Offset = "0x20AB8C1", VA = "0x20AB7C0")]
	private void Puton_LateUpdate()
	{
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C81")]
	[Address(RVA = "0x20AB7D0", Offset = "0x20AB8D1", VA = "0x20AB7D0")]
	private void Puton_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x20A97D0", Offset = "0x20A98D1", VA = "0x20A97D0")]
	private void Throw_Enter()
	{
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x20AA370", Offset = "0x20AA471", VA = "0x20AA370")]
	private void Throw_Update()
	{
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C84")]
	[Address(RVA = "0x20AC6A0", Offset = "0x20AC7A1", VA = "0x20AC6A0")]
	private void Throw_LateUpdate()
	{
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C85")]
	[Address(RVA = "0x20AC6B0", Offset = "0x20AC7B1", VA = "0x20AC6B0")]
	private void Throw_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C86")]
	[Address(RVA = "0x20A99E0", Offset = "0x20A9AE1", VA = "0x20A99E0")]
	private void EatDrink_Enter()
	{
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C87")]
	[Address(RVA = "0x20AA580", Offset = "0x20AA681", VA = "0x20AA580")]
	private void EatDrink_Update()
	{
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C88")]
	[Address(RVA = "0x20ACE10", Offset = "0x20ACF11", VA = "0x20ACE10")]
	private void EatDrink_LateUpdate()
	{
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C89")]
	[Address(RVA = "0x20AC9B0", Offset = "0x20ACAB1", VA = "0x20AC9B0")]
	private void EatDrink_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8A")]
	[Address(RVA = "0x20A9C50", Offset = "0x20A9D51", VA = "0x20A9C50")]
	private void Hold_Enter()
	{
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8B")]
	[Address(RVA = "0x20AA590", Offset = "0x20AA691", VA = "0x20AA590")]
	private void Hold_Update()
	{
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8C")]
	[Address(RVA = "0x20ACF50", Offset = "0x20AD051", VA = "0x20ACF50")]
	private void Hold_LateUpdate()
	{
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8D")]
	[Address(RVA = "0x20ACF60", Offset = "0x20AD061", VA = "0x20ACF60")]
	private void Hold_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8E")]
	[Address(RVA = "0x20A9F60", Offset = "0x20AA061", VA = "0x20A9F60")]
	private void Present_Enter()
	{
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C8F")]
	[Address(RVA = "0x20A9FD0", Offset = "0x20AA0D1", VA = "0x20A9FD0")]
	private void PutIn_Enter()
	{
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C90")]
	[Address(RVA = "0x20AA6A0", Offset = "0x20AA7A1", VA = "0x20AA6A0")]
	private void Interaction_Update()
	{
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C91")]
	[Address(RVA = "0x20ACF80", Offset = "0x20AD081", VA = "0x20ACF80")]
	private void Interaction_LateUpdate()
	{
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C92")]
	[Address(RVA = "0x20ACF90", Offset = "0x20AD091", VA = "0x20ACF90")]
	private void Interaction_AnimEvent(HumanItemHold.AnimEvent animEvent)
	{
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C93")]
	[Address(RVA = "0x2092F50", Offset = "0x2093051", VA = "0x2092F50")]
	public void OnAnimEvent(HumanItemHold.AnimEvent animEvent, HoldItemObserve observe)
	{
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C94")]
	[Address(RVA = "0x20AD160", Offset = "0x20AD261", VA = "0x20AD160")]
	private void Awake()
	{
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C95")]
	[Address(RVA = "0x2095D50", Offset = "0x2095E51", VA = "0x2095D50")]
	public void Init(HumanController humanController)
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x2097DD0", Offset = "0x2097ED1", VA = "0x2097DD0")]
	public void SetVisible(bool visible)
	{
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C97")]
	[Address(RVA = "0x20AD1C0", Offset = "0x20AD2C1", VA = "0x20AD1C0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x20AA8D0", Offset = "0x20AA9D1", VA = "0x20AA8D0")]
	private void UpdatePosition()
	{
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x000066F0 File Offset: 0x000048F0
	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x209A790", Offset = "0x209A891", VA = "0x209A790")]
	public bool OnTakeDamage(DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x20ACE20", Offset = "0x20ACF21", VA = "0x20ACE20")]
	public static void CheckWithCallTutorialADV(ItemData itemData)
	{
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x20AD250", Offset = "0x20AD351", VA = "0x20AD250")]
	private void HoldOnGroundItemEvent()
	{
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x20AD260", Offset = "0x20AD361", VA = "0x20AD260")]
	private void DoKeepItemEvent()
	{
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x20AD270", Offset = "0x20AD371", VA = "0x20AD270")]
	private void HoldInventoryItemEvent()
	{
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x20AD280", Offset = "0x20AD381", VA = "0x20AD280")]
	private void ThrowItemEvent()
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x20AD290", Offset = "0x20AD391", VA = "0x20AD290")]
	private void OnItemPutOnEvent()
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x20AD2A0", Offset = "0x20AD3A1", VA = "0x20AD2A0")]
	private void OnUseItem()
	{
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x20AD2B0", Offset = "0x20AD3B1", VA = "0x20AD2B0")]
	public HumanItemHold()
	{
	}

	// Token: 0x040007D5 RID: 2005
	[Token(Token = "0x400065E")]
	[FieldOffset(Offset = "0x18")]
	private HumanItemHold.State m_State;

	// Token: 0x040007D6 RID: 2006
	[Token(Token = "0x400065F")]
	[FieldOffset(Offset = "0x1C")]
	private HumanItemHold.State m_PrevState;

	// Token: 0x040007D7 RID: 2007
	[Token(Token = "0x4000660")]
	[FieldOffset(Offset = "0x20")]
	private HumanItemHold.State m_ReserveState;

	// Token: 0x040007D8 RID: 2008
	[Token(Token = "0x4000661")]
	private const float RUCKINOUT_TIME = 0.2f;

	// Token: 0x040007D9 RID: 2009
	[Token(Token = "0x4000662")]
	[FieldOffset(Offset = "0x28")]
	private HumanController m_Human;

	// Token: 0x040007DA RID: 2010
	[Token(Token = "0x4000663")]
	[FieldOffset(Offset = "0x30")]
	private HoldableInterface _HoldItem;

	// Token: 0x040007DB RID: 2011
	[Token(Token = "0x4000664")]
	[FieldOffset(Offset = "0x38")]
	private float m_Elapsed;

	// Token: 0x040007DC RID: 2012
	[Token(Token = "0x4000665")]
	[FieldOffset(Offset = "0x3C")]
	public bool IsUnscaledTime;

	// Token: 0x040007DD RID: 2013
	[Token(Token = "0x4000666")]
	[FieldOffset(Offset = "0x40")]
	private HoldableInterface m_PickupItem;

	// Token: 0x040007DE RID: 2014
	[Token(Token = "0x4000667")]
	[FieldOffset(Offset = "0x48")]
	private ItemInteractionInterface m_ItemInteractionTarget;

	// Token: 0x040007DF RID: 2015
	[Token(Token = "0x4000668")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private LayerMask m_PutOnLayer;

	// Token: 0x040007E0 RID: 2016
	[Token(Token = "0x4000669")]
	[FieldOffset(Offset = "0x54")]
	private Quaternion m_RotationOffset;

	// Token: 0x040007E1 RID: 2017
	[Token(Token = "0x400066A")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_PositionOffset;

	// Token: 0x040007E2 RID: 2018
	[Token(Token = "0x400066B")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DFE0", Offset = "0x15E0E1")]
	private int <FurnitureRotateY>k__BackingField;

	// Token: 0x040007E3 RID: 2019
	[Token(Token = "0x400066C")]
	[FieldOffset(Offset = "0x74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DFF0", Offset = "0x15E0F1")]
	private HoldMotionType <CurrentHoldMotionType>k__BackingField;

	// Token: 0x040007E4 RID: 2020
	[Token(Token = "0x400066D")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E000", Offset = "0x15E101")]
	private float <y_offset>k__BackingField;

	// Token: 0x040007E5 RID: 2021
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E010", Offset = "0x15E111")]
	private float <y_offset_yasai_head>k__BackingField;

	// Token: 0x040007E6 RID: 2022
	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0x80")]
	private HandCuffsController HandCuffsController;

	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000FF9")]
	private enum State
	{
		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x4018DEB")]
		None = -1,
		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x4018DEC")]
		NoHold,
		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x4018DED")]
		RuckOut,
		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x4018DEE")]
		RuckIn,
		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x4018DEF")]
		Pickup,
		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x4018DF0")]
		Puton,
		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x4018DF1")]
		Throw,
		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x4018DF2")]
		Hold,
		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x4018DF3")]
		Present,
		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x4018DF4")]
		PutIn,
		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x4018DF5")]
		EatDrink
	}

	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000FFA")]
	public enum AnimEvent
	{
		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x4018DF7")]
		None,
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x4018DF8")]
		EndNoHold,
		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x4018DF9")]
		EndRuckIn,
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x4018DFA")]
		EndRuckOut,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x4018DFB")]
		OnPutOn,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x4018DFC")]
		EndPutOn,
		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x4018DFD")]
		OnPickUp,
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x4018DFE")]
		EndPickUp,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x4018DFF")]
		OnThrow,
		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x4018E00")]
		EndThrow,
		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x4018E01")]
		OnEat,
		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x4018E02")]
		EndEat,
		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4018E03")]
		OnPresent,
		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4018E04")]
		EndPresent
	}
}

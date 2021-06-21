using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C0 RID: 704
[Token(Token = "0x2000226")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x145A00", Offset = "0x145B01")]
public class PreviewController : HumanController
{
	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000321")]
	public override Actor Actor
	{
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x280B590", Offset = "0x280B691", VA = "0x280B590", Slot = "15")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06001287 RID: 4743 RVA: 0x000087A8 File Offset: 0x000069A8
	[Token(Token = "0x17000322")]
	public override bool IsBattleMode
	{
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x280B5B0", Offset = "0x280B6B1", VA = "0x280B5B0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06001288 RID: 4744 RVA: 0x000087C0 File Offset: 0x000069C0
	[Token(Token = "0x17000323")]
	protected override bool FadeEnable
	{
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x280B5C0", Offset = "0x280B6C1", VA = "0x280B5C0", Slot = "73")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EA")]
	[Address(RVA = "0x280B5D0", Offset = "0x280B6D1", VA = "0x280B5D0", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EB")]
	[Address(RVA = "0x280B840", Offset = "0x280B941", VA = "0x280B840", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EC")]
	[Address(RVA = "0x280B880", Offset = "0x280B981", VA = "0x280B880", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010ED")]
	[Address(RVA = "0x280B9A0", Offset = "0x280BAA1", VA = "0x280B9A0", Slot = "76")]
	protected override void UpdateLookIK()
	{
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x000087D8 File Offset: 0x000069D8
	[Token(Token = "0x60010EE")]
	[Address(RVA = "0x280BAA0", Offset = "0x280BBA1", VA = "0x280BAA0", Slot = "48")]
	public override bool InputMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x280BAB0", Offset = "0x280BBB1", VA = "0x280BAB0", Slot = "84")]
	protected override void OnChangeEquip_ForNoticeStatus()
	{
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x280BAC0", Offset = "0x280BBC1", VA = "0x280BAC0", Slot = "61")]
	public override void SetGrounderIKWeight(float weight)
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x000087F0 File Offset: 0x000069F0
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x280BAD0", Offset = "0x280BBD1", VA = "0x280BAD0", Slot = "77")]
	protected override float UpdateArmIKWeight(float currentWeight, bool isArmIk)
	{
		return 0f;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x280BB80", Offset = "0x280BC81", VA = "0x280BB80")]
	public PreviewController()
	{
	}

	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x400082B")]
	[FieldOffset(Offset = "0x238")]
	private bool m_isBattleMode;
}

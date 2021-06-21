using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029D RID: 669
[Token(Token = "0x2000212")]
public class MobTravelerController : MobController
{
	// Token: 0x1700030F RID: 783
	// (get) Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002E5")]
	public virtual string Name
	{
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x1D7B460", Offset = "0x1D7B561", VA = "0x1D7B460", Slot = "124")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x1D7B630", Offset = "0x1D7B731", VA = "0x1D7B630", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x1D7B920", Offset = "0x1D7BA21", VA = "0x1D7B920", Slot = "19")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x1D7BA90", Offset = "0x1D7BB91", VA = "0x1D7BA90", Slot = "120")]
	protected override void OnEnable()
	{
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x1D7BB50", Offset = "0x1D7BC51", VA = "0x1D7BB50", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x1D7BCD0", Offset = "0x1D7BDD1", VA = "0x1D7BCD0")]
	public void SetFocusName(int id)
	{
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00007EF0 File Offset: 0x000060F0
	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x1D7BCE0", Offset = "0x1D7BDE1", VA = "0x1D7BCE0")]
	public int GetFocusNameID()
	{
		return 0;
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x1D7BCF0", Offset = "0x1D7BDF1", VA = "0x1D7BCF0", Slot = "110")]
	public override string GetFocusName()
	{
		return null;
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00007F08 File Offset: 0x00006108
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x1D7BD00", Offset = "0x1D7BE01", VA = "0x1D7BD00", Slot = "48")]
	public override bool InputMove(Vector3 vector)
	{
		return default(bool);
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x1D7BDC0", Offset = "0x1D7BEC1", VA = "0x1D7BDC0", Slot = "46")]
	protected override void SetLocomotion(float value)
	{
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB2")]
	[Address(RVA = "0x1D7BE70", Offset = "0x1D7BF71", VA = "0x1D7BE70")]
	public MobTravelerController()
	{
	}

	// Token: 0x040009B5 RID: 2485
	[Token(Token = "0x40007A5")]
	[FieldOffset(Offset = "0x274")]
	[SerializeField]
	protected int m_focusNameTextID;

	// Token: 0x040009B6 RID: 2486
	[Token(Token = "0x40007A6")]
	[FieldOffset(Offset = "0x278")]
	[SerializeField]
	protected float m_MoveSpeedRate;
}

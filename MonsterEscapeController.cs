using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

// Token: 0x0200029F RID: 671
[Token(Token = "0x2000214")]
public class MonsterEscapeController : CharaEscapeController<MonsterControllerBase>
{
	// Token: 0x06001143 RID: 4419 RVA: 0x00007F20 File Offset: 0x00006120
	[Token(Token = "0x6000FB4")]
	[Address(RVA = "0x1E603C0", Offset = "0x1E604C1", VA = "0x1E603C0", Slot = "5")]
	public override bool DoRise([Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB5")]
	[Address(RVA = "0x1E60480", Offset = "0x1E60581", VA = "0x1E60480", Slot = "13")]
	protected override void OnEndFall()
	{
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB6")]
	[Address(RVA = "0x1E60540", Offset = "0x1E60641", VA = "0x1E60540", Slot = "9")]
	public override void OnUpdate()
	{
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB7")]
	[Address(RVA = "0x1E605B0", Offset = "0x1E606B1", VA = "0x1E605B0")]
	protected void OnUpdateRise()
	{
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB8")]
	[Address(RVA = "0x1E606B0", Offset = "0x1E607B1", VA = "0x1E606B0")]
	public MonsterEscapeController()
	{
	}

	// Token: 0x040009B7 RID: 2487
	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected float m_elapsed;

	// Token: 0x040009B8 RID: 2488
	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected MonsterEscapeController.RiseState m_RiseState;

	// Token: 0x020002A0 RID: 672
	[Token(Token = "0x2001014")]
	protected enum RiseState
	{
		// Token: 0x040009BA RID: 2490
		[Token(Token = "0x4018E84")]
		Standby,
		// Token: 0x040009BB RID: 2491
		[Token(Token = "0x4018E85")]
		TakeOff
	}
}

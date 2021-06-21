using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002C1 RID: 705
[Token(Token = "0x2000227")]
public abstract class RestraintController : MonoBehaviour
{
	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06001292 RID: 4754 RVA: 0x00008808 File Offset: 0x00006A08
	// (set) Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000324")]
	public bool IsRestraint
	{
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x248CF10", Offset = "0x248D011", VA = "0x248CF10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C740", Offset = "0x19C841")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x248CF20", Offset = "0x248D021", VA = "0x248CF20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C750", Offset = "0x19C851")]
		protected set
		{
		}
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x248CF30", Offset = "0x248D031", VA = "0x248CF30", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x248CF40", Offset = "0x248D041", VA = "0x248CF40", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x248D020", Offset = "0x248D121", VA = "0x248D020", Slot = "6")]
	public virtual void Setup()
	{
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x248D030", Offset = "0x248D131", VA = "0x248D030", Slot = "7")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x248D040", Offset = "0x248D141", VA = "0x248D040", Slot = "8")]
	public virtual void OnRestraint()
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x248D200", Offset = "0x248D301", VA = "0x248D200", Slot = "9")]
	public virtual void OnRelease()
	{
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x248D2F0", Offset = "0x248D3F1", VA = "0x248D2F0")]
	protected RestraintController()
	{
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x248D300", Offset = "0x248D401", VA = "0x248D300")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C760", Offset = "0x19C861")]
	private void <OnRestraint>b__10_0(ParticleSystem effect)
	{
	}

	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x400082C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Transform m_effectPoint;

	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x400082D")]
	[FieldOffset(Offset = "0x20")]
	protected ParticleSystem m_effect;

	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x400082E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F170", Offset = "0x15F271")]
	private bool <IsRestraint>k__BackingField;
}

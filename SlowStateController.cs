using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CF RID: 719
[Token(Token = "0x2000230")]
public abstract class SlowStateController : MonoBehaviour
{
	// Token: 0x1700036B RID: 875
	// (get) Token: 0x06001328 RID: 4904 RVA: 0x00008A30 File Offset: 0x00006C30
	// (set) Token: 0x06001329 RID: 4905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000337")]
	public bool IsSlow
	{
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x2252110", Offset = "0x2252211", VA = "0x2252110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C9E0", Offset = "0x19CAE1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x2252120", Offset = "0x2252221", VA = "0x2252120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C9F0", Offset = "0x19CAF1")]
		protected set
		{
		}
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116D")]
	[Address(RVA = "0x2252130", Offset = "0x2252231", VA = "0x2252130", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116E")]
	[Address(RVA = "0x2252140", Offset = "0x2252241", VA = "0x2252140", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600116F")]
	[Address(RVA = "0x2252210", Offset = "0x2252311", VA = "0x2252210", Slot = "6")]
	public virtual void Setup()
	{
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001170")]
	[Address(RVA = "0x2252220", Offset = "0x2252321", VA = "0x2252220", Slot = "7")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001171")]
	[Address(RVA = "0x2252230", Offset = "0x2252331", VA = "0x2252230", Slot = "8")]
	public virtual void DoSlow()
	{
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001172")]
	[Address(RVA = "0x2252340", Offset = "0x2252441", VA = "0x2252340", Slot = "9")]
	public virtual void OnRelease()
	{
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001173")]
	[Address(RVA = "0x2252430", Offset = "0x2252531", VA = "0x2252430")]
	protected SlowStateController()
	{
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x2252440", Offset = "0x2252541", VA = "0x2252440")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CA00", Offset = "0x19CB01")]
	private void <DoSlow>b__10_0(ParticleSystem effect)
	{
	}

	// Token: 0x04000AD3 RID: 2771
	[Token(Token = "0x4000873")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Transform m_effectPoint;

	// Token: 0x04000AD4 RID: 2772
	[Token(Token = "0x4000874")]
	[FieldOffset(Offset = "0x20")]
	protected ParticleSystem m_effect;

	// Token: 0x04000AD5 RID: 2773
	[Token(Token = "0x4000875")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F390", Offset = "0x15F491")]
	private bool <IsSlow>k__BackingField;
}

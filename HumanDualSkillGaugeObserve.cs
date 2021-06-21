using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000234 RID: 564
[Token(Token = "0x20001C5")]
public class HumanDualSkillGaugeObserve : MonoBehaviour
{
	// Token: 0x17000292 RID: 658
	// (get) Token: 0x06000D59 RID: 3417 RVA: 0x00006468 File Offset: 0x00004668
	// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000272")]
	public bool IsReady
	{
		[Token(Token = "0x6000BFA")]
		[Address(RVA = "0x20A2380", Offset = "0x20A2481", VA = "0x20A2380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BCF0", Offset = "0x19BDF1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000BFB")]
		[Address(RVA = "0x20A2390", Offset = "0x20A2491", VA = "0x20A2390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD00", Offset = "0x19BE01")]
		protected set
		{
		}
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFC")]
	[Address(RVA = "0x20A23A0", Offset = "0x20A24A1", VA = "0x20A23A0")]
	private void Start()
	{
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFD")]
	[Address(RVA = "0x20A24B0", Offset = "0x20A25B1", VA = "0x20A24B0")]
	public void Ovserve()
	{
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFE")]
	[Address(RVA = "0x20A25F0", Offset = "0x20A26F1", VA = "0x20A25F0")]
	public HumanDualSkillGaugeObserve()
	{
	}

	// Token: 0x040007C0 RID: 1984
	[Token(Token = "0x400064B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HumanController m_human;

	// Token: 0x040007C1 RID: 1985
	[Token(Token = "0x400064C")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DF10", Offset = "0x15E011")]
	private bool <IsReady>k__BackingField;
}

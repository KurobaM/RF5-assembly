using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000239 RID: 569
[Token(Token = "0x20001C9")]
public class HumanEscapeController : CharaEscapeController<HumanController>
{
	// Token: 0x06000D89 RID: 3465 RVA: 0x00006510 File Offset: 0x00004710
	[Token(Token = "0x6000C28")]
	[Address(RVA = "0x20A4740", Offset = "0x20A4841", VA = "0x20A4740", Slot = "5")]
	public override bool DoRise([Optional] Action callback)
	{
		return default(bool);
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C29")]
	[Address(RVA = "0x20A48B0", Offset = "0x20A49B1", VA = "0x20A48B0", Slot = "13")]
	protected override void OnEndFall()
	{
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C2A")]
	[Address(RVA = "0x20A49C0", Offset = "0x20A4AC1", VA = "0x20A49C0")]
	public HumanEscapeController()
	{
	}

	// Token: 0x040007CF RID: 1999
	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private HumanJointIDEnum m_AuraAttachJoint;
}

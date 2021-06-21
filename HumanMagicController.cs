using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000245 RID: 581
[Token(Token = "0x20001D3")]
public class HumanMagicController : CharaMagicController<HumanController>
{
	// Token: 0x06000E13 RID: 3603 RVA: 0x00006738 File Offset: 0x00004938
	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x22228C0", Offset = "0x22229C1", VA = "0x22228C0", Slot = "6")]
	public override bool DoPlay(MagicID magicId, int level, AttackAttribute attribute, Vector3 offset)
	{
		return default(bool);
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x2222AC0", Offset = "0x2222BC1", VA = "0x2222AC0")]
	public HumanMagicController()
	{
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008BA RID: 2234
[Token(Token = "0x20005C9")]
public class ChangeAvatorBehavior : PlayableBehaviour
{
	// Token: 0x06003B34 RID: 15156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003199")]
	[Address(RVA = "0x1E81FA0", Offset = "0x1E820A1", VA = "0x1E81FA0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B35 RID: 15157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600319A")]
	[Address(RVA = "0x1E82040", Offset = "0x1E82141", VA = "0x1E82040")]
	public ChangeAvatorBehavior()
	{
	}

	// Token: 0x04007E17 RID: 32279
	[Token(Token = "0x40071D3")]
	[FieldOffset(Offset = "0x10")]
	public Animator TargetAnimator;

	// Token: 0x04007E18 RID: 32280
	[Token(Token = "0x40071D4")]
	[FieldOffset(Offset = "0x18")]
	public Avatar Avatar;
}

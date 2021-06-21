using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A71 RID: 2673
[Token(Token = "0x2000704")]
public class UILoaderFade : MonoBehaviour
{
	// Token: 0x060045C9 RID: 17865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A6C")]
	[Address(RVA = "0x201ED30", Offset = "0x201EE31", VA = "0x201ED30")]
	private void Awake()
	{
	}

	// Token: 0x060045CA RID: 17866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A6D")]
	[Address(RVA = "0x201D6B0", Offset = "0x201D7B1", VA = "0x201D6B0")]
	public void Init()
	{
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A6E")]
	[Address(RVA = "0x201EDC0", Offset = "0x201EEC1", VA = "0x201EDC0")]
	private void CalcFadeTime()
	{
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A6F")]
	[Address(RVA = "0x201EE70", Offset = "0x201EF71", VA = "0x201EE70")]
	private void Update()
	{
	}

	// Token: 0x060045CD RID: 17869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A70")]
	[Address(RVA = "0x201F180", Offset = "0x201F281", VA = "0x201F180")]
	public UILoaderFade()
	{
	}

	// Token: 0x0400A4B6 RID: 42166
	[Token(Token = "0x4007C7F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UILoaderFade.State state;

	// Token: 0x0400A4B7 RID: 42167
	[Token(Token = "0x4007C80")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UILoader UILoader;

	// Token: 0x0400A4B8 RID: 42168
	[Token(Token = "0x4007C81")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float[] fadeTime;

	// Token: 0x0400A4B9 RID: 42169
	[Token(Token = "0x4007C82")]
	[FieldOffset(Offset = "0x30")]
	private float nowFadeTime;

	// Token: 0x0400A4BA RID: 42170
	[Token(Token = "0x4007C83")]
	[FieldOffset(Offset = "0x34")]
	private float nextFadeTime;

	// Token: 0x0400A4BB RID: 42171
	[Token(Token = "0x4007C84")]
	[FieldOffset(Offset = "0x38")]
	private int fadePhase;

	// Token: 0x0400A4BC RID: 42172
	[Token(Token = "0x4007C85")]
	[FieldOffset(Offset = "0x3C")]
	private bool initPhase;

	// Token: 0x0400A4BD RID: 42173
	[Token(Token = "0x4007C86")]
	[FieldOffset(Offset = "0x40")]
	private Image Image;

	// Token: 0x0400A4BE RID: 42174
	[Token(Token = "0x4007C87")]
	[FieldOffset(Offset = "0x48")]
	private Color Color;

	// Token: 0x02000A72 RID: 2674
	[Token(Token = "0x20012EF")]
	private enum State
	{
		// Token: 0x0400A4C0 RID: 42176
		[Token(Token = "0x401B49B")]
		OpenObject,
		// Token: 0x0400A4C1 RID: 42177
		[Token(Token = "0x401B49C")]
		EndObject
	}
}

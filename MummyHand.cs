using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200074A RID: 1866
[Token(Token = "0x2000509")]
public class MummyHand : MonoBehaviour
{
	// Token: 0x06002FC5 RID: 12229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600283A")]
	[Address(RVA = "0x1E1A310", Offset = "0x1E1A411", VA = "0x1E1A310")]
	public void Setup(MummyController mummyController, SkinnedMeshRenderer skinnedMeshRenderer, Transform defaultTrans, Transform setHandTrans, Transform endTransform)
	{
	}

	// Token: 0x06002FC6 RID: 12230 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600283B")]
	[Address(RVA = "0x1E1C460", Offset = "0x1E1C561", VA = "0x1E1C460")]
	public void SetDefault(float moveDuration, float scaleDuration)
	{
	}

	// Token: 0x06002FC7 RID: 12231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600283C")]
	[Address(RVA = "0x1E1D3C0", Offset = "0x1E1D4C1", VA = "0x1E1D3C0")]
	public void SetTargetPos(Vector3 pos)
	{
	}

	// Token: 0x06002FC8 RID: 12232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600283D")]
	[Address(RVA = "0x1E1C6B0", Offset = "0x1E1C7B1", VA = "0x1E1C6B0")]
	public void SeekEnd()
	{
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600283E")]
	[Address(RVA = "0x1E1C6C0", Offset = "0x1E1C7C1", VA = "0x1E1C6C0")]
	public void Press(float pressDuration)
	{
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600283F")]
	[Address(RVA = "0x1E1C900", Offset = "0x1E1CA01", VA = "0x1E1C900")]
	public void PressEnd()
	{
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002840")]
	[Address(RVA = "0x1E1C990", Offset = "0x1E1CA91", VA = "0x1E1C990")]
	public void BackBody(float duration, Action callback)
	{
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002841")]
	[Address(RVA = "0x1E1D3E0", Offset = "0x1E1D4E1", VA = "0x1E1D3E0")]
	private void Update()
	{
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002842")]
	[Address(RVA = "0x1E1D670", Offset = "0x1E1D771", VA = "0x1E1D670")]
	public MummyHand()
	{
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002843")]
	[Address(RVA = "0x1E1D720", Offset = "0x1E1D821", VA = "0x1E1D720")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3F90", Offset = "0x1A4091")]
	private void <SetDefault>b__11_0()
	{
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002844")]
	[Address(RVA = "0x1E1D730", Offset = "0x1E1D831", VA = "0x1E1D730")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A3FA0", Offset = "0x1A40A1")]
	private void <Press>b__14_0()
	{
	}

	// Token: 0x04007558 RID: 30040
	[Token(Token = "0x4006BBB")]
	[FieldOffset(Offset = "0x18")]
	private Animator Animator;

	// Token: 0x04007559 RID: 30041
	[Token(Token = "0x4006BBC")]
	[FieldOffset(Offset = "0x20")]
	private MummyController MummyController;

	// Token: 0x0400755A RID: 30042
	[Token(Token = "0x4006BBD")]
	[FieldOffset(Offset = "0x28")]
	private Transform DefaultTransform;

	// Token: 0x0400755B RID: 30043
	[Token(Token = "0x4006BBE")]
	[FieldOffset(Offset = "0x30")]
	private Transform SetHandTransform;

	// Token: 0x0400755C RID: 30044
	[Token(Token = "0x4006BBF")]
	[FieldOffset(Offset = "0x38")]
	private Transform EndTransform;

	// Token: 0x0400755D RID: 30045
	[Token(Token = "0x4006BC0")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 TargetPos;

	// Token: 0x0400755E RID: 30046
	[Token(Token = "0x4006BC1")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 OffsetPos;

	// Token: 0x0400755F RID: 30047
	[Token(Token = "0x4006BC2")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 DefaultScale;

	// Token: 0x04007560 RID: 30048
	[Token(Token = "0x4006BC3")]
	[FieldOffset(Offset = "0x64")]
	private bool IsSetup;

	// Token: 0x04007561 RID: 30049
	[Token(Token = "0x4006BC4")]
	[FieldOffset(Offset = "0x65")]
	private bool IsSeek;

	// Token: 0x0200074B RID: 1867
	[Token(Token = "0x20011C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158600", Offset = "0x158701")]
	private sealed class <>c__DisplayClass16_0
	{
		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007276")]
		[Address(RVA = "0x1E1D3D0", Offset = "0x1E1D4D1", VA = "0x1E1D3D0")]
		public <>c__DisplayClass16_0()
		{
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007277")]
		[Address(RVA = "0x1E1D840", Offset = "0x1E1D941", VA = "0x1E1D840")]
		internal void <BackBody>b__0()
		{
		}

		// Token: 0x04007562 RID: 30050
		[Token(Token = "0x4019606")]
		[FieldOffset(Offset = "0x10")]
		public Action callback;

		// Token: 0x04007563 RID: 30051
		[Token(Token = "0x4019607")]
		[FieldOffset(Offset = "0x18")]
		public MummyHand <>4__this;
	}
}

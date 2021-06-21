using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

// Token: 0x02000111 RID: 273
[Token(Token = "0x20000D6")]
public class PlayableMixer : MonoBehaviour
{
	// Token: 0x1700015B RID: 347
	// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00004200 File Offset: 0x00002400
	// (set) Token: 0x060005E6 RID: 1510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000155")]
	public bool IsAutoStop
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x21435A0", Offset = "0x21436A1", VA = "0x21435A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A520", Offset = "0x19A621")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x21435B0", Offset = "0x21436B1", VA = "0x21435B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A530", Offset = "0x19A631")]
		set
		{
		}
	}

	// Token: 0x060005E7 RID: 1511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000503")]
	[Address(RVA = "0x21435C0", Offset = "0x21436C1", VA = "0x21435C0")]
	private void Awake()
	{
	}

	// Token: 0x060005E8 RID: 1512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000504")]
	[Address(RVA = "0x21436F0", Offset = "0x21437F1", VA = "0x21436F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060005E9 RID: 1513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000505")]
	[Address(RVA = "0x2143700", Offset = "0x2143801", VA = "0x2143700")]
	private void Update()
	{
	}

	// Token: 0x060005EA RID: 1514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000506")]
	[Address(RVA = "0x2143D80", Offset = "0x2143E81", VA = "0x2143D80")]
	public void Play(AnimationClip clip, float fadeTime, float time = 0f, float speed = 1f)
	{
	}

	// Token: 0x060005EB RID: 1515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000507")]
	[Address(RVA = "0x2143BF0", Offset = "0x2143CF1", VA = "0x2143BF0")]
	public void Stop(double fadeTime)
	{
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00004218 File Offset: 0x00002418
	[Token(Token = "0x6000508")]
	[Address(RVA = "0x2143D60", Offset = "0x2143E61", VA = "0x2143D60")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00004230 File Offset: 0x00002430
	[Token(Token = "0x6000509")]
	[Address(RVA = "0x2144130", Offset = "0x2144231", VA = "0x2144130")]
	public double GetTime()
	{
		return 0.0;
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00004248 File Offset: 0x00002448
	[Token(Token = "0x600050A")]
	[Address(RVA = "0x21441B0", Offset = "0x21442B1", VA = "0x21441B0")]
	public double GetDuration()
	{
		return 0.0;
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00004260 File Offset: 0x00002460
	[Token(Token = "0x600050B")]
	[Address(RVA = "0x2143A50", Offset = "0x2143B51", VA = "0x2143A50")]
	public bool IsFinishedPlay()
	{
		return default(bool);
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050C")]
	[Address(RVA = "0x2143C50", Offset = "0x2143D51", VA = "0x2143C50")]
	private void Cleanup()
	{
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050D")]
	[Address(RVA = "0x2144200", Offset = "0x2144301", VA = "0x2144200")]
	public void SetWeight(float weight)
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600050E")]
	[Address(RVA = "0x2144210", Offset = "0x2144311", VA = "0x2144210")]
	public PlayableMixer()
	{
	}

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x18")]
	private PlayableGraph m_Graph;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x28")]
	private AnimationMixerPlayable m_Mixer;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x38")]
	private AnimationPlayableOutput m_Output;

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x48")]
	private Playable[] m_Playable;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsTransition;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x54")]
	private float m_FadeTime;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x58")]
	private PlayableMixer.STATE m_State;

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x60")]
	private double m_Elapsed;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x68")]
	private double m_OutputFadeTime;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x70")]
	private float m_OutputWeightTarget;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x74")]
	private float m_OutputWeightCurrent;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x78")]
	private float m_WeightRate;

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x7C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BDC0", Offset = "0x15BEC1")]
	private bool <IsAutoStop>k__BackingField;

	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000FC5")]
	private enum STATE
	{
		// Token: 0x0400033A RID: 826
		[Token(Token = "0x4018D2B")]
		STOP,
		// Token: 0x0400033B RID: 827
		[Token(Token = "0x4018D2C")]
		FADEIN,
		// Token: 0x0400033C RID: 828
		[Token(Token = "0x4018D2D")]
		PLAYING,
		// Token: 0x0400033D RID: 829
		[Token(Token = "0x4018D2E")]
		FADEOUT
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000B00 RID: 2816
[Token(Token = "0x2000755")]
public class VoicePlayingWindow : MonoBehaviour
{
	// Token: 0x060048F0 RID: 18672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CFA")]
	[Address(RVA = "0x1E49C60", Offset = "0x1E49D61", VA = "0x1E49C60")]
	public void OpenWindow(int _index, Sprite _sprite, UnityAction _call_back, AudioClip _clip)
	{
	}

	// Token: 0x060048F1 RID: 18673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CFB")]
	[Address(RVA = "0x1E4AA30", Offset = "0x1E4AB31", VA = "0x1E4AA30")]
	private void Update()
	{
	}

	// Token: 0x060048F2 RID: 18674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CFC")]
	[Address(RVA = "0x1E4AD60", Offset = "0x1E4AE61", VA = "0x1E4AD60")]
	private void OnSpeakerAnim()
	{
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CFD")]
	[Address(RVA = "0x1E4A9B0", Offset = "0x1E4AAB1", VA = "0x1E4A9B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8700", Offset = "0x1A8801")]
	private IEnumerator OnStartAnim()
	{
		return null;
	}

	// Token: 0x060048F4 RID: 18676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CFE")]
	[Address(RVA = "0x1E4ACE0", Offset = "0x1E4ADE1", VA = "0x1E4ACE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8770", Offset = "0x1A8871")]
	private IEnumerator OnEndAnim()
	{
		return null;
	}

	// Token: 0x060048F5 RID: 18677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CFF")]
	[Address(RVA = "0x1E4AF20", Offset = "0x1E4B021", VA = "0x1E4AF20")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A87E0", Offset = "0x1A88E1")]
	private IEnumerator PlayFadeAnim(bool _flag, CanvasGroup _target)
	{
		return null;
	}

	// Token: 0x060048F6 RID: 18678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D00")]
	[Address(RVA = "0x1E4AFE0", Offset = "0x1E4B0E1", VA = "0x1E4AFE0")]
	private void InvokeCallBack()
	{
	}

	// Token: 0x060048F7 RID: 18679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D01")]
	[Address(RVA = "0x1E4B030", Offset = "0x1E4B131", VA = "0x1E4B030")]
	public VoicePlayingWindow()
	{
	}

	// Token: 0x0400A8CF RID: 43215
	[Token(Token = "0x4007F35")]
	[FieldOffset(Offset = "0x18")]
	private AudioSource audioSource;

	// Token: 0x0400A8D0 RID: 43216
	[Token(Token = "0x4007F36")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CanvasGroup semiTransparent;

	// Token: 0x0400A8D1 RID: 43217
	[Token(Token = "0x4007F37")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CanvasGroup charaIconGroup;

	// Token: 0x0400A8D2 RID: 43218
	[Token(Token = "0x4007F38")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private CanvasGroup speakerAndText;

	// Token: 0x0400A8D3 RID: 43219
	[Token(Token = "0x4007F39")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image charaIcon;

	// Token: 0x0400A8D4 RID: 43220
	[Token(Token = "0x4007F3A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Text charaText;

	// Token: 0x0400A8D5 RID: 43221
	[Token(Token = "0x4007F3B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Text cvText;

	// Token: 0x0400A8D6 RID: 43222
	[Token(Token = "0x4007F3C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image speakerBorder;

	// Token: 0x0400A8D7 RID: 43223
	[Token(Token = "0x4007F3D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image speaker;

	// Token: 0x0400A8D8 RID: 43224
	[Token(Token = "0x4007F3E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<Sprite> speakerSprite;

	// Token: 0x0400A8D9 RID: 43225
	[Token(Token = "0x4007F3F")]
	[FieldOffset(Offset = "0x68")]
	private UnityAction action;

	// Token: 0x0400A8DA RID: 43226
	[Token(Token = "0x4007F40")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform rectTransform;

	// Token: 0x0400A8DB RID: 43227
	[Token(Token = "0x4007F41")]
	[FieldOffset(Offset = "0x78")]
	private bool isPlaying;

	// Token: 0x0400A8DC RID: 43228
	[Token(Token = "0x4007F42")]
	[FieldOffset(Offset = "0x79")]
	private bool isAnimation;

	// Token: 0x0400A8DD RID: 43229
	[Token(Token = "0x4007F43")]
	private const float ROTATE_SPEED = -7f;

	// Token: 0x0400A8DE RID: 43230
	[Token(Token = "0x4007F44")]
	private const float SPEAKER_ANIM_SPEED = 0.8f;

	// Token: 0x0400A8DF RID: 43231
	[Token(Token = "0x4007F45")]
	[FieldOffset(Offset = "0x7C")]
	private int animDir;

	// Token: 0x0400A8E0 RID: 43232
	[Token(Token = "0x4007F46")]
	[FieldOffset(Offset = "0x80")]
	private int spriteNo;

	// Token: 0x0400A8E1 RID: 43233
	[Token(Token = "0x4007F47")]
	[FieldOffset(Offset = "0x84")]
	private float timeCount;

	// Token: 0x02000B01 RID: 2817
	[Token(Token = "0x200132D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159380", Offset = "0x159481")]
	private sealed class <OnStartAnim>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048F8 RID: 18680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DA")]
		[Address(RVA = "0x1E4AEC0", Offset = "0x1E4AFC1", VA = "0x1E4AEC0")]
		[DebuggerHidden]
		public <OnStartAnim>d__22(int <>1__state)
		{
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DB")]
		[Address(RVA = "0x1E4B490", Offset = "0x1E4B591", VA = "0x1E4B490", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x00017A18 File Offset: 0x00015C18
		[Token(Token = "0x60076DC")]
		[Address(RVA = "0x1E4B4A0", Offset = "0x1E4B5A1", VA = "0x1E4B4A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x060048FB RID: 18683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB3")]
		private object Current
		{
			[Token(Token = "0x60076DD")]
			[Address(RVA = "0x1E4B7F0", Offset = "0x1E4B8F1", VA = "0x1E4B7F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076DE")]
		[Address(RVA = "0x1E4B800", Offset = "0x1E4B901", VA = "0x1E4B800", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x060048FD RID: 18685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB4")]
		private object Current
		{
			[Token(Token = "0x60076DF")]
			[Address(RVA = "0x1E4B860", Offset = "0x1E4B961", VA = "0x1E4B860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8E2 RID: 43234
		[Token(Token = "0x401B5FD")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8E3 RID: 43235
		[Token(Token = "0x401B5FE")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8E4 RID: 43236
		[Token(Token = "0x401B5FF")]
		[FieldOffset(Offset = "0x20")]
		public VoicePlayingWindow <>4__this;

		// Token: 0x0400A8E5 RID: 43237
		[Token(Token = "0x401B600")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <scale>5__2;

		// Token: 0x0400A8E6 RID: 43238
		[Token(Token = "0x401B601")]
		[FieldOffset(Offset = "0x34")]
		private float <timeCount>5__3;

		// Token: 0x0400A8E7 RID: 43239
		[Token(Token = "0x401B602")]
		[FieldOffset(Offset = "0x38")]
		private float <scaleAnimSpeed>5__4;
	}

	// Token: 0x02000B02 RID: 2818
	[Token(Token = "0x200132E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159390", Offset = "0x159491")]
	private sealed class <OnEndAnim>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048FE RID: 18686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E0")]
		[Address(RVA = "0x1E4AEF0", Offset = "0x1E4AFF1", VA = "0x1E4AEF0")]
		[DebuggerHidden]
		public <OnEndAnim>d__23(int <>1__state)
		{
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E1")]
		[Address(RVA = "0x1E4B0C0", Offset = "0x1E4B1C1", VA = "0x1E4B0C0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x00017A30 File Offset: 0x00015C30
		[Token(Token = "0x60076E2")]
		[Address(RVA = "0x1E4B0D0", Offset = "0x1E4B1D1", VA = "0x1E4B0D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06004901 RID: 18689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB5")]
		private object Current
		{
			[Token(Token = "0x60076E3")]
			[Address(RVA = "0x1E4B410", Offset = "0x1E4B511", VA = "0x1E4B410", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E4")]
		[Address(RVA = "0x1E4B420", Offset = "0x1E4B521", VA = "0x1E4B420", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06004903 RID: 18691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB6")]
		private object Current
		{
			[Token(Token = "0x60076E5")]
			[Address(RVA = "0x1E4B480", Offset = "0x1E4B581", VA = "0x1E4B480", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8E8 RID: 43240
		[Token(Token = "0x401B603")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8E9 RID: 43241
		[Token(Token = "0x401B604")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8EA RID: 43242
		[Token(Token = "0x401B605")]
		[FieldOffset(Offset = "0x20")]
		public VoicePlayingWindow <>4__this;

		// Token: 0x0400A8EB RID: 43243
		[Token(Token = "0x401B606")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 <scale>5__2;

		// Token: 0x0400A8EC RID: 43244
		[Token(Token = "0x401B607")]
		[FieldOffset(Offset = "0x34")]
		private float <timeCount>5__3;

		// Token: 0x0400A8ED RID: 43245
		[Token(Token = "0x401B608")]
		[FieldOffset(Offset = "0x38")]
		private float <scaleAnimSpeed>5__4;
	}

	// Token: 0x02000B03 RID: 2819
	[Token(Token = "0x200132F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1593A0", Offset = "0x1594A1")]
	private sealed class <PlayFadeAnim>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004904 RID: 18692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E6")]
		[Address(RVA = "0x1E4AFB0", Offset = "0x1E4B0B1", VA = "0x1E4AFB0")]
		[DebuggerHidden]
		public <PlayFadeAnim>d__24(int <>1__state)
		{
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E7")]
		[Address(RVA = "0x1E4B870", Offset = "0x1E4B971", VA = "0x1E4B870", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00017A48 File Offset: 0x00015C48
		[Token(Token = "0x60076E8")]
		[Address(RVA = "0x1E4B880", Offset = "0x1E4B981", VA = "0x1E4B880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06004907 RID: 18695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB7")]
		private object Current
		{
			[Token(Token = "0x60076E9")]
			[Address(RVA = "0x1E4BA00", Offset = "0x1E4BB01", VA = "0x1E4BA00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076EA")]
		[Address(RVA = "0x1E4BA10", Offset = "0x1E4BB11", VA = "0x1E4BA10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB8")]
		private object Current
		{
			[Token(Token = "0x60076EB")]
			[Address(RVA = "0x1E4BA70", Offset = "0x1E4BB71", VA = "0x1E4BA70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8EE RID: 43246
		[Token(Token = "0x401B609")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8EF RID: 43247
		[Token(Token = "0x401B60A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8F0 RID: 43248
		[Token(Token = "0x401B60B")]
		[FieldOffset(Offset = "0x20")]
		public bool _flag;

		// Token: 0x0400A8F1 RID: 43249
		[Token(Token = "0x401B60C")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup _target;

		// Token: 0x0400A8F2 RID: 43250
		[Token(Token = "0x401B60D")]
		[FieldOffset(Offset = "0x30")]
		private float <timeCount>5__2;

		// Token: 0x0400A8F3 RID: 43251
		[Token(Token = "0x401B60E")]
		[FieldOffset(Offset = "0x34")]
		private float <speed>5__3;

		// Token: 0x0400A8F4 RID: 43252
		[Token(Token = "0x401B60F")]
		[FieldOffset(Offset = "0x38")]
		private int <rate>5__4;
	}
}

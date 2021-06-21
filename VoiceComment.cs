using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Loader;
using RF5UI.BUTTONHINT;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000AF4 RID: 2804
[Token(Token = "0x2000752")]
public class VoiceComment : UIScrollBoxBase
{
	// Token: 0x060048B2 RID: 18610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CDD")]
	[Address(RVA = "0x1E47EB0", Offset = "0x1E47FB1", VA = "0x1E47EB0")]
	public void OpenWindow(UnityAction _call_back)
	{
	}

	// Token: 0x060048B3 RID: 18611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CDE")]
	[Address(RVA = "0x1E47FE0", Offset = "0x1E480E1", VA = "0x1E47FE0")]
	private void OnEnable()
	{
	}

	// Token: 0x060048B4 RID: 18612 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CDF")]
	[Address(RVA = "0x1E48290", Offset = "0x1E48391", VA = "0x1E48290")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8510", Offset = "0x1A8611")]
	private IEnumerator SetupButtonHint()
	{
		return null;
	}

	// Token: 0x060048B5 RID: 18613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE0")]
	[Address(RVA = "0x1E48340", Offset = "0x1E48441", VA = "0x1E48340", Slot = "8")]
	protected override void Start()
	{
	}

	// Token: 0x060048B6 RID: 18614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE1")]
	[Address(RVA = "0x1E48540", Offset = "0x1E48641", VA = "0x1E48540", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x060048B7 RID: 18615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE2")]
	[Address(RVA = "0x1E48780", Offset = "0x1E48881", VA = "0x1E48780", Slot = "10")]
	protected override void OnDisable()
	{
	}

	// Token: 0x060048B8 RID: 18616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE3")]
	[Address(RVA = "0x1E48790", Offset = "0x1E48891", VA = "0x1E48790")]
	private void OnDestroy()
	{
	}

	// Token: 0x060048B9 RID: 18617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE4")]
	[Address(RVA = "0x1E48640", Offset = "0x1E48741", VA = "0x1E48640")]
	private void InputSubmit()
	{
	}

	// Token: 0x060048BA RID: 18618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CE5")]
	[Address(RVA = "0x1E489B0", Offset = "0x1E48AB1", VA = "0x1E489B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8580", Offset = "0x1A8681")]
	private IEnumerator PlayVoice()
	{
		return null;
	}

	// Token: 0x060048BB RID: 18619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE6")]
	[Address(RVA = "0x1E48A60", Offset = "0x1E48B61", VA = "0x1E48A60")]
	private void UpdateSDCharaSprite()
	{
	}

	// Token: 0x060048BC RID: 18620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CE7")]
	[Address(RVA = "0x1E48DE0", Offset = "0x1E48EE1", VA = "0x1E48DE0")]
	private Sprite GetSDCharaSprite(VoiceComment.IconType _type)
	{
		return null;
	}

	// Token: 0x060048BD RID: 18621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CE8")]
	[Address(RVA = "0x1E48EB0", Offset = "0x1E48FB1", VA = "0x1E48EB0")]
	public void OnSlotTouch(CastSlot _slot)
	{
	}

	// Token: 0x060048BE RID: 18622 RVA: 0x00017958 File Offset: 0x00015B58
	[Token(Token = "0x6003CE9")]
	[Address(RVA = "0x1E48900", Offset = "0x1E48A01", VA = "0x1E48900")]
	public bool IsReleased(int _index)
	{
		return default(bool);
	}

	// Token: 0x060048BF RID: 18623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CEA")]
	[Address(RVA = "0x1E48210", Offset = "0x1E48311", VA = "0x1E48210")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A85F0", Offset = "0x1A86F1")]
	private IEnumerator StartFading()
	{
		return null;
	}

	// Token: 0x060048C0 RID: 18624 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003CEB")]
	[Address(RVA = "0x1E48FB0", Offset = "0x1E490B1", VA = "0x1E48FB0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8660", Offset = "0x1A8761")]
	private IEnumerator CharaSpriteFading(int _index)
	{
		return null;
	}

	// Token: 0x060048C1 RID: 18625 RVA: 0x00017970 File Offset: 0x00015B70
	[Token(Token = "0x6003CEC")]
	[Address(RVA = "0x1E49070", Offset = "0x1E49171", VA = "0x1E49070", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x060048C2 RID: 18626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CED")]
	[Address(RVA = "0x1E49080", Offset = "0x1E49181", VA = "0x1E49080", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x060048C3 RID: 18627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CEE")]
	[Address(RVA = "0x1E49120", Offset = "0x1E49221", VA = "0x1E49120", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x060048C4 RID: 18628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CEF")]
	[Address(RVA = "0x1E49130", Offset = "0x1E49231", VA = "0x1E49130")]
	private void InvokeCallBack()
	{
	}

	// Token: 0x060048C5 RID: 18629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CF0")]
	[Address(RVA = "0x1E47EF0", Offset = "0x1E47FF1", VA = "0x1E47EF0")]
	private void FadeOut(bool _flag)
	{
	}

	// Token: 0x060048C6 RID: 18630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CF1")]
	[Address(RVA = "0x1E49190", Offset = "0x1E49291", VA = "0x1E49190")]
	private void FadeIn(bool _flag)
	{
	}

	// Token: 0x060048C7 RID: 18631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003CF2")]
	[Address(RVA = "0x1E49290", Offset = "0x1E49391", VA = "0x1E49290")]
	public VoiceComment()
	{
	}

	// Token: 0x060048C8 RID: 18632 RVA: 0x00017988 File Offset: 0x00015B88
	[Token(Token = "0x6003CF3")]
	[Address(RVA = "0x1E49400", Offset = "0x1E49501", VA = "0x1E49400")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A86D0", Offset = "0x1A87D1")]
	private bool <SetupButtonHint>b__16_0()
	{
		return default(bool);
	}

	// Token: 0x0400A8A5 RID: 43173
	[Token(Token = "0x4007F26")]
	[FieldOffset(Offset = "0x68")]
	private readonly Vector3[] ICON_SCALE;

	// Token: 0x0400A8A6 RID: 43174
	[Token(Token = "0x4007F27")]
	private const int CAST_MAX = 34;

	// Token: 0x0400A8A7 RID: 43175
	[Token(Token = "0x4007F28")]
	[FieldOffset(Offset = "0x70")]
	private UnityAction action;

	// Token: 0x0400A8A8 RID: 43176
	[Token(Token = "0x4007F29")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject castListObject;

	// Token: 0x0400A8A9 RID: 43177
	[Token(Token = "0x4007F2A")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private VoicePlayingWindow playingWindow;

	// Token: 0x0400A8AA RID: 43178
	[Token(Token = "0x4007F2B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private CursorControllerLite cursor;

	// Token: 0x0400A8AB RID: 43179
	[Token(Token = "0x4007F2C")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private List<Image> sdCharaImage;

	// Token: 0x0400A8AC RID: 43180
	[Token(Token = "0x4007F2D")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private List<VoiceComment.CharaSprite> sdCharaIconSprite;

	// Token: 0x0400A8AD RID: 43181
	[Token(Token = "0x4007F2E")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private ButtonHintMain buttonHint;

	// Token: 0x0400A8AE RID: 43182
	[Token(Token = "0x4007F2F")]
	[FieldOffset(Offset = "0xA8")]
	private VoiceCommentDataTable voiceCommentDataTable;

	// Token: 0x0400A8AF RID: 43183
	[Token(Token = "0x4007F30")]
	[FieldOffset(Offset = "0xB0")]
	private bool isPlaying;

	// Token: 0x0400A8B0 RID: 43184
	[Token(Token = "0x4007F31")]
	[FieldOffset(Offset = "0xB1")]
	private bool isFading;

	// Token: 0x02000AF5 RID: 2805
	[Token(Token = "0x2001324")]
	private enum IconType
	{
		// Token: 0x0400A8B2 RID: 43186
		[Token(Token = "0x401B5E3")]
		Normal,
		// Token: 0x0400A8B3 RID: 43187
		[Token(Token = "0x401B5E4")]
		Focus
	}

	// Token: 0x02000AF6 RID: 2806
	[Token(Token = "0x2001325")]
	[Serializable]
	public class CharaSprite
	{
		// Token: 0x060048C9 RID: 18633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076B9")]
		[Address(RVA = "0x1E4A670", Offset = "0x1E4A771", VA = "0x1E4A670")]
		public CharaSprite()
		{
		}

		// Token: 0x0400A8B4 RID: 43188
		[Token(Token = "0x401B5E5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public List<Sprite> Sprite;
	}

	// Token: 0x02000AF7 RID: 2807
	[Token(Token = "0x2001326")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159310", Offset = "0x159411")]
	private sealed class <SetupButtonHint>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048CA RID: 18634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BA")]
		[Address(RVA = "0x1E48310", Offset = "0x1E48411", VA = "0x1E48310")]
		[DebuggerHidden]
		public <SetupButtonHint>d__16(int <>1__state)
		{
		}

		// Token: 0x060048CB RID: 18635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BB")]
		[Address(RVA = "0x1E4A0E0", Offset = "0x1E4A1E1", VA = "0x1E4A0E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060048CC RID: 18636 RVA: 0x000179A0 File Offset: 0x00015BA0
		[Token(Token = "0x60076BC")]
		[Address(RVA = "0x1E4A0F0", Offset = "0x1E4A1F1", VA = "0x1E4A0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x060048CD RID: 18637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAB")]
		private object Current
		{
			[Token(Token = "0x60076BD")]
			[Address(RVA = "0x1E4A200", Offset = "0x1E4A301", VA = "0x1E4A200", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076BE")]
		[Address(RVA = "0x1E4A210", Offset = "0x1E4A311", VA = "0x1E4A210", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x060048CF RID: 18639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAC")]
		private object Current
		{
			[Token(Token = "0x60076BF")]
			[Address(RVA = "0x1E4A270", Offset = "0x1E4A371", VA = "0x1E4A270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8B5 RID: 43189
		[Token(Token = "0x401B5E6")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8B6 RID: 43190
		[Token(Token = "0x401B5E7")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8B7 RID: 43191
		[Token(Token = "0x401B5E8")]
		[FieldOffset(Offset = "0x20")]
		public VoiceComment <>4__this;
	}

	// Token: 0x02000AF8 RID: 2808
	[Token(Token = "0x2001327")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159320", Offset = "0x159421")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x060048D0 RID: 18640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C0")]
		[Address(RVA = "0x1E49420", Offset = "0x1E49521", VA = "0x1E49420")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x060048D1 RID: 18641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C1")]
		[Address(RVA = "0x1E49430", Offset = "0x1E49531", VA = "0x1E49430")]
		internal void <PlayVoice>b__0(AssetHandle<AudioClip> _handle)
		{
		}

		// Token: 0x060048D2 RID: 18642 RVA: 0x000179B8 File Offset: 0x00015BB8
		[Token(Token = "0x60076C2")]
		[Address(RVA = "0x1E494B0", Offset = "0x1E495B1", VA = "0x1E494B0")]
		internal bool <PlayVoice>b__1()
		{
			return default(bool);
		}

		// Token: 0x060048D3 RID: 18643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C3")]
		[Address(RVA = "0x1E49520", Offset = "0x1E49621", VA = "0x1E49520")]
		internal void <PlayVoice>b__2()
		{
		}

		// Token: 0x0400A8B8 RID: 43192
		[Token(Token = "0x401B5E9")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip audioClip;

		// Token: 0x0400A8B9 RID: 43193
		[Token(Token = "0x401B5EA")]
		[FieldOffset(Offset = "0x18")]
		public VoiceComment <>4__this;
	}

	// Token: 0x02000AF9 RID: 2809
	[Token(Token = "0x2001328")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159330", Offset = "0x159431")]
	private sealed class <PlayVoice>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048D4 RID: 18644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C4")]
		[Address(RVA = "0x1E48A30", Offset = "0x1E48B31", VA = "0x1E48A30")]
		[DebuggerHidden]
		public <PlayVoice>d__22(int <>1__state)
		{
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C5")]
		[Address(RVA = "0x1E49950", Offset = "0x1E49A51", VA = "0x1E49950", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x000179D0 File Offset: 0x00015BD0
		[Token(Token = "0x60076C6")]
		[Address(RVA = "0x1E49960", Offset = "0x1E49A61", VA = "0x1E49960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAD")]
		private object Current
		{
			[Token(Token = "0x60076C7")]
			[Address(RVA = "0x1E4A060", Offset = "0x1E4A161", VA = "0x1E4A060", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076C8")]
		[Address(RVA = "0x1E4A070", Offset = "0x1E4A171", VA = "0x1E4A070", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x060048D9 RID: 18649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAE")]
		private object Current
		{
			[Token(Token = "0x60076C9")]
			[Address(RVA = "0x1E4A0D0", Offset = "0x1E4A1D1", VA = "0x1E4A0D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8BA RID: 43194
		[Token(Token = "0x401B5EB")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8BB RID: 43195
		[Token(Token = "0x401B5EC")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8BC RID: 43196
		[Token(Token = "0x401B5ED")]
		[FieldOffset(Offset = "0x20")]
		public VoiceComment <>4__this;

		// Token: 0x0400A8BD RID: 43197
		[Token(Token = "0x401B5EE")]
		[FieldOffset(Offset = "0x28")]
		private VoiceComment.<>c__DisplayClass22_0 <>8__1;
	}

	// Token: 0x02000AFA RID: 2810
	[Token(Token = "0x2001329")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159340", Offset = "0x159441")]
	private sealed class <StartFading>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048DA RID: 18650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CA")]
		[Address(RVA = "0x1E48F80", Offset = "0x1E49081", VA = "0x1E48F80")]
		[DebuggerHidden]
		public <StartFading>d__27(int <>1__state)
		{
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CB")]
		[Address(RVA = "0x1E4A280", Offset = "0x1E4A381", VA = "0x1E4A280", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x000179E8 File Offset: 0x00015BE8
		[Token(Token = "0x60076CC")]
		[Address(RVA = "0x1E4A290", Offset = "0x1E4A391", VA = "0x1E4A290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x060048DD RID: 18653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DAF")]
		private object Current
		{
			[Token(Token = "0x60076CD")]
			[Address(RVA = "0x1E4A5F0", Offset = "0x1E4A6F1", VA = "0x1E4A5F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076CE")]
		[Address(RVA = "0x1E4A600", Offset = "0x1E4A701", VA = "0x1E4A600", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB0")]
		private object Current
		{
			[Token(Token = "0x60076CF")]
			[Address(RVA = "0x1E4A660", Offset = "0x1E4A761", VA = "0x1E4A660", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8BE RID: 43198
		[Token(Token = "0x401B5EF")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8BF RID: 43199
		[Token(Token = "0x401B5F0")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8C0 RID: 43200
		[Token(Token = "0x401B5F1")]
		[FieldOffset(Offset = "0x20")]
		public VoiceComment <>4__this;

		// Token: 0x0400A8C1 RID: 43201
		[Token(Token = "0x401B5F2")]
		[FieldOffset(Offset = "0x28")]
		private int <index>5__2;
	}

	// Token: 0x02000AFB RID: 2811
	[Token(Token = "0x200132A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159350", Offset = "0x159451")]
	private sealed class <CharaSpriteFading>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060048E0 RID: 18656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D0")]
		[Address(RVA = "0x1E49040", Offset = "0x1E49141", VA = "0x1E49040")]
		[DebuggerHidden]
		public <CharaSpriteFading>d__28(int <>1__state)
		{
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D1")]
		[Address(RVA = "0x1E496F0", Offset = "0x1E497F1", VA = "0x1E496F0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00017A00 File Offset: 0x00015C00
		[Token(Token = "0x60076D2")]
		[Address(RVA = "0x1E49700", Offset = "0x1E49801", VA = "0x1E49700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x060048E3 RID: 18659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB1")]
		private object Current
		{
			[Token(Token = "0x60076D3")]
			[Address(RVA = "0x1E498D0", Offset = "0x1E499D1", VA = "0x1E498D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D4")]
		[Address(RVA = "0x1E498E0", Offset = "0x1E499E1", VA = "0x1E498E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB2")]
		private object Current
		{
			[Token(Token = "0x60076D5")]
			[Address(RVA = "0x1E49940", Offset = "0x1E49A41", VA = "0x1E49940", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400A8C2 RID: 43202
		[Token(Token = "0x401B5F3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400A8C3 RID: 43203
		[Token(Token = "0x401B5F4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400A8C4 RID: 43204
		[Token(Token = "0x401B5F5")]
		[FieldOffset(Offset = "0x20")]
		public VoiceComment <>4__this;

		// Token: 0x0400A8C5 RID: 43205
		[Token(Token = "0x401B5F6")]
		[FieldOffset(Offset = "0x28")]
		public int _index;

		// Token: 0x0400A8C6 RID: 43206
		[Token(Token = "0x401B5F7")]
		[FieldOffset(Offset = "0x2C")]
		private float <timeCount>5__2;

		// Token: 0x0400A8C7 RID: 43207
		[Token(Token = "0x401B5F8")]
		[FieldOffset(Offset = "0x30")]
		private float <speed>5__3;
	}

	// Token: 0x02000AFC RID: 2812
	[Token(Token = "0x200132B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159360", Offset = "0x159461")]
	private sealed class <>c__DisplayClass33_0
	{
		// Token: 0x060048E6 RID: 18662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D6")]
		[Address(RVA = "0x1E49180", Offset = "0x1E49281", VA = "0x1E49180")]
		public <>c__DisplayClass33_0()
		{
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D7")]
		[Address(RVA = "0x1E49640", Offset = "0x1E49741", VA = "0x1E49640")]
		internal void <FadeOut>b__0()
		{
		}

		// Token: 0x0400A8C8 RID: 43208
		[Token(Token = "0x401B5F9")]
		[FieldOffset(Offset = "0x10")]
		public VoiceComment <>4__this;

		// Token: 0x0400A8C9 RID: 43209
		[Token(Token = "0x401B5FA")]
		[FieldOffset(Offset = "0x18")]
		public bool _flag;
	}

	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x200132C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159370", Offset = "0x159471")]
	private sealed class <>c__DisplayClass34_0
	{
		// Token: 0x060048E8 RID: 18664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D8")]
		[Address(RVA = "0x1E49280", Offset = "0x1E49381", VA = "0x1E49280")]
		public <>c__DisplayClass34_0()
		{
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076D9")]
		[Address(RVA = "0x1E49690", Offset = "0x1E49791", VA = "0x1E49690")]
		internal void <FadeIn>b__0()
		{
		}

		// Token: 0x0400A8CA RID: 43210
		[Token(Token = "0x401B5FB")]
		[FieldOffset(Offset = "0x10")]
		public VoiceComment <>4__this;

		// Token: 0x0400A8CB RID: 43211
		[Token(Token = "0x401B5FC")]
		[FieldOffset(Offset = "0x18")]
		public bool _flag;
	}
}

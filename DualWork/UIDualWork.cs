using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DualWork
{
	// Token: 0x020010C8 RID: 4296
	[Token(Token = "0x2000AC4")]
	public class UIDualWork : MonoBehaviour
	{
		// Token: 0x06006D0E RID: 27918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x1E0AD10", Offset = "0x1E0AE11", VA = "0x1E0AD10")]
		public void SetSynchroGauge(float gauge)
		{
		}

		// Token: 0x06006D0F RID: 27919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x1E0AE90", Offset = "0x1E0AF91", VA = "0x1E0AE90")]
		public void SetSuccessGauge(float gauge, float position, float criticalGauge, float criticalPosition)
		{
		}

		// Token: 0x06006D10 RID: 27920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x1E0AC70", Offset = "0x1E0AD71", VA = "0x1E0AC70")]
		public void Init()
		{
		}

		// Token: 0x06006D11 RID: 27921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x1E0C420", Offset = "0x1E0C521", VA = "0x1E0C420")]
		public void SetPosTimingbar(float position)
		{
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x1E0D650", Offset = "0x1E0D751", VA = "0x1E0D650")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE750", Offset = "0x1AE851")]
		private IEnumerator FadeBarImpactEffect(GameObject gameObject)
		{
			return null;
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0x1E0BFE0", Offset = "0x1E0C0E1", VA = "0x1E0BFE0")]
		public void OnPerfect()
		{
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0x1E0C140", Offset = "0x1E0C241", VA = "0x1E0C140")]
		public void OnNice()
		{
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x1E0C2A0", Offset = "0x1E0C3A1", VA = "0x1E0C2A0")]
		public void OnBad()
		{
		}

		// Token: 0x06006D16 RID: 27926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x1E0D720", Offset = "0x1E0D821", VA = "0x1E0D720")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE7C0", Offset = "0x1AE8C1")]
		private IEnumerator DelayDisable(Image image)
		{
			return null;
		}

		// Token: 0x06006D17 RID: 27927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0x1E0C400", Offset = "0x1E0C501", VA = "0x1E0C400")]
		public void UpdateTimeText(float time)
		{
		}

		// Token: 0x06006D18 RID: 27928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0x1E0C640", Offset = "0x1E0C741", VA = "0x1E0C640")]
		public void BlackFadeScreen(UnityAction callback)
		{
		}

		// Token: 0x06006D19 RID: 27929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0x1E0D7D0", Offset = "0x1E0D8D1", VA = "0x1E0D7D0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AE830", Offset = "0x1AE931")]
		private IEnumerator FadeCoroutine(float from, float to, float duration, Image image, UnityAction callback)
		{
			return null;
		}

		// Token: 0x06006D1A RID: 27930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0x1E0D8C0", Offset = "0x1E0D9C1", VA = "0x1E0D8C0")]
		public UIDualWork()
		{
		}

		// Token: 0x04017512 RID: 95506
		[Token(Token = "0x401400A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image SynchroGauge;

		// Token: 0x04017513 RID: 95507
		[Token(Token = "0x401400B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform SynchroNorma;

		// Token: 0x04017514 RID: 95508
		[Token(Token = "0x401400C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform SynchroKirakira;

		// Token: 0x04017515 RID: 95509
		[Token(Token = "0x401400D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image SuccessGauge;

		// Token: 0x04017516 RID: 95510
		[Token(Token = "0x401400E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image CriticalGauge;

		// Token: 0x04017517 RID: 95511
		[Token(Token = "0x401400F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform TimingBar;

		// Token: 0x04017518 RID: 95512
		[Token(Token = "0x4014010")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform TimingGauge;

		// Token: 0x04017519 RID: 95513
		[Token(Token = "0x4014011")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject PerfectImpact;

		// Token: 0x0401751A RID: 95514
		[Token(Token = "0x4014012")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject NiceImpact;

		// Token: 0x0401751B RID: 95515
		[Token(Token = "0x4014013")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject BadImpact;

		// Token: 0x0401751C RID: 95516
		[Token(Token = "0x4014014")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image PerfectImage;

		// Token: 0x0401751D RID: 95517
		[Token(Token = "0x4014015")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image NiceImage;

		// Token: 0x0401751E RID: 95518
		[Token(Token = "0x4014016")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image BadImage;

		// Token: 0x0401751F RID: 95519
		[Token(Token = "0x4014017")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private FestivalNumScore TimerUI;

		// Token: 0x04017520 RID: 95520
		[Token(Token = "0x4014018")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image FadeImage;

		// Token: 0x04017521 RID: 95521
		[Token(Token = "0x4014019")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine PrevCoroutine;

		// Token: 0x020010C9 RID: 4297
		[Token(Token = "0x2001570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A090", Offset = "0x15A191")]
		private sealed class <FadeBarImpactEffect>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006D1B RID: 27931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D4C")]
			[Address(RVA = "0x1E0D6F0", Offset = "0x1E0D7F1", VA = "0x1E0D6F0")]
			[DebuggerHidden]
			public <FadeBarImpactEffect>d__19(int <>1__state)
			{
			}

			// Token: 0x06006D1C RID: 27932 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D4D")]
			[Address(RVA = "0x1E0DA70", Offset = "0x1E0DB71", VA = "0x1E0DA70", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006D1D RID: 27933 RVA: 0x000257B8 File Offset: 0x000239B8
			[Token(Token = "0x6007D4E")]
			[Address(RVA = "0x1E0DA80", Offset = "0x1E0DB81", VA = "0x1E0DA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DDE RID: 3550
			// (get) Token: 0x06006D1E RID: 27934 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBB")]
			private object Current
			{
				[Token(Token = "0x6007D4F")]
				[Address(RVA = "0x1E0DBA0", Offset = "0x1E0DCA1", VA = "0x1E0DBA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006D1F RID: 27935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D50")]
			[Address(RVA = "0x1E0DBB0", Offset = "0x1E0DCB1", VA = "0x1E0DBB0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DDF RID: 3551
			// (get) Token: 0x06006D20 RID: 27936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBC")]
			private object Current
			{
				[Token(Token = "0x6007D51")]
				[Address(RVA = "0x1E0DC10", Offset = "0x1E0DD11", VA = "0x1E0DC10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017522 RID: 95522
			[Token(Token = "0x401C114")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017523 RID: 95523
			[Token(Token = "0x401C115")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017524 RID: 95524
			[Token(Token = "0x401C116")]
			[FieldOffset(Offset = "0x20")]
			public GameObject gameObject;

			// Token: 0x04017525 RID: 95525
			[Token(Token = "0x401C117")]
			[FieldOffset(Offset = "0x28")]
			public UIDualWork <>4__this;
		}

		// Token: 0x020010CA RID: 4298
		[Token(Token = "0x2001571")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A0A0", Offset = "0x15A1A1")]
		private sealed class <DelayDisable>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006D21 RID: 27937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D52")]
			[Address(RVA = "0x1E0D7A0", Offset = "0x1E0D8A1", VA = "0x1E0D7A0")]
			[DebuggerHidden]
			public <DelayDisable>d__24(int <>1__state)
			{
			}

			// Token: 0x06006D22 RID: 27938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D53")]
			[Address(RVA = "0x1E0D8D0", Offset = "0x1E0D9D1", VA = "0x1E0D8D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006D23 RID: 27939 RVA: 0x000257D0 File Offset: 0x000239D0
			[Token(Token = "0x6007D54")]
			[Address(RVA = "0x1E0D8E0", Offset = "0x1E0D9E1", VA = "0x1E0D8E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x06006D24 RID: 27940 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBD")]
			private object Current
			{
				[Token(Token = "0x6007D55")]
				[Address(RVA = "0x1E0D9F0", Offset = "0x1E0DAF1", VA = "0x1E0D9F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006D25 RID: 27941 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D56")]
			[Address(RVA = "0x1E0DA00", Offset = "0x1E0DB01", VA = "0x1E0DA00", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x06006D26 RID: 27942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBE")]
			private object Current
			{
				[Token(Token = "0x6007D57")]
				[Address(RVA = "0x1E0DA60", Offset = "0x1E0DB61", VA = "0x1E0DA60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017526 RID: 95526
			[Token(Token = "0x401C118")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017527 RID: 95527
			[Token(Token = "0x401C119")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017528 RID: 95528
			[Token(Token = "0x401C11A")]
			[FieldOffset(Offset = "0x20")]
			public Image image;

			// Token: 0x04017529 RID: 95529
			[Token(Token = "0x401C11B")]
			[FieldOffset(Offset = "0x28")]
			private float <dispTime>5__2;
		}

		// Token: 0x020010CB RID: 4299
		[Token(Token = "0x2001572")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A0B0", Offset = "0x15A1B1")]
		private sealed class <FadeCoroutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006D27 RID: 27943 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D58")]
			[Address(RVA = "0x1E0D890", Offset = "0x1E0D991", VA = "0x1E0D890")]
			[DebuggerHidden]
			public <FadeCoroutine>d__27(int <>1__state)
			{
			}

			// Token: 0x06006D28 RID: 27944 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D59")]
			[Address(RVA = "0x1E0DC20", Offset = "0x1E0DD21", VA = "0x1E0DC20", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006D29 RID: 27945 RVA: 0x000257E8 File Offset: 0x000239E8
			[Token(Token = "0x6007D5A")]
			[Address(RVA = "0x1E0DC30", Offset = "0x1E0DD31", VA = "0x1E0DC30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x06006D2A RID: 27946 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EBF")]
			private object Current
			{
				[Token(Token = "0x6007D5B")]
				[Address(RVA = "0x1E0DDD0", Offset = "0x1E0DED1", VA = "0x1E0DDD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006D2B RID: 27947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D5C")]
			[Address(RVA = "0x1E0DDE0", Offset = "0x1E0DEE1", VA = "0x1E0DDE0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x06006D2C RID: 27948 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000EC0")]
			private object Current
			{
				[Token(Token = "0x6007D5D")]
				[Address(RVA = "0x1E0DE40", Offset = "0x1E0DF41", VA = "0x1E0DE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401752A RID: 95530
			[Token(Token = "0x401C11C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401752B RID: 95531
			[Token(Token = "0x401C11D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401752C RID: 95532
			[Token(Token = "0x401C11E")]
			[FieldOffset(Offset = "0x20")]
			public float from;

			// Token: 0x0401752D RID: 95533
			[Token(Token = "0x401C11F")]
			[FieldOffset(Offset = "0x28")]
			public Image image;

			// Token: 0x0401752E RID: 95534
			[Token(Token = "0x401C120")]
			[FieldOffset(Offset = "0x30")]
			public float to;

			// Token: 0x0401752F RID: 95535
			[Token(Token = "0x401C121")]
			[FieldOffset(Offset = "0x34")]
			public float duration;

			// Token: 0x04017530 RID: 95536
			[Token(Token = "0x401C122")]
			[FieldOffset(Offset = "0x38")]
			public UnityAction callback;

			// Token: 0x04017531 RID: 95537
			[Token(Token = "0x401C123")]
			[FieldOffset(Offset = "0x40")]
			private float <elapsedTime>5__2;
		}
	}
}

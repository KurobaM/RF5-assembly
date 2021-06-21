using System;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;
using UnityEngine.Audio;

namespace RF5_Sound
{
	// Token: 0x02000EBB RID: 3771
	[Token(Token = "0x20009A6")]
	public abstract class AudioSourceController<IDType> : MonoBehaviour where IDType : Enum
	{
		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006254 RID: 25172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F1")]
		public AudioSource AudioSource
		{
			[Token(Token = "0x6005172")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005173")]
			set
			{
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06006255 RID: 25173 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006256 RID: 25174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F2")]
		public Transform Constraint
		{
			[Token(Token = "0x6005174")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC830", Offset = "0x1AC931")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005175")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC840", Offset = "0x1AC941")]
			set
			{
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06006257 RID: 25175 RVA: 0x00021060 File Offset: 0x0001F260
		// (set) Token: 0x06006258 RID: 25176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F3")]
		public bool IsConstraint
		{
			[Token(Token = "0x6005176")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC850", Offset = "0x1AC951")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005177")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC860", Offset = "0x1AC961")]
			set
			{
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06006259 RID: 25177 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600625A RID: 25178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F4")]
		public IDType CurrentID
		{
			[Token(Token = "0x6005178")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC870", Offset = "0x1AC971")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005179")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC880", Offset = "0x1AC981")]
			set
			{
			}
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600517A")]
		protected void SetAssetID(Audio id)
		{
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x00021078 File Offset: 0x0001F278
		[Token(Token = "0x600517B")]
		private bool RemoveAssetID()
		{
			return default(bool);
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600625D RID: 25181 RVA: 0x00021090 File Offset: 0x0001F290
		// (set) Token: 0x0600625E RID: 25182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F5")]
		protected float FadeTime
		{
			[Token(Token = "0x600517C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC890", Offset = "0x1AC991")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600517D")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC8A0", Offset = "0x1AC9A1")]
			set
			{
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600625F RID: 25183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F6")]
		protected virtual AnimationCurve FadeCurve
		{
			[Token(Token = "0x600517E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06006260 RID: 25184 RVA: 0x000210A8 File Offset: 0x0001F2A8
		// (set) Token: 0x06006261 RID: 25185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F7")]
		public bool IsPause
		{
			[Token(Token = "0x600517F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC8B0", Offset = "0x1AC9B1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC8C0", Offset = "0x1AC9C1")]
			protected set
			{
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06006262 RID: 25186 RVA: 0x000210C0 File Offset: 0x0001F2C0
		// (set) Token: 0x06006263 RID: 25187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F8")]
		public float Volume
		{
			[Token(Token = "0x6005181")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC8D0", Offset = "0x1AC9D1")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005182")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC8E0", Offset = "0x1AC9E1")]
			set
			{
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06006264 RID: 25188 RVA: 0x000210D8 File Offset: 0x0001F2D8
		// (set) Token: 0x06006265 RID: 25189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F9")]
		protected float DataTable_Volume
		{
			[Token(Token = "0x6005183")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC8F0", Offset = "0x1AC9F1")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005184")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC900", Offset = "0x1ACA01")]
			set
			{
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x000210F0 File Offset: 0x0001F2F0
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FA")]
		public int Priority
		{
			[Token(Token = "0x6005185")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC910", Offset = "0x1ACA11")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005186")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC920", Offset = "0x1ACA21")]
			private set
			{
			}
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005187")]
		protected virtual AudioSource ReadyAudioSourceComponent()
		{
			return null;
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005188")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005189")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x00021108 File Offset: 0x0001F308
		[Token(Token = "0x170009FB")]
		public float PlayTime
		{
			[Token(Token = "0x600518A")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518B")]
		public virtual void ResetByRemoveAllResources()
		{
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x00021120 File Offset: 0x0001F320
		[Token(Token = "0x600518C")]
		private bool UpdateConstraintPosition()
		{
			return default(bool);
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518D")]
		public void Pause()
		{
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518E")]
		public void UnPause()
		{
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x00021138 File Offset: 0x0001F338
		[Token(Token = "0x600518F")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x00021150 File Offset: 0x0001F350
		[Token(Token = "0x6005190")]
		public bool IsDoneLoad()
		{
			return default(bool);
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06006272 RID: 25202 RVA: 0x00021168 File Offset: 0x0001F368
		[Token(Token = "0x170009FC")]
		public AudioSourceController<IDType>.State GetState
		{
			[Token(Token = "0x6005191")]
			get
			{
				return AudioSourceController.State.NotInit;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06006273 RID: 25203
		[Token(Token = "0x170009FD")]
		public abstract IDType EmptyValue { [Token(Token = "0x6005192")] get; }

		// Token: 0x06006274 RID: 25204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005193")]
		public virtual void DoPlay(IDType id, int priority = 0)
		{
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005194")]
		public void DoPlayForTimeline(IDType id, bool isLoop)
		{
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005195")]
		public virtual void DoResume()
		{
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005196")]
		public void DoFadeIn(IDType id, float fadetime = 3f, int priority = 0)
		{
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005197")]
		public void DoFadeOut(float fadetime)
		{
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005198")]
		public void DoStop()
		{
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005199")]
		public void DoImmediateStop()
		{
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519A")]
		public void SetCustomRolloffCurve(AnimationCurve animationCurve)
		{
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519B")]
		public void LoadWithWait(IDType id)
		{
		}

		// Token: 0x0600627D RID: 25213
		[Token(Token = "0x600519C")]
		protected abstract AudioMixerGroup GetOutputMixer(IDType id);

		// Token: 0x0600627E RID: 25214
		[Token(Token = "0x600519D")]
		protected abstract void SetupBeforePlayByDataTable();

		// Token: 0x0600627F RID: 25215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519E")]
		private void NotInit_Enter()
		{
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600519F")]
		private void Play_internal()
		{
		}

		// Token: 0x06006281 RID: 25217
		[Token(Token = "0x60051A0")]
		protected abstract void Loading_Enter();

		// Token: 0x06006282 RID: 25218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A1")]
		protected void Loading_Update()
		{
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A2")]
		protected virtual void Play_Enter()
		{
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A3")]
		protected virtual void Play_Update()
		{
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A4")]
		protected void Play_Exit()
		{
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06006286 RID: 25222
		[Token(Token = "0x170009FE")]
		public abstract bool IsLoopClip { [Token(Token = "0x60051A5")] get; }

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x00021180 File Offset: 0x0001F380
		[Token(Token = "0x170009FF")]
		public bool IsLoopAudioSource
		{
			[Token(Token = "0x60051A6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A7")]
		protected void FadeIn_Enter()
		{
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A8")]
		protected virtual void FadeIn_Update()
		{
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051A9")]
		protected virtual void FadeOut_Update()
		{
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051AA")]
		protected virtual void Done_Enter()
		{
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051AB")]
		protected AudioSourceController()
		{
		}

		// Token: 0x0400C295 RID: 49813
		[Token(Token = "0x40091D9")]
		[FieldOffset(Offset = "0x0")]
		private AudioSource _AudioSource;

		// Token: 0x0400C296 RID: 49814
		[Token(Token = "0x40091DA")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F250", Offset = "0x17F351")]
		private Transform <Constraint>k__BackingField;

		// Token: 0x0400C297 RID: 49815
		[Token(Token = "0x40091DB")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F260", Offset = "0x17F361")]
		private bool <IsConstraint>k__BackingField;

		// Token: 0x0400C298 RID: 49816
		[Token(Token = "0x40091DC")]
		[FieldOffset(Offset = "0x0")]
		private IDType _CurrentID;

		// Token: 0x0400C299 RID: 49817
		[Token(Token = "0x40091DD")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F270", Offset = "0x17F371")]
		private IDType <CurrentID>k__BackingField;

		// Token: 0x0400C29A RID: 49818
		[Token(Token = "0x40091DE")]
		[FieldOffset(Offset = "0x0")]
		private int EntriedAssetID;

		// Token: 0x0400C29B RID: 49819
		[Token(Token = "0x40091DF")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F280", Offset = "0x17F381")]
		private float <FadeTime>k__BackingField;

		// Token: 0x0400C29C RID: 49820
		[Token(Token = "0x40091E0")]
		[FieldOffset(Offset = "0x0")]
		private float FadeAlpha;

		// Token: 0x0400C29D RID: 49821
		[Token(Token = "0x40091E1")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F290", Offset = "0x17F391")]
		private bool <IsPause>k__BackingField;

		// Token: 0x0400C29E RID: 49822
		[Token(Token = "0x40091E2")]
		[FieldOffset(Offset = "0x0")]
		public DestroyMode DestroyMode;

		// Token: 0x0400C29F RID: 49823
		[Token(Token = "0x40091E3")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F2A0", Offset = "0x17F3A1")]
		private float <Volume>k__BackingField;

		// Token: 0x0400C2A0 RID: 49824
		[Token(Token = "0x40091E4")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F2B0", Offset = "0x17F3B1")]
		private float <DataTable_Volume>k__BackingField;

		// Token: 0x0400C2A1 RID: 49825
		[Token(Token = "0x40091E5")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17F2C0", Offset = "0x17F3C1")]
		private int <Priority>k__BackingField;

		// Token: 0x0400C2A2 RID: 49826
		[Token(Token = "0x40091E6")]
		[FieldOffset(Offset = "0x0")]
		private AudioSourceController<IDType>.Command AfterLoad;

		// Token: 0x0400C2A3 RID: 49827
		[Token(Token = "0x40091E7")]
		[FieldOffset(Offset = "0x0")]
		private AudioSourceController<IDType>.State InitialState;

		// Token: 0x0400C2A4 RID: 49828
		[Token(Token = "0x40091E8")]
		[FieldOffset(Offset = "0x0")]
		private StateMachine<AudioSourceController<IDType>.State> sm;

		// Token: 0x0400C2A5 RID: 49829
		[Token(Token = "0x40091E9")]
		[FieldOffset(Offset = "0x0")]
		private float m_PlayTime;

		// Token: 0x0400C2A6 RID: 49830
		[Token(Token = "0x40091EA")]
		[FieldOffset(Offset = "0x0")]
		private TransitionTables[] TransitionTables;

		// Token: 0x0400C2A7 RID: 49831
		[Token(Token = "0x40091EB")]
		[FieldOffset(Offset = "0x0")]
		private bool IsTimeline;

		// Token: 0x0400C2A8 RID: 49832
		[Token(Token = "0x40091EC")]
		[FieldOffset(Offset = "0x0")]
		private bool IsTimelineLoop;

		// Token: 0x0400C2A9 RID: 49833
		[Token(Token = "0x40091ED")]
		[FieldOffset(Offset = "0x0")]
		private bool wait_first_frame;

		// Token: 0x02000EBC RID: 3772
		[Token(Token = "0x2001481")]
		public enum State
		{
			// Token: 0x0400C2AB RID: 49835
			[Token(Token = "0x401BCC9")]
			NotInit,
			// Token: 0x0400C2AC RID: 49836
			[Token(Token = "0x401BCCA")]
			Loading,
			// Token: 0x0400C2AD RID: 49837
			[Token(Token = "0x401BCCB")]
			FadeIn,
			// Token: 0x0400C2AE RID: 49838
			[Token(Token = "0x401BCCC")]
			FadeOut,
			// Token: 0x0400C2AF RID: 49839
			[Token(Token = "0x401BCCD")]
			Play,
			// Token: 0x0400C2B0 RID: 49840
			[Token(Token = "0x401BCCE")]
			Done
		}

		// Token: 0x02000EBD RID: 3773
		[Token(Token = "0x2001482")]
		private enum Command
		{
			// Token: 0x0400C2B2 RID: 49842
			[Token(Token = "0x401BCD0")]
			Reset,
			// Token: 0x0400C2B3 RID: 49843
			[Token(Token = "0x401BCD1")]
			DoLoad,
			// Token: 0x0400C2B4 RID: 49844
			[Token(Token = "0x401BCD2")]
			ImmediatePlay,
			// Token: 0x0400C2B5 RID: 49845
			[Token(Token = "0x401BCD3")]
			ImmediateFadeIn,
			// Token: 0x0400C2B6 RID: 49846
			[Token(Token = "0x401BCD4")]
			LoadEnd,
			// Token: 0x0400C2B7 RID: 49847
			[Token(Token = "0x401BCD5")]
			LoadEnd_FadeIn,
			// Token: 0x0400C2B8 RID: 49848
			[Token(Token = "0x401BCD6")]
			LoadEnd_Play,
			// Token: 0x0400C2B9 RID: 49849
			[Token(Token = "0x401BCD7")]
			FadeInEnd,
			// Token: 0x0400C2BA RID: 49850
			[Token(Token = "0x401BCD8")]
			DoFadeOut,
			// Token: 0x0400C2BB RID: 49851
			[Token(Token = "0x401BCD9")]
			DoFadeIn,
			// Token: 0x0400C2BC RID: 49852
			[Token(Token = "0x401BCDA")]
			FadeOutEnd,
			// Token: 0x0400C2BD RID: 49853
			[Token(Token = "0x401BCDB")]
			DoEnd,
			// Token: 0x0400C2BE RID: 49854
			[Token(Token = "0x401BCDC")]
			ImmediateEnd
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

namespace Festival
{
	// Token: 0x02001076 RID: 4214
	[Token(Token = "0x2000AAF")]
	public class FestivalManager : SingletonMonoBehaviour<FestivalManager>
	{
		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06006A4E RID: 27214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AA1")]
		public static FestivalCharacterController FestivalPlayer
		{
			[Token(Token = "0x6005894")]
			[Address(RVA = "0x21B2880", Offset = "0x21B2981", VA = "0x21B2880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06006A4F RID: 27215 RVA: 0x000245A0 File Offset: 0x000227A0
		// (set) Token: 0x06006A50 RID: 27216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA2")]
		public static bool IsMiniGame
		{
			[Token(Token = "0x6005895")]
			[Address(RVA = "0x21B3520", Offset = "0x21B3621", VA = "0x21B3520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD830", Offset = "0x1AD931")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005896")]
			[Address(RVA = "0x21B3590", Offset = "0x21B3691", VA = "0x21B3590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD840", Offset = "0x1AD941")]
			private set
			{
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06006A51 RID: 27217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A52 RID: 27218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA3")]
		public FestivalParamter FestivalParamter
		{
			[Token(Token = "0x6005897")]
			[Address(RVA = "0x21B3600", Offset = "0x21B3701", VA = "0x21B3600")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD850", Offset = "0x1AD951")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005898")]
			[Address(RVA = "0x21B3610", Offset = "0x21B3711", VA = "0x21B3610")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD860", Offset = "0x1AD961")]
			private set
			{
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06006A53 RID: 27219 RVA: 0x000245B8 File Offset: 0x000227B8
		// (set) Token: 0x06006A54 RID: 27220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA4")]
		public float TimeCount
		{
			[Token(Token = "0x6005899")]
			[Address(RVA = "0x21B3620", Offset = "0x21B3721", VA = "0x21B3620")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD870", Offset = "0x1AD971")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600589A")]
			[Address(RVA = "0x21B3630", Offset = "0x21B3731", VA = "0x21B3630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD880", Offset = "0x1AD981")]
			private set
			{
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06006A55 RID: 27221 RVA: 0x000245D0 File Offset: 0x000227D0
		// (set) Token: 0x06006A56 RID: 27222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA5")]
		public float PlayerScore
		{
			[Token(Token = "0x600589B")]
			[Address(RVA = "0x21B3640", Offset = "0x21B3741", VA = "0x21B3640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD890", Offset = "0x1AD991")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600589C")]
			[Address(RVA = "0x21B3650", Offset = "0x21B3751", VA = "0x21B3650")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD8A0", Offset = "0x1AD9A1")]
			private set
			{
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06006A57 RID: 27223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A58 RID: 27224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA6")]
		public List<ActorID> GluttonActorList
		{
			[Token(Token = "0x600589D")]
			[Address(RVA = "0x21B3660", Offset = "0x21B3761", VA = "0x21B3660")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD8B0", Offset = "0x1AD9B1")]
			get
			{
				return null;
			}
			[Token(Token = "0x600589E")]
			[Address(RVA = "0x21B3670", Offset = "0x21B3771", VA = "0x21B3670")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD8C0", Offset = "0x1AD9C1")]
			private set
			{
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06006A59 RID: 27225 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A5A RID: 27226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA7")]
		public List<ActorID> PetActorList
		{
			[Token(Token = "0x600589F")]
			[Address(RVA = "0x21B3680", Offset = "0x21B3781", VA = "0x21B3680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD8D0", Offset = "0x1AD9D1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0x21B3690", Offset = "0x21B3791", VA = "0x21B3690")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD8E0", Offset = "0x1AD9E1")]
			private set
			{
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06006A5B RID: 27227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A5C RID: 27228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA8")]
		public List<ActorID> PartnerNPCList
		{
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0x21B36A0", Offset = "0x21B37A1", VA = "0x21B36A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD8F0", Offset = "0x1AD9F1")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058A2")]
			[Address(RVA = "0x21B36B0", Offset = "0x21B37B1", VA = "0x21B36B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD900", Offset = "0x1ADA01")]
			private set
			{
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06006A5D RID: 27229 RVA: 0x000245E8 File Offset: 0x000227E8
		// (set) Token: 0x06006A5E RID: 27230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AA9")]
		public bool IsLoading
		{
			[Token(Token = "0x60058A3")]
			[Address(RVA = "0x21B36C0", Offset = "0x21B37C1", VA = "0x21B36C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD910", Offset = "0x1ADA11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058A4")]
			[Address(RVA = "0x21B36D0", Offset = "0x21B37D1", VA = "0x21B36D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD920", Offset = "0x1ADA21")]
			private set
			{
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06006A5F RID: 27231 RVA: 0x00024600 File Offset: 0x00022800
		// (set) Token: 0x06006A60 RID: 27232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAA")]
		public bool NextRound
		{
			[Token(Token = "0x60058A5")]
			[Address(RVA = "0x21B36E0", Offset = "0x21B37E1", VA = "0x21B36E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058A6")]
			[Address(RVA = "0x21B36F0", Offset = "0x21B37F1", VA = "0x21B36F0")]
			set
			{
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x06006A61 RID: 27233 RVA: 0x00024618 File Offset: 0x00022818
		// (set) Token: 0x06006A62 RID: 27234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAB")]
		public bool IsBattleEnd
		{
			[Token(Token = "0x60058A7")]
			[Address(RVA = "0x21B3780", Offset = "0x21B3881", VA = "0x21B3780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60058A8")]
			[Address(RVA = "0x21B3790", Offset = "0x21B3891", VA = "0x21B3790")]
			set
			{
			}
		}

		// Token: 0x17000D80 RID: 3456
		// (get) Token: 0x06006A63 RID: 27235 RVA: 0x00024630 File Offset: 0x00022830
		[Token(Token = "0x17000AAC")]
		public bool IsPlaying
		{
			[Token(Token = "0x60058A9")]
			[Address(RVA = "0x21B3820", Offset = "0x21B3921", VA = "0x21B3820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D81 RID: 3457
		// (get) Token: 0x06006A64 RID: 27236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006A65 RID: 27237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAD")]
		public FestivalUI FestivalUI
		{
			[Token(Token = "0x60058AA")]
			[Address(RVA = "0x21B3850", Offset = "0x21B3951", VA = "0x21B3850")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD930", Offset = "0x1ADA31")]
			get
			{
				return null;
			}
			[Token(Token = "0x60058AB")]
			[Address(RVA = "0x21B3860", Offset = "0x21B3961", VA = "0x21B3860")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD940", Offset = "0x1ADA41")]
			private set
			{
			}
		}

		// Token: 0x17000D82 RID: 3458
		// (get) Token: 0x06006A66 RID: 27238 RVA: 0x00024648 File Offset: 0x00022848
		// (set) Token: 0x06006A67 RID: 27239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AAE")]
		public FestivalState State
		{
			[Token(Token = "0x60058AC")]
			[Address(RVA = "0x21B3870", Offset = "0x21B3971", VA = "0x21B3870")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD950", Offset = "0x1ADA51")]
			get
			{
				return FestivalState.None;
			}
			[Token(Token = "0x60058AD")]
			[Address(RVA = "0x21B3880", Offset = "0x21B3981", VA = "0x21B3880")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AD960", Offset = "0x1ADA61")]
			private set
			{
			}
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AE")]
		[Address(RVA = "0x21B3890", Offset = "0x21B3991", VA = "0x21B3890", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058AF")]
		[Address(RVA = "0x21B3AC0", Offset = "0x21B3BC1", VA = "0x21B3AC0")]
		private void Start()
		{
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B0")]
		[Address(RVA = "0x21B4370", Offset = "0x21B4471", VA = "0x21B4370")]
		private void Update()
		{
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B1")]
		[Address(RVA = "0x21B4C00", Offset = "0x21B4D01", VA = "0x21B4C00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B2")]
		[Address(RVA = "0x21B4230", Offset = "0x21B4331", VA = "0x21B4230")]
		private void UILoading()
		{
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B3")]
		[Address(RVA = "0x21B4C70", Offset = "0x21B4D71", VA = "0x21B4C70")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD970", Offset = "0x1ADA71")]
		public IEnumerator CountDown()
		{
			return null;
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B4")]
		[Address(RVA = "0x21B4CF0", Offset = "0x21B4DF1", VA = "0x21B4CF0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AD9E0", Offset = "0x1ADAE1")]
		public IEnumerator OnFinishCoroutine()
		{
			return null;
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B5")]
		[Address(RVA = "0x21B4D70", Offset = "0x21B4E71", VA = "0x21B4D70")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADA50", Offset = "0x1ADB51")]
		public IEnumerator OnNextRoundCoroutine()
		{
			return null;
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B6")]
		[Address(RVA = "0x21B4DF0", Offset = "0x21B4EF1", VA = "0x21B4DF0")]
		public void AddScore(float _score)
		{
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058B7")]
		[Address(RVA = "0x21B4E30", Offset = "0x21B4F31", VA = "0x21B4E30")]
		public void SetScore(float _score)
		{
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00024660 File Offset: 0x00022860
		[Token(Token = "0x60058B8")]
		[Address(RVA = "0x21B4F30", Offset = "0x21B5031", VA = "0x21B4F30")]
		public ActorID FestivalActorLottery()
		{
			return ActorID.act000;
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058B9")]
		[Address(RVA = "0x21B4FC0", Offset = "0x21B50C1", VA = "0x21B4FC0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADAC0", Offset = "0x1ADBC1")]
		public IEnumerator PlayCheerVoice()
		{
			return null;
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BA")]
		[Address(RVA = "0x21B5040", Offset = "0x21B5141", VA = "0x21B5040")]
		public void RemoveCheerActor(List<ActorID> _ignore_list)
		{
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BB")]
		[Address(RVA = "0x21B5160", Offset = "0x21B5261", VA = "0x21B5160")]
		public void RemoveCheerActor(ActorID _actor_id)
		{
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BC")]
		[Address(RVA = "0x21B5180", Offset = "0x21B5281", VA = "0x21B5180")]
		public void SetPetRankingList(List<ActorID> _ranking_list)
		{
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x21B5230", Offset = "0x21B5331", VA = "0x21B5230")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ADB30", Offset = "0x1ADC31")]
		private IEnumerator OnTalkingADV(string _script_name)
		{
			return null;
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x21B52B0", Offset = "0x21B53B1", VA = "0x21B52B0")]
		private void CallBackAfterTeleporting()
		{
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x21B5470", Offset = "0x21B5571", VA = "0x21B5470")]
		public FestivalManager()
		{
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C1")]
		[Address(RVA = "0x21B5660", Offset = "0x21B5761", VA = "0x21B5660")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADBA0", Offset = "0x1ADCA1")]
		private void <Update>b__64_0()
		{
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C2")]
		[Address(RVA = "0x21B58F0", Offset = "0x21B59F1", VA = "0x21B58F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADBB0", Offset = "0x1ADCB1")]
		private void <Update>b__64_1()
		{
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C3")]
		[Address(RVA = "0x21B5A10", Offset = "0x21B5B11", VA = "0x21B5A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADBC0", Offset = "0x1ADCC1")]
		private void <Update>b__64_2()
		{
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x21B5A20", Offset = "0x21B5B21", VA = "0x21B5A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1ADBD0", Offset = "0x1ADCD1")]
		private void <UILoading>b__66_0(AssetHandle<GameObject> _handle)
		{
		}

		// Token: 0x04017271 RID: 94833
		[Token(Token = "0x4013E7E")]
		[FieldOffset(Offset = "0x0")]
		public static bool IsMemories;

		// Token: 0x04017272 RID: 94834
		[Token(Token = "0x4013E7F")]
		[FieldOffset(Offset = "0x1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180BD0", Offset = "0x180CD1")]
		private static bool <IsMiniGame>k__BackingField;

		// Token: 0x04017273 RID: 94835
		[Token(Token = "0x4013E80")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180BE0", Offset = "0x180CE1")]
		private FestivalParamter <FestivalParamter>k__BackingField;

		// Token: 0x04017274 RID: 94836
		[Token(Token = "0x4013E81")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180BF0", Offset = "0x180CF1")]
		private float <TimeCount>k__BackingField;

		// Token: 0x04017275 RID: 94837
		[Token(Token = "0x4013E82")]
		public const float FIELD_HEIGHT = 13.31f;

		// Token: 0x04017276 RID: 94838
		[Token(Token = "0x4013E83")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C00", Offset = "0x180D01")]
		private float <PlayerScore>k__BackingField;

		// Token: 0x04017277 RID: 94839
		[Token(Token = "0x4013E84")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C10", Offset = "0x180D11")]
		private List<ActorID> <GluttonActorList>k__BackingField;

		// Token: 0x04017278 RID: 94840
		[Token(Token = "0x4013E85")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C20", Offset = "0x180D21")]
		private List<ActorID> <PetActorList>k__BackingField;

		// Token: 0x04017279 RID: 94841
		[Token(Token = "0x4013E86")]
		[FieldOffset(Offset = "0x38")]
		private List<ActorID> petRankingList;

		// Token: 0x0401727A RID: 94842
		[Token(Token = "0x4013E87")]
		[FieldOffset(Offset = "0x40")]
		private List<ActorID> festivalVistorActorList;

		// Token: 0x0401727B RID: 94843
		[Token(Token = "0x4013E88")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C30", Offset = "0x180D31")]
		private List<ActorID> <PartnerNPCList>k__BackingField;

		// Token: 0x0401727C RID: 94844
		[Token(Token = "0x4013E89")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C40", Offset = "0x180D41")]
		private bool <IsLoading>k__BackingField;

		// Token: 0x0401727D RID: 94845
		[Token(Token = "0x4013E8A")]
		[FieldOffset(Offset = "0x51")]
		private bool nextRound;

		// Token: 0x0401727E RID: 94846
		[Token(Token = "0x4013E8B")]
		[FieldOffset(Offset = "0x52")]
		private bool isBattleEnd;

		// Token: 0x0401727F RID: 94847
		[Token(Token = "0x4013E8C")]
		[FieldOffset(Offset = "0x58")]
		private CheerVoiceDataTable cheerVoiceDataTable;

		// Token: 0x04017280 RID: 94848
		[Token(Token = "0x4013E8D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private FestivalPlayerInput festivalInput;

		// Token: 0x04017281 RID: 94849
		[Token(Token = "0x4013E8E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C60", Offset = "0x180D61")]
		private FestivalUI <FestivalUI>k__BackingField;

		// Token: 0x04017282 RID: 94850
		[Token(Token = "0x4013E8F")]
		[FieldOffset(Offset = "0x70")]
		private int festivalUIID;

		// Token: 0x04017283 RID: 94851
		[Token(Token = "0x4013E90")]
		[FieldOffset(Offset = "0x78")]
		private readonly Dictionary<FestivalType, Define.Event> FESTIVAL_TYPE_TO_EVENT;

		// Token: 0x04017284 RID: 94852
		[Token(Token = "0x4013E91")]
		[FieldOffset(Offset = "0x80")]
		private bool isTimeLimit;

		// Token: 0x04017285 RID: 94853
		[Token(Token = "0x4013E92")]
		[FieldOffset(Offset = "0x4")]
		public static FestivalType Type;

		// Token: 0x04017286 RID: 94854
		[Token(Token = "0x4013E93")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180C70", Offset = "0x180D71")]
		private FestivalState <State>k__BackingField;

		// Token: 0x02001077 RID: 4215
		[Token(Token = "0x2001533")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159CE0", Offset = "0x159DE1")]
		private sealed class <CountDown>d__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006A7F RID: 27263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C69")]
			[Address(RVA = "0x1F7C860", Offset = "0x1F7C961", VA = "0x1F7C860")]
			[DebuggerHidden]
			public <CountDown>d__67(int <>1__state)
			{
			}

			// Token: 0x06006A80 RID: 27264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C6A")]
			[Address(RVA = "0x1F7C890", Offset = "0x1F7C991", VA = "0x1F7C890", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006A81 RID: 27265 RVA: 0x00024678 File Offset: 0x00022878
			[Token(Token = "0x6007C6B")]
			[Address(RVA = "0x1F7C8A0", Offset = "0x1F7C9A1", VA = "0x1F7C8A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x06006A82 RID: 27266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E8F")]
			private object Current
			{
				[Token(Token = "0x6007C6C")]
				[Address(RVA = "0x1F7D120", Offset = "0x1F7D221", VA = "0x1F7D120", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006A83 RID: 27267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C6D")]
			[Address(RVA = "0x1F7D130", Offset = "0x1F7D231", VA = "0x1F7D130", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x06006A84 RID: 27268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E90")]
			private object Current
			{
				[Token(Token = "0x6007C6E")]
				[Address(RVA = "0x1F7D190", Offset = "0x1F7D291", VA = "0x1F7D190", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017287 RID: 94855
			[Token(Token = "0x401BFFF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017288 RID: 94856
			[Token(Token = "0x401C000")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017289 RID: 94857
			[Token(Token = "0x401C001")]
			[FieldOffset(Offset = "0x20")]
			public FestivalManager <>4__this;
		}

		// Token: 0x02001078 RID: 4216
		[Token(Token = "0x2001534")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159CF0", Offset = "0x159DF1")]
		private sealed class <OnFinishCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006A85 RID: 27269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C6F")]
			[Address(RVA = "0x1F7D1A0", Offset = "0x1F7D2A1", VA = "0x1F7D1A0")]
			[DebuggerHidden]
			public <OnFinishCoroutine>d__68(int <>1__state)
			{
			}

			// Token: 0x06006A86 RID: 27270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C70")]
			[Address(RVA = "0x1F7D1D0", Offset = "0x1F7D2D1", VA = "0x1F7D1D0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006A87 RID: 27271 RVA: 0x00024690 File Offset: 0x00022890
			[Token(Token = "0x6007C71")]
			[Address(RVA = "0x1F7D1E0", Offset = "0x1F7D2E1", VA = "0x1F7D1E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x06006A88 RID: 27272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E91")]
			private object Current
			{
				[Token(Token = "0x6007C72")]
				[Address(RVA = "0x1F7D7D0", Offset = "0x1F7D8D1", VA = "0x1F7D7D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006A89 RID: 27273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C73")]
			[Address(RVA = "0x1F7D7E0", Offset = "0x1F7D8E1", VA = "0x1F7D7E0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x06006A8A RID: 27274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E92")]
			private object Current
			{
				[Token(Token = "0x6007C74")]
				[Address(RVA = "0x1F7D840", Offset = "0x1F7D941", VA = "0x1F7D840", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401728A RID: 94858
			[Token(Token = "0x401C002")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401728B RID: 94859
			[Token(Token = "0x401C003")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401728C RID: 94860
			[Token(Token = "0x401C004")]
			[FieldOffset(Offset = "0x20")]
			public FestivalManager <>4__this;
		}

		// Token: 0x02001079 RID: 4217
		[Token(Token = "0x2001535")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D00", Offset = "0x159E01")]
		private sealed class <OnNextRoundCoroutine>d__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006A8B RID: 27275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C75")]
			[Address(RVA = "0x1F7D850", Offset = "0x1F7D951", VA = "0x1F7D850")]
			[DebuggerHidden]
			public <OnNextRoundCoroutine>d__69(int <>1__state)
			{
			}

			// Token: 0x06006A8C RID: 27276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C76")]
			[Address(RVA = "0x1F7D880", Offset = "0x1F7D981", VA = "0x1F7D880", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006A8D RID: 27277 RVA: 0x000246A8 File Offset: 0x000228A8
			[Token(Token = "0x6007C77")]
			[Address(RVA = "0x1F7D890", Offset = "0x1F7D991", VA = "0x1F7D890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x06006A8E RID: 27278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E93")]
			private object Current
			{
				[Token(Token = "0x6007C78")]
				[Address(RVA = "0x1F7DB70", Offset = "0x1F7DC71", VA = "0x1F7DB70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006A8F RID: 27279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C79")]
			[Address(RVA = "0x1F7DB80", Offset = "0x1F7DC81", VA = "0x1F7DB80", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06006A90 RID: 27280 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E94")]
			private object Current
			{
				[Token(Token = "0x6007C7A")]
				[Address(RVA = "0x1F7DBE0", Offset = "0x1F7DCE1", VA = "0x1F7DBE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0401728D RID: 94861
			[Token(Token = "0x401C005")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0401728E RID: 94862
			[Token(Token = "0x401C006")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0401728F RID: 94863
			[Token(Token = "0x401C007")]
			[FieldOffset(Offset = "0x20")]
			public FestivalManager <>4__this;
		}

		// Token: 0x0200107A RID: 4218
		[Token(Token = "0x2001536")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D10", Offset = "0x159E11")]
		private sealed class <PlayCheerVoice>d__73 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006A91 RID: 27281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C7B")]
			[Address(RVA = "0x1F7DE50", Offset = "0x1F7DF51", VA = "0x1F7DE50")]
			[DebuggerHidden]
			public <PlayCheerVoice>d__73(int <>1__state)
			{
			}

			// Token: 0x06006A92 RID: 27282 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C7C")]
			[Address(RVA = "0x1F7DE80", Offset = "0x1F7DF81", VA = "0x1F7DE80", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006A93 RID: 27283 RVA: 0x000246C0 File Offset: 0x000228C0
			[Token(Token = "0x6007C7D")]
			[Address(RVA = "0x1F7DE90", Offset = "0x1F7DF91", VA = "0x1F7DE90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x06006A94 RID: 27284 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E95")]
			private object Current
			{
				[Token(Token = "0x6007C7E")]
				[Address(RVA = "0x1F7E040", Offset = "0x1F7E141", VA = "0x1F7E040", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006A95 RID: 27285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C7F")]
			[Address(RVA = "0x1F7E050", Offset = "0x1F7E151", VA = "0x1F7E050", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06006A96 RID: 27286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E96")]
			private object Current
			{
				[Token(Token = "0x6007C80")]
				[Address(RVA = "0x1F7E0B0", Offset = "0x1F7E1B1", VA = "0x1F7E0B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017290 RID: 94864
			[Token(Token = "0x401C008")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017291 RID: 94865
			[Token(Token = "0x401C009")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017292 RID: 94866
			[Token(Token = "0x401C00A")]
			[FieldOffset(Offset = "0x20")]
			public FestivalManager <>4__this;

			// Token: 0x04017293 RID: 94867
			[Token(Token = "0x401C00B")]
			[FieldOffset(Offset = "0x28")]
			private float <time>5__2;
		}

		// Token: 0x0200107B RID: 4219
		[Token(Token = "0x2001537")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D20", Offset = "0x159E21")]
		private sealed class <>c__DisplayClass77_0
		{
			// Token: 0x06006A97 RID: 27287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C81")]
			[Address(RVA = "0x1F7C830", Offset = "0x1F7C931", VA = "0x1F7C830")]
			public <>c__DisplayClass77_0()
			{
			}

			// Token: 0x06006A98 RID: 27288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C82")]
			[Address(RVA = "0x1F7C840", Offset = "0x1F7C941", VA = "0x1F7C840")]
			internal void <OnTalkingADV>b__0()
			{
			}

			// Token: 0x06006A99 RID: 27289 RVA: 0x000246D8 File Offset: 0x000228D8
			[Token(Token = "0x6007C83")]
			[Address(RVA = "0x1F7C850", Offset = "0x1F7C951", VA = "0x1F7C850")]
			internal bool <OnTalkingADV>b__1()
			{
				return default(bool);
			}

			// Token: 0x04017294 RID: 94868
			[Token(Token = "0x401C00C")]
			[FieldOffset(Offset = "0x10")]
			public bool isTalking;
		}

		// Token: 0x0200107C RID: 4220
		[Token(Token = "0x2001538")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159D30", Offset = "0x159E31")]
		private sealed class <OnTalkingADV>d__77 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06006A9A RID: 27290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C84")]
			[Address(RVA = "0x1F7DBF0", Offset = "0x1F7DCF1", VA = "0x1F7DBF0")]
			[DebuggerHidden]
			public <OnTalkingADV>d__77(int <>1__state)
			{
			}

			// Token: 0x06006A9B RID: 27291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C85")]
			[Address(RVA = "0x1F7DC20", Offset = "0x1F7DD21", VA = "0x1F7DC20", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06006A9C RID: 27292 RVA: 0x000246F0 File Offset: 0x000228F0
			[Token(Token = "0x6007C86")]
			[Address(RVA = "0x1F7DC30", Offset = "0x1F7DD31", VA = "0x1F7DC30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x06006A9D RID: 27293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E97")]
			private object Current
			{
				[Token(Token = "0x6007C87")]
				[Address(RVA = "0x1F7DDD0", Offset = "0x1F7DED1", VA = "0x1F7DDD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06006A9E RID: 27294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C88")]
			[Address(RVA = "0x1F7DDE0", Offset = "0x1F7DEE1", VA = "0x1F7DDE0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x06006A9F RID: 27295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E98")]
			private object Current
			{
				[Token(Token = "0x6007C89")]
				[Address(RVA = "0x1F7DE40", Offset = "0x1F7DF41", VA = "0x1F7DE40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04017295 RID: 94869
			[Token(Token = "0x401C00D")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04017296 RID: 94870
			[Token(Token = "0x401C00E")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04017297 RID: 94871
			[Token(Token = "0x401C00F")]
			[FieldOffset(Offset = "0x20")]
			public string _script_name;
		}
	}
}

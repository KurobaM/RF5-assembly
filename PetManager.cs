using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000529 RID: 1321
[Token(Token = "0x20003C2")]
public class PetManager : SingletonMonoBehaviour<PetManager>
{
	// Token: 0x17000531 RID: 1329
	// (get) Token: 0x0600200A RID: 8202 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700043A")]
	public FestivalCamera Camera
	{
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x213DCE0", Offset = "0x213DDE1", VA = "0x213DCE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x213DCF0", Offset = "0x213DDF1", VA = "0x213DCF0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x213DD60", Offset = "0x213DE61", VA = "0x213DD60")]
	private void Start()
	{
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B49")]
	[Address(RVA = "0x213DE90", Offset = "0x213DF91", VA = "0x213DE90")]
	private void CharaSetup()
	{
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x0000D488 File Offset: 0x0000B688
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x213E120", Offset = "0x213E221", VA = "0x213E120")]
	private bool IsLoading()
	{
		return default(bool);
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x213E330", Offset = "0x213E431", VA = "0x213E330")]
	private void Update()
	{
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x213F300", Offset = "0x213F401", VA = "0x213F300")]
	public PetManager.Result CheckResult()
	{
		return PetManager.Result.None;
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x213EFD0", Offset = "0x213F0D1", VA = "0x213EFD0")]
	private void BattlePrepare()
	{
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x213FE10", Offset = "0x213FF11", VA = "0x213FE10")]
	private int GetNPCMonsterLevel()
	{
		return 0;
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x213FAF0", Offset = "0x213FBF1", VA = "0x213FAF0")]
	private void DecideNextBattleNPC()
	{
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x213F6A0", Offset = "0x213F7A1", VA = "0x213F6A0")]
	private void RankingDecide()
	{
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B51")]
	[Address(RVA = "0x213FF60", Offset = "0x2140061", VA = "0x213FF60")]
	private void AddPlayerMonsterDeadCount()
	{
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x213FF70", Offset = "0x2140071", VA = "0x213FF70")]
	private void AddNPCMonsterDeadCount()
	{
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x213EDF0", Offset = "0x213EEF1", VA = "0x213EDF0")]
	private void EntryPartyMonsterAction(Action<PartyMonster> action)
	{
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x213FD70", Offset = "0x213FE71", VA = "0x213FD70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A00E0", Offset = "0x1A01E1")]
	private IEnumerator AsyncChallange(Action callBack)
	{
		return null;
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x213FFB0", Offset = "0x21400B1", VA = "0x213FFB0")]
	public void OnImageBattle()
	{
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x21400E0", Offset = "0x21401E1", VA = "0x21400E0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A0150", Offset = "0x1A0251")]
	public IEnumerator OnImageResult()
	{
		return null;
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x2140190", Offset = "0x2140291", VA = "0x2140190")]
	public void ResetNpc()
	{
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x2140710", Offset = "0x2140811", VA = "0x2140710")]
	public PetManager()
	{
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B59")]
	[Address(RVA = "0x2140840", Offset = "0x2140941", VA = "0x2140840")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A01C0", Offset = "0x1A02C1")]
	private void <Update>b__28_0(PartyMonster partyMonster)
	{
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x21409A0", Offset = "0x2140AA1", VA = "0x21409A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A01D0", Offset = "0x1A02D1")]
	private void <BattlePrepare>b__30_0()
	{
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x21409B0", Offset = "0x2140AB1", VA = "0x21409B0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A01E0", Offset = "0x1A02E1")]
	private void <AsyncChallange>b__37_0(PartyMonster partyMonster)
	{
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x2140D20", Offset = "0x2140E21", VA = "0x2140D20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A01F0", Offset = "0x1A02F1")]
	private void <AsyncChallange>b__37_2(PartnerMonsterBehaviorController monsterBehaviorController)
	{
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x2140DC0", Offset = "0x2140EC1", VA = "0x2140DC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A0200", Offset = "0x1A0301")]
	private void <ResetNpc>b__40_0(PartyMonster partyMonster)
	{
	}

	// Token: 0x040066E9 RID: 26345
	[Token(Token = "0x4006112")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FestivalCamera petCamera;

	// Token: 0x040066EA RID: 26346
	[Token(Token = "0x4006113")]
	[FieldOffset(Offset = "0x20")]
	private PetUI petUI;

	// Token: 0x040066EB RID: 26347
	[Token(Token = "0x4006114")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject playerPos;

	// Token: 0x040066EC RID: 26348
	[Token(Token = "0x4006115")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject npcPos;

	// Token: 0x040066ED RID: 26349
	[Token(Token = "0x4006116")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject[] Player_PetStartPos;

	// Token: 0x040066EE RID: 26350
	[Token(Token = "0x4006117")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject[] NPC_PetStartPos;

	// Token: 0x040066EF RID: 26351
	[Token(Token = "0x4006118")]
	[FieldOffset(Offset = "0x48")]
	private List<PartnerMonsterBehaviorController> Player_PetControllers;

	// Token: 0x040066F0 RID: 26352
	[Token(Token = "0x4006119")]
	[FieldOffset(Offset = "0x50")]
	private List<PartnerMonsterBehaviorController> NPC_PetControllers;

	// Token: 0x040066F1 RID: 26353
	[Token(Token = "0x400611A")]
	[FieldOffset(Offset = "0x58")]
	private int Player_PetDeadCount;

	// Token: 0x040066F2 RID: 26354
	[Token(Token = "0x400611B")]
	[FieldOffset(Offset = "0x5C")]
	private int NPC_PetDeadCount;

	// Token: 0x040066F3 RID: 26355
	[Token(Token = "0x400611C")]
	[FieldOffset(Offset = "0x60")]
	private int battleRound;

	// Token: 0x040066F4 RID: 26356
	[Token(Token = "0x400611D")]
	[FieldOffset(Offset = "0x64")]
	private readonly int MAX_PET;

	// Token: 0x040066F5 RID: 26357
	[Token(Token = "0x400611E")]
	[FieldOffset(Offset = "0x68")]
	private bool isLoading;

	// Token: 0x040066F6 RID: 26358
	[Token(Token = "0x400611F")]
	[FieldOffset(Offset = "0x70")]
	private List<ActorID> rankingList;

	// Token: 0x040066F7 RID: 26359
	[Token(Token = "0x4006120")]
	[FieldOffset(Offset = "0x78")]
	private PetNpcPetDataTable petNpcPetDataTable;

	// Token: 0x040066F8 RID: 26360
	[Token(Token = "0x4006121")]
	[FieldOffset(Offset = "0x80")]
	private List<FriendMonsterStatusData> NPC_Pets;

	// Token: 0x040066F9 RID: 26361
	[Token(Token = "0x4006122")]
	[FieldOffset(Offset = "0x88")]
	private List<ActorID> actorID;

	// Token: 0x040066FA RID: 26362
	[Token(Token = "0x4006123")]
	[FieldOffset(Offset = "0x90")]
	private PetManager.State state;

	// Token: 0x040066FB RID: 26363
	[Token(Token = "0x4006124")]
	[FieldOffset(Offset = "0x94")]
	private PetManager.Result result;

	// Token: 0x040066FC RID: 26364
	[Token(Token = "0x4006125")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<uint, PartnerMovementOrderType> EntryMonsterOrderTypeDic;

	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x20010F0")]
	public enum Result
	{
		// Token: 0x040066FE RID: 26366
		[Token(Token = "0x401924B")]
		None,
		// Token: 0x040066FF RID: 26367
		[Token(Token = "0x401924C")]
		Win,
		// Token: 0x04006700 RID: 26368
		[Token(Token = "0x401924D")]
		Lose
	}

	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x20010F1")]
	private enum State
	{
		// Token: 0x04006702 RID: 26370
		[Token(Token = "0x401924F")]
		None,
		// Token: 0x04006703 RID: 26371
		[Token(Token = "0x4019250")]
		Awake,
		// Token: 0x04006704 RID: 26372
		[Token(Token = "0x4019251")]
		Begin,
		// Token: 0x04006705 RID: 26373
		[Token(Token = "0x4019252")]
		Load,
		// Token: 0x04006706 RID: 26374
		[Token(Token = "0x4019253")]
		CountDown,
		// Token: 0x04006707 RID: 26375
		[Token(Token = "0x4019254")]
		Main,
		// Token: 0x04006708 RID: 26376
		[Token(Token = "0x4019255")]
		Result,
		// Token: 0x04006709 RID: 26377
		[Token(Token = "0x4019256")]
		End
	}

	// Token: 0x0200052C RID: 1324
	[Token(Token = "0x20010F2")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D20", Offset = "0x157E21")]
	private sealed class <>c__DisplayClass37_0
	{
		// Token: 0x06002022 RID: 8226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FAF")]
		[Address(RVA = "0x2140FB0", Offset = "0x21410B1", VA = "0x2140FB0")]
		public <>c__DisplayClass37_0()
		{
		}

		// Token: 0x0400670A RID: 26378
		[Token(Token = "0x4019257")]
		[FieldOffset(Offset = "0x10")]
		public int i;

		// Token: 0x0400670B RID: 26379
		[Token(Token = "0x4019258")]
		[FieldOffset(Offset = "0x18")]
		public PetManager <>4__this;
	}

	// Token: 0x0200052D RID: 1325
	[Token(Token = "0x20010F3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D30", Offset = "0x157E31")]
	private sealed class <>c__DisplayClass37_1
	{
		// Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0x2140FC0", Offset = "0x21410C1", VA = "0x2140FC0")]
		public <>c__DisplayClass37_1()
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0x2140FD0", Offset = "0x21410D1", VA = "0x2140FD0")]
		internal void <AsyncChallange>b__1(MonsterControllerBase monster)
		{
		}

		// Token: 0x0400670C RID: 26380
		[Token(Token = "0x4019259")]
		[FieldOffset(Offset = "0x10")]
		public MonsterControllerBase monsterBase;

		// Token: 0x0400670D RID: 26381
		[Token(Token = "0x401925A")]
		[FieldOffset(Offset = "0x18")]
		public PetManager.<>c__DisplayClass37_0 CS$<>8__locals1;
	}

	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x20010F4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D40", Offset = "0x157E41")]
	private sealed class <AsyncChallange>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB2")]
		[Address(RVA = "0x213FF80", Offset = "0x2140081", VA = "0x213FF80")]
		[DebuggerHidden]
		public <AsyncChallange>d__37(int <>1__state)
		{
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB3")]
		[Address(RVA = "0x2141180", Offset = "0x2141281", VA = "0x2141180", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0x2141190", Offset = "0x2141291", VA = "0x2141190", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB4")]
		private object Current
		{
			[Token(Token = "0x6006FB5")]
			[Address(RVA = "0x2141D30", Offset = "0x2141E31", VA = "0x2141D30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0x2141D40", Offset = "0x2141E41", VA = "0x2141D40", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB5")]
		private object Current
		{
			[Token(Token = "0x6006FB7")]
			[Address(RVA = "0x2141DA0", Offset = "0x2141EA1", VA = "0x2141DA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400670E RID: 26382
		[Token(Token = "0x401925B")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400670F RID: 26383
		[Token(Token = "0x401925C")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006710 RID: 26384
		[Token(Token = "0x401925D")]
		[FieldOffset(Offset = "0x20")]
		public PetManager <>4__this;

		// Token: 0x04006711 RID: 26385
		[Token(Token = "0x401925E")]
		[FieldOffset(Offset = "0x28")]
		private PetManager.<>c__DisplayClass37_0 <>8__1;

		// Token: 0x04006712 RID: 26386
		[Token(Token = "0x401925F")]
		[FieldOffset(Offset = "0x30")]
		private PetManager.<>c__DisplayClass37_1 <>8__2;

		// Token: 0x04006713 RID: 26387
		[Token(Token = "0x4019260")]
		[FieldOffset(Offset = "0x38")]
		public Action callBack;

		// Token: 0x04006714 RID: 26388
		[Token(Token = "0x4019261")]
		[FieldOffset(Offset = "0x40")]
		private List<FriendMonsterStatusData> <statusList>5__2;

		// Token: 0x04006715 RID: 26389
		[Token(Token = "0x4019262")]
		[FieldOffset(Offset = "0x48")]
		private int <npcPetCount>5__3;
	}

	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x20010F5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157D50", Offset = "0x157E51")]
	private sealed class <OnImageResult>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600202B RID: 8235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0x2140160", Offset = "0x2140261", VA = "0x2140160")]
		[DebuggerHidden]
		public <OnImageResult>d__39(int <>1__state)
		{
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FB9")]
		[Address(RVA = "0x2141DB0", Offset = "0x2141EB1", VA = "0x2141DB0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0x2141DC0", Offset = "0x2141EC1", VA = "0x2141DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB6")]
		private object Current
		{
			[Token(Token = "0x6006FBB")]
			[Address(RVA = "0x2141F20", Offset = "0x2142021", VA = "0x2141F20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FBC")]
		[Address(RVA = "0x2141F30", Offset = "0x2142031", VA = "0x2141F30", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CB7")]
		private object Current
		{
			[Token(Token = "0x6006FBD")]
			[Address(RVA = "0x2141F90", Offset = "0x2142091", VA = "0x2141F90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006716 RID: 26390
		[Token(Token = "0x4019263")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006717 RID: 26391
		[Token(Token = "0x4019264")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006718 RID: 26392
		[Token(Token = "0x4019265")]
		[FieldOffset(Offset = "0x20")]
		public PetManager <>4__this;
	}
}

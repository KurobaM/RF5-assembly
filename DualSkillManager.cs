using System;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

// Token: 0x02000274 RID: 628
[Token(Token = "0x20001F5")]
public class DualSkillManager : SingletonMonoBehaviour<DualSkillManager>
{
	// Token: 0x170002DD RID: 733
	// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170002B3")]
	public PartyBase[] Parties
	{
		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x1E04420", Offset = "0x1E04521", VA = "0x1E04420")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000071A0 File Offset: 0x000053A0
	[Token(Token = "0x170002B4")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x1E04510", Offset = "0x1E04611", VA = "0x1E04510")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x1E04520", Offset = "0x1E04621", VA = "0x1E04520")]
	private void Start()
	{
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x1E04650", Offset = "0x1E04751", VA = "0x1E04650")]
	private void OnDisable()
	{
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x1E04660", Offset = "0x1E04761", VA = "0x1E04660")]
	private void Update()
	{
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x000071B8 File Offset: 0x000053B8
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x1E04960", Offset = "0x1E04A61", VA = "0x1E04960")]
	public bool CheckStatus(ActorID actor_id)
	{
		return default(bool);
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x000071D0 File Offset: 0x000053D0
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x1E04A40", Offset = "0x1E04B41", VA = "0x1E04A40")]
	public bool PlayPartnerActorID(ActorID actorID)
	{
		return default(bool);
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x000071E8 File Offset: 0x000053E8
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x1E04C00", Offset = "0x1E04D01", VA = "0x1E04C00")]
	public bool PlayPartnerPartyIndex(int index)
	{
		return default(bool);
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00007200 File Offset: 0x00005400
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x1E04B50", Offset = "0x1E04C51", VA = "0x1E04B50")]
	public bool Play(ActorID actor_id, CharacterBase target)
	{
		return default(bool);
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00007218 File Offset: 0x00005418
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x1E04D50", Offset = "0x1E04E51", VA = "0x1E04D50")]
	public bool PlayForce(ActorID actor_id, CharacterBase target)
	{
		return default(bool);
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x00007230 File Offset: 0x00005430
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x1E05250", Offset = "0x1E05351", VA = "0x1E05250")]
	private bool BindTarget(CharacterBase target)
	{
		return default(bool);
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x00007248 File Offset: 0x00005448
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x1E05540", Offset = "0x1E05641", VA = "0x1E05540")]
	private bool SetupEffect(int lovePoint)
	{
		return default(bool);
	}

	// Token: 0x06000FB4 RID: 4020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x1E05720", Offset = "0x1E05821", VA = "0x1E05720")]
	private void OnPlay()
	{
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2E")]
	[Address(RVA = "0x1E05960", Offset = "0x1E05A61", VA = "0x1E05960")]
	private void OnStopped(PlayableDirector playableDirector)
	{
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2F")]
	[Address(RVA = "0x1E05970", Offset = "0x1E05A71", VA = "0x1E05970")]
	private void OnResume()
	{
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E30")]
	[Address(RVA = "0x1E05860", Offset = "0x1E05961", VA = "0x1E05860")]
	private void HideToolEquip(Actor actor)
	{
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E31")]
	[Address(RVA = "0x1E05CC0", Offset = "0x1E05DC1", VA = "0x1E05CC0")]
	private void ResetToolEquip(Actor actor)
	{
	}

	// Token: 0x06000FB9 RID: 4025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E32")]
	[Address(RVA = "0x1E05DC0", Offset = "0x1E05EC1", VA = "0x1E05DC0")]
	private void Init()
	{
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E33")]
	[Address(RVA = "0x1E04530", Offset = "0x1E04631", VA = "0x1E04530")]
	public void CleanUp()
	{
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x00007260 File Offset: 0x00005460
	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x1E05E90", Offset = "0x1E05F91", VA = "0x1E05E90")]
	public ActorID GetPartyMemberActorID(int index)
	{
		return ActorID.act000;
	}

	// Token: 0x06000FBC RID: 4028 RVA: 0x00007278 File Offset: 0x00005478
	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x1E04C90", Offset = "0x1E04D91", VA = "0x1E04C90")]
	public bool PlayWithMember(int index, CharacterBase target)
	{
		return default(bool);
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x00007290 File Offset: 0x00005490
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x1E05F70", Offset = "0x1E06071", VA = "0x1E05F70")]
	public bool PlayWithMemberForce(int index, CharacterBase target)
	{
		return default(bool);
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x1E05FC0", Offset = "0x1E060C1", VA = "0x1E05FC0")]
	public DualSkillManager()
	{
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x1E06040", Offset = "0x1E06141", VA = "0x1E06040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C280", Offset = "0x19C381")]
	private void <Init>b__32_0(PlayableDirector director)
	{
	}

	// Token: 0x040008E3 RID: 2275
	[Token(Token = "0x400070B")]
	private const float PREPARATION_MINIMUM_TIME = 0.5f;

	// Token: 0x040008E4 RID: 2276
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x18")]
	private DualSkillManager.Status m_currentStatus;

	// Token: 0x040008E5 RID: 2277
	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_timelineObject;

	// Token: 0x040008E6 RID: 2278
	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PlayableDirector m_playableDirector;

	// Token: 0x040008E7 RID: 2279
	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x30")]
	private float m_elapsed;

	// Token: 0x040008E8 RID: 2280
	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent m_eventPlayEnd;

	// Token: 0x040008E9 RID: 2281
	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x40")]
	private ActorID m_PlayedActorID;

	// Token: 0x040008EA RID: 2282
	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x48")]
	private Actor m_actor1;

	// Token: 0x040008EB RID: 2283
	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x50")]
	private Actor m_actor2;

	// Token: 0x040008EC RID: 2284
	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x58")]
	private CharacterBase m_targetCharacter;

	// Token: 0x040008ED RID: 2285
	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x60")]
	private DamageInfo m_damagaInfo;

	// Token: 0x040008EE RID: 2286
	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0xE0")]
	private int m_loaderID;

	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2001008")]
	private enum Status
	{
		// Token: 0x040008F0 RID: 2288
		[Token(Token = "0x4018E4C")]
		None,
		// Token: 0x040008F1 RID: 2289
		[Token(Token = "0x4018E4D")]
		Preparation,
		// Token: 0x040008F2 RID: 2290
		[Token(Token = "0x4018E4E")]
		PlayInit,
		// Token: 0x040008F3 RID: 2291
		[Token(Token = "0x4018E4F")]
		Playing,
		// Token: 0x040008F4 RID: 2292
		[Token(Token = "0x4018E50")]
		PlayEnd,
		// Token: 0x040008F5 RID: 2293
		[Token(Token = "0x4018E51")]
		Resume,
		// Token: 0x040008F6 RID: 2294
		[Token(Token = "0x4018E52")]
		CleanUp,
		// Token: 0x040008F7 RID: 2295
		[Token(Token = "0x4018E53")]
		Error
	}

	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2001009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1572A0", Offset = "0x1573A1")]
	private sealed class <>c__DisplayClass24_0
	{
		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C72")]
		[Address(RVA = "0x1E05240", Offset = "0x1E05341", VA = "0x1E05240")]
		public <>c__DisplayClass24_0()
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C73")]
		[Address(RVA = "0x1E06050", Offset = "0x1E06151", VA = "0x1E06050")]
		internal void <PlayForce>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040008F8 RID: 2296
		[Token(Token = "0x4018E54")]
		[FieldOffset(Offset = "0x10")]
		public DualSkillManager <>4__this;

		// Token: 0x040008F9 RID: 2297
		[Token(Token = "0x4018E55")]
		[FieldOffset(Offset = "0x18")]
		public CharacterBase target;

		// Token: 0x040008FA RID: 2298
		[Token(Token = "0x4018E56")]
		[FieldOffset(Offset = "0x20")]
		public int lovePoint;
	}
}

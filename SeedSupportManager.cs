using System;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

// Token: 0x0200028C RID: 652
[Token(Token = "0x2000206")]
public class SeedSupportManager : SingletonMonoBehaviour<SeedSupportManager>
{
	// Token: 0x17000303 RID: 771
	// (get) Token: 0x060010BC RID: 4284 RVA: 0x00007B00 File Offset: 0x00005D00
	[Token(Token = "0x170002D9")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x1E30550", Offset = "0x1E30651", VA = "0x1E30550")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x1E30560", Offset = "0x1E30661", VA = "0x1E30560")]
	private void Start()
	{
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x1E30570", Offset = "0x1E30671", VA = "0x1E30570")]
	private void OnDisable()
	{
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x1E30580", Offset = "0x1E30681", VA = "0x1E30580")]
	private void Update()
	{
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00007B18 File Offset: 0x00005D18
	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x1E30880", Offset = "0x1E30981", VA = "0x1E30880")]
	public bool PlayForce(SeedSupportID SupportID, SeedSupportType SupportType)
	{
		return default(bool);
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x1E30BA0", Offset = "0x1E30CA1", VA = "0x1E30BA0", Slot = "5")]
	protected virtual void OnPlay()
	{
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x1E30E00", Offset = "0x1E30F01", VA = "0x1E30E00", Slot = "6")]
	protected virtual void OnStopped(PlayableDirector playableDirector)
	{
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x1E30E10", Offset = "0x1E30F11", VA = "0x1E30E10", Slot = "7")]
	protected virtual void OnResume()
	{
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x1E30D00", Offset = "0x1E30E01", VA = "0x1E30D00")]
	private void HideToolEquip(Actor actor)
	{
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x1E31030", Offset = "0x1E31131", VA = "0x1E31030")]
	private void ResetToolEquip(Actor actor)
	{
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x1E31130", Offset = "0x1E31231", VA = "0x1E31130")]
	private void Init()
	{
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x1E31200", Offset = "0x1E31301", VA = "0x1E31200", Slot = "8")]
	public virtual void CleanUp()
	{
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x1E31320", Offset = "0x1E31421", VA = "0x1E31320")]
	public SeedSupportManager()
	{
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x1E313A0", Offset = "0x1E314A1", VA = "0x1E313A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C4E0", Offset = "0x19C5E1")]
	private void <PlayForce>b__16_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x1E315C0", Offset = "0x1E316C1", VA = "0x1E315C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C4F0", Offset = "0x19C5F1")]
	private void <Init>b__22_0(PlayableDirector director)
	{
	}

	// Token: 0x04000960 RID: 2400
	[Token(Token = "0x4000768")]
	private const float PREPARATION_MINIMUM_TIME = 0.5f;

	// Token: 0x04000961 RID: 2401
	[Token(Token = "0x4000769")]
	[FieldOffset(Offset = "0x18")]
	private SeedSupportManager.Status m_currentStatus;

	// Token: 0x04000962 RID: 2402
	[Token(Token = "0x400076A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_timelineObject;

	// Token: 0x04000963 RID: 2403
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PlayableDirector m_playableDirector;

	// Token: 0x04000964 RID: 2404
	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x30")]
	private float m_elapsed;

	// Token: 0x04000965 RID: 2405
	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent m_eventPlayEnd;

	// Token: 0x04000966 RID: 2406
	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x40")]
	private DamageInfo m_damagaInfo;

	// Token: 0x04000967 RID: 2407
	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0xC0")]
	private int m_loaderID;

	// Token: 0x04000968 RID: 2408
	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0xC4")]
	private SeedSupportID m_CurretSupportID;

	// Token: 0x04000969 RID: 2409
	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0xC8")]
	private SeedSupportType m_CurretSupportType;

	// Token: 0x0200028D RID: 653
	[Token(Token = "0x200100F")]
	private enum Status
	{
		// Token: 0x0400096B RID: 2411
		[Token(Token = "0x4018E6C")]
		None,
		// Token: 0x0400096C RID: 2412
		[Token(Token = "0x4018E6D")]
		Preparation,
		// Token: 0x0400096D RID: 2413
		[Token(Token = "0x4018E6E")]
		PlayInit,
		// Token: 0x0400096E RID: 2414
		[Token(Token = "0x4018E6F")]
		Playing,
		// Token: 0x0400096F RID: 2415
		[Token(Token = "0x4018E70")]
		PlayEnd,
		// Token: 0x04000970 RID: 2416
		[Token(Token = "0x4018E71")]
		Resume,
		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4018E72")]
		CleanUp,
		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4018E73")]
		Error
	}
}

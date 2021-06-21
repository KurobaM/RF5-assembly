using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000049")]
public abstract class ActionScriptControllerBase : MonoBehaviour
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600017D RID: 381
	[Token(Token = "0x1700001D")]
	public abstract Character Character { [Token(Token = "0x6000145")] get; }

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600017F RID: 383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001E")]
	public ActionCode CurrentActionCode
	{
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1FDD0F0", Offset = "0x1FDD1F1", VA = "0x1FDD0F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D10", Offset = "0x199E11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1FDD100", Offset = "0x1FDD201", VA = "0x1FDD100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D20", Offset = "0x199E21")]
		private set
		{
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000181 RID: 385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001F")]
	public string NextActionCodeName
	{
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1FDD110", Offset = "0x1FDD211", VA = "0x1FDD110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D30", Offset = "0x199E31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1FDD120", Offset = "0x1FDD221", VA = "0x1FDD120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D40", Offset = "0x199E41")]
		set
		{
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000182 RID: 386 RVA: 0x000026A0 File Offset: 0x000008A0
	[Token(Token = "0x17000020")]
	public bool IsAction
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1FC9460", Offset = "0x1FC9561", VA = "0x1FC9460")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000183 RID: 387 RVA: 0x000026B8 File Offset: 0x000008B8
	// (set) Token: 0x06000184 RID: 388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000021")]
	public virtual float MotionSpeed
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1FDD130", Offset = "0x1FDD231", VA = "0x1FDD130", Slot = "5")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1FDD160", Offset = "0x1FDD261", VA = "0x1FDD160", Slot = "6")]
		set
		{
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000185 RID: 389 RVA: 0x000026D0 File Offset: 0x000008D0
	[Token(Token = "0x17000022")]
	public virtual float Speed
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1FDD1A0", Offset = "0x1FDD2A1", VA = "0x1FDD1A0", Slot = "7")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000023")]
	public UnityEvent OnInitActionCodeEvent
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1FDD1B0", Offset = "0x1FDD2B1", VA = "0x1FDD1B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D50", Offset = "0x199E51")]
		get
		{
			return null;
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1FDD1C0", Offset = "0x1FDD2C1", VA = "0x1FDD1C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D60", Offset = "0x199E61")]
		set
		{
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000024")]
	public UnityEvent OnStopActionCodeEvent
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1FDD1D0", Offset = "0x1FDD2D1", VA = "0x1FDD1D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D70", Offset = "0x199E71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1FDD1E0", Offset = "0x1FDD2E1", VA = "0x1FDD1E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D80", Offset = "0x199E81")]
		set
		{
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000025")]
	public UnityEvent OnDestroyEvent
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1FDD1F0", Offset = "0x1FDD2F1", VA = "0x1FDD1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199D90", Offset = "0x199E91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1FDD200", Offset = "0x1FDD301", VA = "0x1FDD200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199DA0", Offset = "0x199EA1")]
		set
		{
		}
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000026")]
	public UnityEventBullet OnBulletCreateEvent
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1FDD210", Offset = "0x1FDD311", VA = "0x1FDD210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199DB0", Offset = "0x199EB1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1FDD220", Offset = "0x1FDD321", VA = "0x1FDD220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199DC0", Offset = "0x199EC1")]
		set
		{
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000027")]
	public Transform CreateTransform
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1FDD230", Offset = "0x1FDD331", VA = "0x1FDD230")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199DD0", Offset = "0x199ED1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1FDD240", Offset = "0x1FDD341", VA = "0x1FDD240")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199DE0", Offset = "0x199EE1")]
		set
		{
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000028")]
	public List<Transform> CreateTransformList
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1FDD250", Offset = "0x1FDD351", VA = "0x1FDD250")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199DF0", Offset = "0x199EF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1FDD260", Offset = "0x1FDD361", VA = "0x1FDD260")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E00", Offset = "0x199F01")]
		set
		{
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000192 RID: 402 RVA: 0x000026E8 File Offset: 0x000008E8
	// (set) Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000029")]
	public bool IsMagicUseCreateTransform
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1FDD270", Offset = "0x1FDD371", VA = "0x1FDD270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E10", Offset = "0x199F11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1FDD280", Offset = "0x1FDD381", VA = "0x1FDD280")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E20", Offset = "0x199F21")]
		private set
		{
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002A")]
	public ActionScriptControllerBase.TransformOffset TransformOffsetValue
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1FDD290", Offset = "0x1FDD391", VA = "0x1FDD290")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E30", Offset = "0x199F31")]
		get
		{
			return null;
		}
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1FDD2A0", Offset = "0x1FDD3A1", VA = "0x1FDD2A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E40", Offset = "0x199F41")]
		private set
		{
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x06000196 RID: 406 RVA: 0x00002700 File Offset: 0x00000900
	// (set) Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002B")]
	public SkillActionID CurrentSkillAction
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1FDD2B0", Offset = "0x1FDD3B1", VA = "0x1FDD2B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E50", Offset = "0x199F51")]
		get
		{
			return SkillActionID.ACT_EMPTY;
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1FDD2C0", Offset = "0x1FDD3C1", VA = "0x1FDD2C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E60", Offset = "0x199F61")]
		set
		{
		}
	}

	// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1FC8410", Offset = "0x1FC8511", VA = "0x1FC8410", Slot = "8")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1FDD2D0", Offset = "0x1FDD3D1", VA = "0x1FDD2D0", Slot = "9")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1FDD480", Offset = "0x1FDD581", VA = "0x1FDD480", Slot = "10")]
	protected virtual ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable)
	{
		return null;
	}

	// Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1FDD5A0", Offset = "0x1FDD6A1", VA = "0x1FDD5A0", Slot = "11")]
	public virtual void InternalSetUpActionCode(string actionCodeName)
	{
	}

	// Token: 0x0600019C RID: 412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1FC4CE0", Offset = "0x1FC4DE1", VA = "0x1FC4CE0", Slot = "12")]
	public virtual void DoAction(ActionCode actionCode)
	{
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1FCAB10", Offset = "0x1FCAC11", VA = "0x1FCAB10", Slot = "13")]
	public virtual void StopAction()
	{
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600019E RID: 414 RVA: 0x00002718 File Offset: 0x00000918
	// (set) Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700002C")]
	public bool IsPause
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1FDD8A0", Offset = "0x1FDD9A1", VA = "0x1FDD8A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E70", Offset = "0x199F71")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1FDD8B0", Offset = "0x1FDD9B1", VA = "0x1FDD8B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x199E80", Offset = "0x199F81")]
		private set
		{
		}
	}

	// Token: 0x060001A0 RID: 416 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1FDD8C0", Offset = "0x1FDD9C1", VA = "0x1FDD8C0")]
	public void Pause()
	{
	}

	// Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000169")]
	[Address(RVA = "0x1FDD8D0", Offset = "0x1FDD9D1", VA = "0x1FDD8D0")]
	public void Resume()
	{
	}

	// Token: 0x060001A2 RID: 418 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1FCA6D0", Offset = "0x1FCA7D1", VA = "0x1FCA6D0", Slot = "14")]
	public virtual void GoNext()
	{
	}

	// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1FDD850", Offset = "0x1FDD951", VA = "0x1FDD850")]
	public void ResetCreateTransform()
	{
	}

	// Token: 0x060001A4 RID: 420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1FDD8E0", Offset = "0x1FDD9E1", VA = "0x1FDD8E0")]
	public void ClearCreateTransformList()
	{
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1FDD940", Offset = "0x1FDDA41", VA = "0x1FDD940")]
	public void SetCreateTransform(string boneName, bool isMagicUse)
	{
	}

	// Token: 0x060001A6 RID: 422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1FDDB70", Offset = "0x1FDDC71", VA = "0x1FDDB70")]
	public void SetOffsetPosition(Vector3 position)
	{
	}

	// Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1FDDBA0", Offset = "0x1FDDCA1", VA = "0x1FDDBA0")]
	public void SetOffsetRotation(Vector3 rotation)
	{
	}

	// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000170")]
	[Address(RVA = "0x1FDDBD0", Offset = "0x1FDDCD1", VA = "0x1FDDBD0")]
	public void SetOffsetScale(Vector3 scale)
	{
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000171")]
	[Address(RVA = "0x1FDDC00", Offset = "0x1FDDD01", VA = "0x1FDDC00")]
	public void UpdateCreateObjectTransform(Transform createObjectTransform, bool useRotate = true)
	{
	}

	// Token: 0x060001AA RID: 426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000172")]
	[Address(RVA = "0x1FDDE00", Offset = "0x1FDDF01", VA = "0x1FDDE00")]
	public void NextInitial(NextCommand nextCommand)
	{
	}

	// Token: 0x060001AB RID: 427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000173")]
	[Address(RVA = "0x1FDDE40", Offset = "0x1FDDF41", VA = "0x1FDDE40")]
	public void NextRandomInitial(NextRandomCommand nextRandomCommand)
	{
	}

	// Token: 0x060001AC RID: 428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000174")]
	[Address(RVA = "0x1FC7970", Offset = "0x1FC7A71", VA = "0x1FC7970")]
	public void DoMagic(MagicID magicID, int level, AttackAttribute attribute)
	{
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000175")]
	[Address(RVA = "0x1FDE100", Offset = "0x1FDE201", VA = "0x1FDE100", Slot = "15")]
	public virtual void OnBulletLoad(BulletLoadCommand bulletLoadCmmand)
	{
	}

	// Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000176")]
	[Address(RVA = "0x1FDE110", Offset = "0x1FDE211", VA = "0x1FDE110")]
	public void OnBulletShoot(ProjectileActionMagicCommand onProjectileActionCommand)
	{
	}

	// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1FDE280", Offset = "0x1FDE381", VA = "0x1FDE280")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x199E90", Offset = "0x199F91")]
	private IEnumerator BulletShot_Loop(ProjectileActionMagicCommand onProjectileActionCommand)
	{
		return null;
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1FDE320", Offset = "0x1FDE421", VA = "0x1FDE320", Slot = "16")]
	protected virtual void BulletShot(ProjectileActionMagicCommand onProjectileActionCommand, [Optional] Collider targetCollider)
	{
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1FDE6F0", Offset = "0x1FDE7F1", VA = "0x1FDE6F0", Slot = "17")]
	protected virtual void CreateBullet(BulletID bulletID, Character chara, Vector3 offset, Quaternion rotation, bool isTargetParent, bool isLateral)
	{
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017A")]
	[Address(RVA = "0x1FDEA90", Offset = "0x1FDEB91", VA = "0x1FDEA90")]
	public void OnGreeting(GreetingCommand onGreetingCommand)
	{
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1FDF230", Offset = "0x1FDF331", VA = "0x1FDF230")]
	public void OnSearchEnemy(SearchEnemyActionCommand onProjectileActionCommand)
	{
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1FDF3E0", Offset = "0x1FDF4E1", VA = "0x1FDF3E0")]
	public void OnChangeMoveType(ChangeMoveTypeActionCommand onChangeMoveTypeActionCommand)
	{
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1FDF420", Offset = "0x1FDF521", VA = "0x1FDF420")]
	public void OnRandomRange(RandomRangeActionCommand onRandomRangeActionCommand)
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1FDF4D0", Offset = "0x1FDF5D1", VA = "0x1FDF4D0")]
	public void OnSetLoopShot(SetLoopShotActionCommand onRandomRangeActionCommand)
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1FDF520", Offset = "0x1FDF621", VA = "0x1FDF520")]
	public void OnSetBulletParent(SetBulletParentActionCommand onRandomRangeActionCommand)
	{
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1FDF530", Offset = "0x1FDF631", VA = "0x1FDF530")]
	public void OnSetBulletHold(SetBulletHoldActionCommand onSetBulletHoldActionCommand)
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1FDF540", Offset = "0x1FDF641", VA = "0x1FDF540", Slot = "18")]
	public virtual void DoMagicPlay(MagicID magicID, Vector3 offset)
	{
	}

	// Token: 0x060001BA RID: 442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1FC57B0", Offset = "0x1FC58B1", VA = "0x1FC57B0", Slot = "19")]
	public virtual void DoMagicEfficacy(MagicParamID magicParamID, int level)
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1FC63F0", Offset = "0x1FC64F1", VA = "0x1FC63F0", Slot = "20")]
	public virtual void DoMagicMedi(MagicParamID magicParamID1, MagicParamID magicParamID2, MagicParamID magicParamID3, int level)
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1FDF660", Offset = "0x1FDF761", VA = "0x1FDF660", Slot = "21")]
	public virtual void DoCallBit(BitID bitID, int level)
	{
	}

	// Token: 0x060001BD RID: 445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1FC6E50", Offset = "0x1FC6F51", VA = "0x1FC6E50", Slot = "22")]
	public virtual void DoScore(ScoreType scoreType, int level)
	{
	}

	// Token: 0x060001BE RID: 446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1FDF760", Offset = "0x1FDF861", VA = "0x1FDF760")]
	public void OnPlayVoice(VoiceGroup group, ActorID overrideActorID)
	{
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1FDF850", Offset = "0x1FDF951", VA = "0x1FDF850")]
	public void OnFootSteps(int footIndex, bool effectPlay)
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1FCDCB0", Offset = "0x1FCDDB1", VA = "0x1FCDCB0")]
	public void GetKnockbackInfo(EquipToolDamageAction damageAction, ItemDataTable itemDataTable, ref float knockbackPower, ref int blowPower)
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1FD3740", Offset = "0x1FD3841", VA = "0x1FD3740", Slot = "23")]
	protected virtual void Update()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1FC5400", Offset = "0x1FC5501", VA = "0x1FC5400")]
	protected ActionScriptControllerBase()
	{
	}

	// Token: 0x04000151 RID: 337
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B550", Offset = "0x15B651")]
	private ActionCode <CurrentActionCode>k__BackingField;

	// Token: 0x04000152 RID: 338
	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B560", Offset = "0x15B661")]
	private string <NextActionCodeName>k__BackingField;

	// Token: 0x04000153 RID: 339
	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Dictionary<string, ActionCode> ActionCodes;

	// Token: 0x04000154 RID: 340
	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B570", Offset = "0x15B671")]
	private UnityEvent <OnInitActionCodeEvent>k__BackingField;

	// Token: 0x04000155 RID: 341
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B580", Offset = "0x15B681")]
	private UnityEvent <OnStopActionCodeEvent>k__BackingField;

	// Token: 0x04000156 RID: 342
	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B590", Offset = "0x15B691")]
	private UnityEvent <OnDestroyEvent>k__BackingField;

	// Token: 0x04000157 RID: 343
	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B5A0", Offset = "0x15B6A1")]
	private UnityEventBullet <OnBulletCreateEvent>k__BackingField;

	// Token: 0x04000158 RID: 344
	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public DamageInfo DamageInfo;

	// Token: 0x04000159 RID: 345
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B5B0", Offset = "0x15B6B1")]
	private Transform <CreateTransform>k__BackingField;

	// Token: 0x0400015A RID: 346
	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B5C0", Offset = "0x15B6C1")]
	private List<Transform> <CreateTransformList>k__BackingField;

	// Token: 0x0400015B RID: 347
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B5D0", Offset = "0x15B6D1")]
	private bool <IsMagicUseCreateTransform>k__BackingField;

	// Token: 0x0400015C RID: 348
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B5E0", Offset = "0x15B6E1")]
	private ActionScriptControllerBase.TransformOffset <TransformOffsetValue>k__BackingField;

	// Token: 0x0400015D RID: 349
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool IsBulletShot;

	// Token: 0x0400015E RID: 350
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<Collider> SearchEnemyList;

	// Token: 0x0400015F RID: 351
	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int ChangeMoveType;

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private bool IsRandomRange;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector2 MinRandomRange;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Vector2 MaxRandomRange;

	// Token: 0x04000163 RID: 355
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool IsLoopShot;

	// Token: 0x04000164 RID: 356
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private float LoopShotTime;

	// Token: 0x04000165 RID: 357
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float LoopShotSpace;

	// Token: 0x04000166 RID: 358
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject BulletParent;

	// Token: 0x04000167 RID: 359
	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool IsSetBulletHold;

	// Token: 0x04000168 RID: 360
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B5F0", Offset = "0x15B6F1")]
	private SkillActionID <CurrentSkillAction>k__BackingField;

	// Token: 0x04000169 RID: 361
	[Token(Token = "0x400011A")]
	protected const float kPowerRateSmall = 0.2f;

	// Token: 0x0400016A RID: 362
	[Token(Token = "0x400011B")]
	protected const float kPowerRateMiddle = 0.6f;

	// Token: 0x0400016B RID: 363
	[Token(Token = "0x400011C")]
	protected const float kPowerRateLarge = 1f;

	// Token: 0x0400016C RID: 364
	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	protected EquipSlotType CallRuneAbility;

	// Token: 0x0400016D RID: 365
	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B600", Offset = "0x15B701")]
	private bool <IsPause>k__BackingField;

	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000FA2")]
	public class TransformOffset
	{
		// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B23")]
		[Address(RVA = "0x1D45870", Offset = "0x1D45971", VA = "0x1D45870")]
		public void Reset()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B24")]
		[Address(RVA = "0x1D45910", Offset = "0x1D45A11", VA = "0x1D45910")]
		public TransformOffset()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x4018CC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x4018CC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4018CC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 Scale;
	}

	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000FA3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156FD0", Offset = "0x1570D1")]
	private sealed class <BulletShot_Loop>d__96 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B25")]
		[Address(RVA = "0x1D45640", Offset = "0x1D45741", VA = "0x1D45640")]
		[DebuggerHidden]
		public <BulletShot_Loop>d__96(int <>1__state)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B26")]
		[Address(RVA = "0x1D45670", Offset = "0x1D45771", VA = "0x1D45670", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6006B27")]
		[Address(RVA = "0x1D45680", Offset = "0x1D45781", VA = "0x1D45680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBE")]
		private object Current
		{
			[Token(Token = "0x6006B28")]
			[Address(RVA = "0x1D457F0", Offset = "0x1D458F1", VA = "0x1D457F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B29")]
		[Address(RVA = "0x1D45800", Offset = "0x1D45901", VA = "0x1D45800", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BBF")]
		private object Current
		{
			[Token(Token = "0x6006B2A")]
			[Address(RVA = "0x1D45860", Offset = "0x1D45961", VA = "0x1D45860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4018CCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4018CCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4018CCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionScriptControllerBase <>4__this;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4018CCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ProjectileActionMagicCommand onProjectileActionCommand;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4018CCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <currentTime>5__2;
	}

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000FA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156FE0", Offset = "0x1570E1")]
	private sealed class <>c__DisplayClass98_0
	{
		// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2B")]
		[Address(RVA = "0x1D45570", Offset = "0x1D45671", VA = "0x1D45570")]
		public <>c__DisplayClass98_0()
		{
		}

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4018CCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Character chara;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4018CD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ActionScriptControllerBase <>4__this;
	}

	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000FA5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156FF0", Offset = "0x1570F1")]
	private sealed class <>c__DisplayClass98_1
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2C")]
		[Address(RVA = "0x1D45580", Offset = "0x1D45681", VA = "0x1D45580")]
		public <>c__DisplayClass98_1()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2D")]
		[Address(RVA = "0x1D45590", Offset = "0x1D45691", VA = "0x1D45590")]
		internal void <CreateBullet>b__0(BulletBase bullet, BulletDataTable table)
		{
		}

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4018CD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parent;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4018CD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Collider target;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x4018CD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionScriptControllerBase.<>c__DisplayClass98_0 CS$<>8__locals1;
	}
}

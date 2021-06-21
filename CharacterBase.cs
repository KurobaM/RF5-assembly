using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200021A RID: 538
[Token(Token = "0x20001B5")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x1458E0", Offset = "0x1459E1")]
public abstract class CharacterBase : MonoBehaviour
{
	// Token: 0x1700022F RID: 559
	// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000212")]
	public Rigidbody Rigidbody
	{
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1E8D040", Offset = "0x1E8D141", VA = "0x1E8D040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B4F0", Offset = "0x19B5F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1E8D050", Offset = "0x1E8D151", VA = "0x1E8D050")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B500", Offset = "0x19B601")]
		protected set
		{
		}
	}

	// Token: 0x17000230 RID: 560
	// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000213")]
	public Collider Collider
	{
		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1E8D060", Offset = "0x1E8D161", VA = "0x1E8D060", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B510", Offset = "0x19B611")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x1E8D070", Offset = "0x1E8D171", VA = "0x1E8D070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B520", Offset = "0x19B621")]
		protected set
		{
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000214")]
	public Animator Animator
	{
		[Token(Token = "0x6000A90")]
		[Address(RVA = "0x1E8D080", Offset = "0x1E8D181", VA = "0x1E8D080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B530", Offset = "0x19B631")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x1E8D090", Offset = "0x1E8D191", VA = "0x1E8D090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B540", Offset = "0x19B641")]
		protected set
		{
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000215")]
	public CharacterModel CharacterModel
	{
		[Token(Token = "0x6000A92")]
		[Address(RVA = "0x1E8D0A0", Offset = "0x1E8D1A1", VA = "0x1E8D0A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B550", Offset = "0x19B651")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x1E8D0B0", Offset = "0x1E8D1B1", VA = "0x1E8D0B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B560", Offset = "0x19B661")]
		protected set
		{
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000216")]
	public EmotionController Emotion
	{
		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x1E8D0C0", Offset = "0x1E8D1C1", VA = "0x1E8D0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B570", Offset = "0x19B671")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x1E8D0D0", Offset = "0x1E8D1D1", VA = "0x1E8D0D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B580", Offset = "0x19B681")]
		protected set
		{
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000217")]
	public HitMaster HitMaster
	{
		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x1E8D0E0", Offset = "0x1E8D1E1", VA = "0x1E8D0E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x1E8D0F0", Offset = "0x1E8D1F1", VA = "0x1E8D0F0", Slot = "5")]
	public virtual void OnEnableHitSystem()
	{
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x1E8D100", Offset = "0x1E8D201", VA = "0x1E8D100", Slot = "6")]
	public virtual void OnHitSystemTriggerEnter(Collider collider, CharacterBase characterBase, Vector3 direction, HitOptionParamID paramID, Collider attackCollider)
	{
	}

	// Token: 0x06000BEB RID: 3051
	[Token(Token = "0x6000A99")]
	public abstract bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult);

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00005BC8 File Offset: 0x00003DC8
	[Token(Token = "0x17000218")]
	public virtual Alliance Alliance
	{
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x1E8D110", Offset = "0x1E8D211", VA = "0x1E8D110", Slot = "8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B590", Offset = "0x19B691")]
		get
		{
			return Alliance.None;
		}
	}

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06000BED RID: 3053 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000BEE RID: 3054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000219")]
	public CharacterBase ParentCharacterBase
	{
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x1E8D120", Offset = "0x1E8D221", VA = "0x1E8D120")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B5A0", Offset = "0x19B6A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x1E8D130", Offset = "0x1E8D231", VA = "0x1E8D130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B5B0", Offset = "0x19B6B1")]
		set
		{
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x1E8D140", Offset = "0x1E8D241", VA = "0x1E8D140", Slot = "9")]
	public virtual bool IsCanNotLockon(CharacterBase lockonCharacter)
	{
		return default(bool);
	}

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00005BF8 File Offset: 0x00003DF8
	[Token(Token = "0x1700021A")]
	public virtual Vector3 GetTakeLockonPos
	{
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x1E8D150", Offset = "0x1E8D251", VA = "0x1E8D150", Slot = "10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B5C0", Offset = "0x19B6C1")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A9F")]
	[Address(RVA = "0x1E8D160", Offset = "0x1E8D261", VA = "0x1E8D160", Slot = "11")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA0")]
	[Address(RVA = "0x1E8D2C0", Offset = "0x1E8D3C1", VA = "0x1E8D2C0", Slot = "12")]
	protected virtual void Start()
	{
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA1")]
	[Address(RVA = "0x1E8D2D0", Offset = "0x1E8D3D1", VA = "0x1E8D2D0", Slot = "13")]
	public virtual void ResetAnimator()
	{
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA2")]
	[Address(RVA = "0x1E8D440", Offset = "0x1E8D541", VA = "0x1E8D440", Slot = "14")]
	public virtual void SetNearCullingEnable(bool enable)
	{
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AA3")]
	[Address(RVA = "0x1E8D620", Offset = "0x1E8D721", VA = "0x1E8D620")]
	protected CharacterBase()
	{
	}

	// Token: 0x0400070C RID: 1804
	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D790", Offset = "0x15D891")]
	private Rigidbody <Rigidbody>k__BackingField;

	// Token: 0x0400070D RID: 1805
	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D7A0", Offset = "0x15D8A1")]
	private Collider <Collider>k__BackingField;

	// Token: 0x0400070E RID: 1806
	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D7B0", Offset = "0x15D8B1")]
	private Animator <Animator>k__BackingField;

	// Token: 0x0400070F RID: 1807
	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D7C0", Offset = "0x15D8C1")]
	private CharacterModel <CharacterModel>k__BackingField;

	// Token: 0x04000710 RID: 1808
	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D7D0", Offset = "0x15D8D1")]
	private EmotionController <Emotion>k__BackingField;

	// Token: 0x04000711 RID: 1809
	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15D7E0", Offset = "0x15D8E1")]
	[SerializeField]
	private HitMaster hitMaster;

	// Token: 0x04000712 RID: 1810
	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D830", Offset = "0x15D931")]
	private readonly Alliance <Alliance>k__BackingField;

	// Token: 0x04000713 RID: 1811
	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D840", Offset = "0x15D941")]
	private CharacterBase <ParentCharacterBase>k__BackingField;

	// Token: 0x04000714 RID: 1812
	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D850", Offset = "0x15D951")]
	private readonly Vector3 <GetTakeLockonPos>k__BackingField;
}

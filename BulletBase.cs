using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000175 RID: 373
[Token(Token = "0x2000123")]
[Attribute(Name = "RequireComponent", RVA = "0x1457C0", Offset = "0x1458C1")]
[Attribute(Name = "RequireComponent", RVA = "0x1457C0", Offset = "0x1458C1")]
public class BulletBase : MonoBehaviour
{
	// Token: 0x17000188 RID: 392
	// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000174")]
	public Transform Root
	{
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x218E4D0", Offset = "0x218E5D1", VA = "0x218E4D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000189 RID: 393
	// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007B4 RID: 1972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000175")]
	public BulletDataTable BulletData
	{
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x218E4E0", Offset = "0x218E5E1", VA = "0x218E4E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A960", Offset = "0x19AA61")]
		get
		{
			return null;
		}
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x218E4F0", Offset = "0x218E5F1", VA = "0x218E4F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A970", Offset = "0x19AA71")]
		set
		{
		}
	}

	// Token: 0x1700018A RID: 394
	// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007B6 RID: 1974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000176")]
	public Character Owner
	{
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x218E500", Offset = "0x218E601", VA = "0x218E500")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A980", Offset = "0x19AA81")]
		get
		{
			return null;
		}
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x218E510", Offset = "0x218E611", VA = "0x218E510")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A990", Offset = "0x19AA91")]
		protected set
		{
		}
	}

	// Token: 0x1700018B RID: 395
	// (get) Token: 0x060007B7 RID: 1975 RVA: 0x00004B00 File Offset: 0x00002D00
	// (set) Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000177")]
	public Alliance Alliance
	{
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x218E520", Offset = "0x218E621", VA = "0x218E520")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A9A0", Offset = "0x19AAA1")]
		get
		{
			return Alliance.None;
		}
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x218E530", Offset = "0x218E631", VA = "0x218E530")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A9B0", Offset = "0x19AAB1")]
		protected set
		{
		}
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000178")]
	public Collider Target
	{
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x218E540", Offset = "0x218E641", VA = "0x218E540")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A9C0", Offset = "0x19AAC1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x218E550", Offset = "0x218E651", VA = "0x218E550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A9D0", Offset = "0x19AAD1")]
		set
		{
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x060007BB RID: 1979 RVA: 0x00004B18 File Offset: 0x00002D18
	// (set) Token: 0x060007BC RID: 1980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000179")]
	public bool IsSetup
	{
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x218E560", Offset = "0x218E661", VA = "0x218E560")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A9E0", Offset = "0x19AAE1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x218E570", Offset = "0x218E671", VA = "0x218E570")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A9F0", Offset = "0x19AAF1")]
		protected set
		{
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x060007BD RID: 1981 RVA: 0x00004B30 File Offset: 0x00002D30
	// (set) Token: 0x060007BE RID: 1982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017A")]
	public bool IsDead
	{
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x218E580", Offset = "0x218E681", VA = "0x218E580")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA00", Offset = "0x19AB01")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x218E590", Offset = "0x218E691", VA = "0x218E590")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA10", Offset = "0x19AB11")]
		protected set
		{
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x060007BF RID: 1983 RVA: 0x00004B48 File Offset: 0x00002D48
	// (set) Token: 0x060007C0 RID: 1984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017B")]
	public float Elapsed
	{
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x218E5A0", Offset = "0x218E6A1", VA = "0x218E5A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA20", Offset = "0x19AB21")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x218E5B0", Offset = "0x218E6B1", VA = "0x218E5B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA30", Offset = "0x19AB31")]
		protected set
		{
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00004B60 File Offset: 0x00002D60
	// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700017C")]
	public DamageInfo DamageInfo
	{
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x218E5C0", Offset = "0x218E6C1", VA = "0x218E5C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA40", Offset = "0x19AB41")]
		get
		{
			return default(DamageInfo);
		}
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x218E610", Offset = "0x218E711", VA = "0x218E610")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA50", Offset = "0x19AB51")]
		protected set
		{
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017D")]
	public BulletMotor Motor
	{
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x218E640", Offset = "0x218E741", VA = "0x218E640")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000192 RID: 402
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017E")]
	public BulletMainModule MainModule
	{
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x218E650", Offset = "0x218E751", VA = "0x218E650")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000193 RID: 403
	// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700017F")]
	public BulletSubModule Extention
	{
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x218E660", Offset = "0x218E761", VA = "0x218E660")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000194 RID: 404
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000180")]
	public UnityEvent onDestroyEvent
	{
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x218E670", Offset = "0x218E771", VA = "0x218E670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA60", Offset = "0x19AB61")]
		get
		{
			return null;
		}
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x218E680", Offset = "0x218E781", VA = "0x218E680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA70", Offset = "0x19AB71")]
		set
		{
		}
	}

	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000181")]
	public AS_BulletController ScriptController
	{
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x218E690", Offset = "0x218E791", VA = "0x218E690")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x060007C9 RID: 1993 RVA: 0x00004B78 File Offset: 0x00002D78
	// (set) Token: 0x060007CA RID: 1994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000182")]
	public bool ForceDead
	{
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x218E6A0", Offset = "0x218E7A1", VA = "0x218E6A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA80", Offset = "0x19AB81")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x218E6B0", Offset = "0x218E7B1", VA = "0x218E6B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AA90", Offset = "0x19AB91")]
		set
		{
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x060007CB RID: 1995 RVA: 0x00004B90 File Offset: 0x00002D90
	// (set) Token: 0x060007CC RID: 1996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000183")]
	public int Level
	{
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x218E6C0", Offset = "0x218E7C1", VA = "0x218E6C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AAA0", Offset = "0x19ABA1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x218E6D0", Offset = "0x218E7D1", VA = "0x218E6D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AAB0", Offset = "0x19ABB1")]
		private set
		{
		}
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x060007CD RID: 1997 RVA: 0x00004BA8 File Offset: 0x00002DA8
	// (set) Token: 0x060007CE RID: 1998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000184")]
	public SkillActionID SkillActionID
	{
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x218E6E0", Offset = "0x218E7E1", VA = "0x218E6E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AAC0", Offset = "0x19ABC1")]
		get
		{
			return SkillActionID.ACT_EMPTY;
		}
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x218E6F0", Offset = "0x218E7F1", VA = "0x218E6F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AAD0", Offset = "0x19ABD1")]
		private set
		{
		}
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x218E700", Offset = "0x218E801", VA = "0x218E700")]
	private void Awake()
	{
	}

	// Token: 0x060007D0 RID: 2000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x218E990", Offset = "0x218EA91", VA = "0x218E990")]
	private void OnDestroy()
	{
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x218EC20", Offset = "0x218ED21", VA = "0x218EC20")]
	public void SetPosition(Vector3 position)
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x218EC70", Offset = "0x218ED71", VA = "0x218EC70")]
	public void Move(Vector3 deltaPosition)
	{
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x218ED70", Offset = "0x218EE71", VA = "0x218ED70", Slot = "4")]
	public virtual void Setup(BulletDataTable dataTable, Character owner, Transform parent, Collider target, int level, SkillActionID skillActionID = SkillActionID.ACT_EMPTY)
	{
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x218FE10", Offset = "0x218FF11", VA = "0x218FE10", Slot = "5")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x2190250", Offset = "0x2190351", VA = "0x2190250", Slot = "6")]
	public virtual void OnFixedUpdate()
	{
	}

	// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x2190630", Offset = "0x2190731", VA = "0x2190630", Slot = "7")]
	public virtual void OnCollision()
	{
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x2190740", Offset = "0x2190841", VA = "0x2190740", Slot = "8")]
	public virtual void OnHit(Collider collider, Vector3 point, Vector3 normal)
	{
	}

	// Token: 0x060007D8 RID: 2008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x2190D90", Offset = "0x2190E91", VA = "0x2190D90", Slot = "9")]
	public virtual void OnDead()
	{
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x2190050", Offset = "0x2190151", VA = "0x2190050")]
	private void TryDestroy()
	{
	}

	// Token: 0x060007DA RID: 2010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0x2190FA0", Offset = "0x21910A1", VA = "0x2190FA0")]
	public void ForceDestroy()
	{
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x21911E0", Offset = "0x21912E1", VA = "0x21911E0", Slot = "10")]
	public virtual void DoExtension()
	{
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B3")]
	[Address(RVA = "0x21913D0", Offset = "0x21914D1", VA = "0x21913D0")]
	public void DoActionExp()
	{
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x2191520", Offset = "0x2191621", VA = "0x2191520")]
	public BulletBase()
	{
	}

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_Root;

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C050", Offset = "0x15C151")]
	private BulletDataTable <BulletData>k__BackingField;

	// Token: 0x0400047A RID: 1146
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C060", Offset = "0x15C161")]
	private Character <Owner>k__BackingField;

	// Token: 0x0400047B RID: 1147
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C070", Offset = "0x15C171")]
	private Alliance <Alliance>k__BackingField;

	// Token: 0x0400047C RID: 1148
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C080", Offset = "0x15C181")]
	private Collider <Target>k__BackingField;

	// Token: 0x0400047D RID: 1149
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C090", Offset = "0x15C191")]
	private bool <IsSetup>k__BackingField;

	// Token: 0x0400047E RID: 1150
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x41")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C0A0", Offset = "0x15C1A1")]
	private bool <IsDead>k__BackingField;

	// Token: 0x0400047F RID: 1151
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C0B0", Offset = "0x15C1B1")]
	private float <Elapsed>k__BackingField;

	// Token: 0x04000480 RID: 1152
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C0C0", Offset = "0x15C1C1")]
	private DamageInfo <DamageInfo>k__BackingField;

	// Token: 0x04000481 RID: 1153
	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0xC8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15C0D0", Offset = "0x15C1D1")]
	[SerializeField]
	protected SoundID m_SoundID;

	// Token: 0x04000482 RID: 1154
	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	protected EffectID m_StartEffectID;

	// Token: 0x04000483 RID: 1155
	[Token(Token = "0x4000369")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	protected SoundID m_StartSoundID;

	// Token: 0x04000484 RID: 1156
	[Token(Token = "0x400036A")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	protected SoundID m_StartSoundID2;

	// Token: 0x04000485 RID: 1157
	[Token(Token = "0x400036B")]
	[FieldOffset(Offset = "0xD8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15C150", Offset = "0x15C251")]
	[SerializeField]
	protected EffectID m_DeadEffectID;

	// Token: 0x04000486 RID: 1158
	[Token(Token = "0x400036C")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	protected SoundID m_DeadSoundID;

	// Token: 0x04000487 RID: 1159
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15C1B0", Offset = "0x15C2B1")]
	[SerializeField]
	protected BulletMotor m_Motor;

	// Token: 0x04000488 RID: 1160
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	protected BulletMainModule m_MainModule;

	// Token: 0x04000489 RID: 1161
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	protected BulletSubModule m_Extention;

	// Token: 0x0400048A RID: 1162
	[Token(Token = "0x4000370")]
	[FieldOffset(Offset = "0xF8")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15C220", Offset = "0x15C321")]
	[SerializeField]
	public UnityEvent onHitEvent;

	// Token: 0x0400048B RID: 1163
	[Token(Token = "0x4000371")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public UnityEvent onDeadEvent;

	// Token: 0x0400048C RID: 1164
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x108")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C280", Offset = "0x15C381")]
	private UnityEvent <onDestroyEvent>k__BackingField;

	// Token: 0x0400048D RID: 1165
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x110")]
	protected List<BulletColliderBase> m_Colliders;

	// Token: 0x0400048E RID: 1166
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x118")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15C290", Offset = "0x15C391")]
	[SerializeField]
	protected AS_BulletController m_ScriptController;

	// Token: 0x0400048F RID: 1167
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x120")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C2E0", Offset = "0x15C3E1")]
	private bool <ForceDead>k__BackingField;

	// Token: 0x04000490 RID: 1168
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x128")]
	private Transform m_TrackingTarget;

	// Token: 0x04000491 RID: 1169
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x130")]
	private Vector3 m_TrackingTargetPosition;

	// Token: 0x04000492 RID: 1170
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x13C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C2F0", Offset = "0x15C3F1")]
	private int <Level>k__BackingField;

	// Token: 0x04000493 RID: 1171
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x140")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C300", Offset = "0x15C401")]
	private SkillActionID <SkillActionID>k__BackingField;
}

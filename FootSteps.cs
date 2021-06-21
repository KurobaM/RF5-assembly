using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000107 RID: 263
[Token(Token = "0x20000CE")]
public abstract class FootSteps : MonoBehaviour
{
	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000147")]
	public AudioSource AudioSource
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1ECDBF0", Offset = "0x1ECDCF1", VA = "0x1ECDBF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A4E0", Offset = "0x19A5E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1ECDC00", Offset = "0x1ECDD01", VA = "0x1ECDC00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A4F0", Offset = "0x19A5F1")]
		private set
		{
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x060005A3 RID: 1443
	[Token(Token = "0x17000148")]
	protected abstract FootStepType FootStepType { [Token(Token = "0x60004C1")] get; }

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00003FC0 File Offset: 0x000021C0
	// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000149")]
	public float RaycastHeight
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1ECDC10", Offset = "0x1ECDD11", VA = "0x1ECDC10")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1ECDC20", Offset = "0x1ECDD21", VA = "0x1ECDC20")]
		protected set
		{
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00003FD8 File Offset: 0x000021D8
	[Token(Token = "0x1700014A")]
	public float RaycastDistance
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1ECDC30", Offset = "0x1ECDD31", VA = "0x1ECDC30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00003FF0 File Offset: 0x000021F0
	// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700014B")]
	public float SoundPitch
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1ECDC40", Offset = "0x1ECDD41", VA = "0x1ECDC40")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1ECDC50", Offset = "0x1ECDD51", VA = "0x1ECDC50")]
		protected set
		{
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00004008 File Offset: 0x00002208
	[Token(Token = "0x1700014C")]
	public virtual float FootEffectScale
	{
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1ECDC60", Offset = "0x1ECDD61", VA = "0x1ECDC60", Slot = "5")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x060005AA RID: 1450 RVA: 0x00004020 File Offset: 0x00002220
	[Token(Token = "0x1700014D")]
	public float FootWaterEffectScale
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1ECDC70", Offset = "0x1ECDD71", VA = "0x1ECDC70")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x060005AB RID: 1451 RVA: 0x00004038 File Offset: 0x00002238
	[Token(Token = "0x1700014E")]
	public virtual float LandingEffectScale
	{
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1ECDC80", Offset = "0x1ECDD81", VA = "0x1ECDC80", Slot = "6")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x060005AC RID: 1452 RVA: 0x00004050 File Offset: 0x00002250
	[Token(Token = "0x1700014F")]
	public float LandingWaterEffectScale
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1ECDC90", Offset = "0x1ECDD91", VA = "0x1ECDC90")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x060005AD RID: 1453 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000150")]
	public FootStepDataTable FootStepDataTable
	{
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1ECDCA0", Offset = "0x1ECDDA1", VA = "0x1ECDCA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A500", Offset = "0x19A601")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1ECDCB0", Offset = "0x1ECDDB1", VA = "0x1ECDCB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A510", Offset = "0x19A611")]
		protected set
		{
		}
	}

	// Token: 0x060005AF RID: 1455 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x1ECDCC0", Offset = "0x1ECDDC1", VA = "0x1ECDCC0", Slot = "7")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060005B0 RID: 1456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x1ECDD40", Offset = "0x1ECDE41", VA = "0x1ECDD40")]
	protected void InitAudioSource()
	{
	}

	// Token: 0x060005B1 RID: 1457 RVA: 0x00004068 File Offset: 0x00002268
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x1ECDE30", Offset = "0x1ECDF31", VA = "0x1ECDE30")]
	public float GetSoundDistanceMax()
	{
		return 0f;
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00004080 File Offset: 0x00002280
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x1ECDEE0", Offset = "0x1ECDFE1", VA = "0x1ECDEE0")]
	public float GetSoundDistanceMin()
	{
		return 0f;
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x1ECDF90", Offset = "0x1ECE091", VA = "0x1ECDF90")]
	public float GetEffectDistance()
	{
		return 0f;
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1ECE040", Offset = "0x1ECE141", VA = "0x1ECE040")]
	public float GetDistanceMax()
	{
		return 0f;
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x000040C8 File Offset: 0x000022C8
	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x1ECE0D0", Offset = "0x1ECE1D1", VA = "0x1ECE0D0")]
	public Vector3 GetPosition(int index = -1)
	{
		return default(Vector3);
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x000040E0 File Offset: 0x000022E0
	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x1ECE1E0", Offset = "0x1ECE2E1", VA = "0x1ECE1E0", Slot = "8")]
	protected virtual Vector3 GetRootPosition()
	{
		return default(Vector3);
	}

	// Token: 0x060005B7 RID: 1463 RVA: 0x000040F8 File Offset: 0x000022F8
	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x1ECE210", Offset = "0x1ECE311", VA = "0x1ECE210", Slot = "9")]
	public virtual SoundID GetStepSoundID(GroundType groundType)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x060005B8 RID: 1464 RVA: 0x00004110 File Offset: 0x00002310
	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x1ECE320", Offset = "0x1ECE421", VA = "0x1ECE320", Slot = "10")]
	public virtual SoundID GetLandingSoundID(GroundType groundType)
	{
		return SoundID.Sound_EMPTY;
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x00004128 File Offset: 0x00002328
	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x1ECE3D0", Offset = "0x1ECE4D1", VA = "0x1ECE3D0")]
	public EffectID GetStepEffectID(GroundType groundType)
	{
		return EffectID.EFFECT_EMPTY;
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x00004140 File Offset: 0x00002340
	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x1ECE480", Offset = "0x1ECE581", VA = "0x1ECE480")]
	public EffectID GetLandingEffectID(GroundType groundType)
	{
		return EffectID.EFFECT_EMPTY;
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x1ECE530", Offset = "0x1ECE631", VA = "0x1ECE530", Slot = "11")]
	public virtual void OnFootSteps(GroundType groundType, Collider hitCollider)
	{
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x1ECE5B0", Offset = "0x1ECE6B1", VA = "0x1ECE5B0", Slot = "12")]
	public virtual void OnLanding(GroundType groundType, Collider hitCollider)
	{
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x1ECE630", Offset = "0x1ECE731", VA = "0x1ECE630")]
	protected FootSteps()
	{
	}

	// Token: 0x040002FD RID: 765
	[Token(Token = "0x400024E")]
	protected const float kBackstepDistance = 0.05f;

	// Token: 0x040002FE RID: 766
	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float m_RaycastHeight;

	// Token: 0x040002FF RID: 767
	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float m_RaycastDistance;

	// Token: 0x04000300 RID: 768
	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected float m_SoundPitchValue;

	// Token: 0x04000301 RID: 769
	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected float m_FootEffectScaleValue;

	// Token: 0x04000302 RID: 770
	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected float m_LandingEffectScaleValue;

	// Token: 0x04000303 RID: 771
	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public FootSteps.OnFootStepEvent m_StepEvent;

	// Token: 0x04000304 RID: 772
	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public FootSteps.OnFootStepEvent m_LandingEvent;

	// Token: 0x04000305 RID: 773
	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x40")]
	protected List<Transform> m_TransformList;

	// Token: 0x04000306 RID: 774
	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BD70", Offset = "0x15BE71")]
	private AudioSource <AudioSource>k__BackingField;

	// Token: 0x04000307 RID: 775
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15BD80", Offset = "0x15BE81")]
	private FootStepDataTable <FootStepDataTable>k__BackingField;

	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000FC3")]
	[Serializable]
	public class OnFootStepEvent : UnityEvent<GroundType>
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BCD")]
		[Address(RVA = "0x1ECE780", Offset = "0x1ECE881", VA = "0x1ECE780")]
		public OnFootStepEvent()
		{
		}
	}
}

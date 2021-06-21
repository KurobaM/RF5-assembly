using System;
using Define;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UTJ;

// Token: 0x02000249 RID: 585
[Token(Token = "0x20001D6")]
public class HumanModel : CharacterModel
{
	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000288")]
	public override Transform LookPoint
	{
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x22233E0", Offset = "0x22234E1", VA = "0x22233E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E1F RID: 3615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x2223420", Offset = "0x2223521", VA = "0x2223420", Slot = "5")]
	protected override void Awake()
	{
	}

	// Token: 0x06000E20 RID: 3616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x2223770", Offset = "0x2223871", VA = "0x2223770", Slot = "6")]
	protected override void Start()
	{
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CBF")]
	[Address(RVA = "0x22237A0", Offset = "0x22238A1", VA = "0x22237A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC0")]
	[Address(RVA = "0x2223970", Offset = "0x2223A71", VA = "0x2223970", Slot = "7")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x2223980", Offset = "0x2223A81", VA = "0x2223980")]
	public void Update()
	{
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x2223BE0", Offset = "0x2223CE1", VA = "0x2223BE0")]
	public void LateUpdate()
	{
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x06000E25 RID: 3621 RVA: 0x000067B0 File Offset: 0x000049B0
	// (set) Token: 0x06000E26 RID: 3622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000289")]
	public bool IsPauseSpringBone
	{
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x2223EE0", Offset = "0x2223FE1", VA = "0x2223EE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x2223EF0", Offset = "0x2223FF1", VA = "0x2223EF0")]
		set
		{
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700028A")]
	public SpringManager SpringManager
	{
		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x2223F00", Offset = "0x2224001", VA = "0x2223F00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x2223630", Offset = "0x2223731", VA = "0x2223630")]
	private bool ResetSpringBone()
	{
		return default(bool);
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x2223F10", Offset = "0x2224011", VA = "0x2223F10")]
	public void InitSpringBone()
	{
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x2223C90", Offset = "0x2223D91", VA = "0x2223C90")]
	private void UpdateSpringBone()
	{
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x2223450", Offset = "0x2223551", VA = "0x2223450")]
	public void GetComponentIK()
	{
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x2224000", Offset = "0x2224101", VA = "0x2224000")]
	public void InitComponentIK()
	{
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700028B")]
	public BipedIKSolvers IKSolver
	{
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x2224CD0", Offset = "0x2224DD1", VA = "0x2224CD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700028C")]
	public IKSolverLookAt IKSolverLookAt
	{
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x22220A0", Offset = "0x22221A1", VA = "0x22220A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000067E0 File Offset: 0x000049E0
	// (set) Token: 0x06000E30 RID: 3632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700028D")]
	public bool IsGrounderEnable
	{
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x2224CF0", Offset = "0x2224DF1", VA = "0x2224CF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE70", Offset = "0x19BF71")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CCE")]
		[Address(RVA = "0x2224D00", Offset = "0x2224E01", VA = "0x2224D00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE80", Offset = "0x19BF81")]
		protected set
		{
		}
	}

	// Token: 0x170002AE RID: 686
	// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000067F8 File Offset: 0x000049F8
	// (set) Token: 0x06000E32 RID: 3634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700028E")]
	public float GrounderWeight
	{
		[Token(Token = "0x6000CCF")]
		[Address(RVA = "0x2224D10", Offset = "0x2224E11", VA = "0x2224D10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE90", Offset = "0x19BF91")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000CD0")]
		[Address(RVA = "0x2224D20", Offset = "0x2224E21", VA = "0x2224D20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BEA0", Offset = "0x19BFA1")]
		protected set
		{
		}
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x2224D30", Offset = "0x2224E31", VA = "0x2224D30")]
	public void SetGrounderBaseEnable(bool enable)
	{
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x2224DF0", Offset = "0x2224EF1", VA = "0x2224DF0")]
	public void SetGrounderEnable(bool enable)
	{
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x2224ED0", Offset = "0x2224FD1", VA = "0x2224ED0")]
	public void SetGrounderWeight(float weight)
	{
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x22238C0", Offset = "0x22239C1", VA = "0x22238C0")]
	public void ResetGrounderPosition()
	{
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x2224FB0", Offset = "0x22250B1", VA = "0x2224FB0")]
	public void SetLookAtWegith(float weight)
	{
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x2224FE0", Offset = "0x22250E1", VA = "0x2224FE0")]
	public void SetLookAtTarget(Transform target, Vector3 offset)
	{
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x22250E0", Offset = "0x22251E1", VA = "0x22250E0")]
	public void EnableIK()
	{
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x2225100", Offset = "0x2225201", VA = "0x2225100")]
	public void DisableIK()
	{
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x2225120", Offset = "0x2225221", VA = "0x2225120")]
	public void SetConstraintWeight(ConstraintPresetID presetId)
	{
	}

	// Token: 0x170002AF RID: 687
	// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700028F")]
	public HumanModel.HumanArm LeftArmIK
	{
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x2225140", Offset = "0x2225241", VA = "0x2225140")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x2223BD0", Offset = "0x2223CD1", VA = "0x2223BD0")]
	private void UpdateArmIK()
	{
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x2222050", Offset = "0x2222151", VA = "0x2222050")]
	public Transform GetJoint(HumanJointIDEnum jointId)
	{
		return null;
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x2225360", Offset = "0x2225461", VA = "0x2225360")]
	public void JointVisible(HumanJointIDEnum jointId, bool visible)
	{
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00006810 File Offset: 0x00004A10
	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x2225460", Offset = "0x2225561", VA = "0x2225460")]
	public bool IsJointVisible(HumanJointIDEnum jointId)
	{
		return default(bool);
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x2223780", Offset = "0x2223881", VA = "0x2223780")]
	private void StartJoint()
	{
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x22239C0", Offset = "0x2223AC1", VA = "0x22239C0")]
	private void UpdateJoint()
	{
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x2223790", Offset = "0x2223891", VA = "0x2223790")]
	private void SocketStart()
	{
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x2225570", Offset = "0x2225671", VA = "0x2225570")]
	public Transform GetSocket(HumanAttachIDEnum attachId)
	{
		return null;
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x22255C0", Offset = "0x22256C1", VA = "0x22255C0")]
	public Transform GetEquipItem(HumanAttachIDEnum attachId)
	{
		return null;
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x2225610", Offset = "0x2225711", VA = "0x2225610")]
	public Transform EquipAttach(HumanAttachIDEnum attachId, Transform item, HumanAttachIDEnum left_attach = HumanAttachIDEnum.None)
	{
		return null;
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x22257F0", Offset = "0x22258F1", VA = "0x22257F0")]
	public Transform EquipDetach(HumanAttachIDEnum attachId)
	{
		return null;
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x2225910", Offset = "0x2225A11", VA = "0x2225910")]
	public void SocketEraseOn(HumanAttachIDEnum attachId)
	{
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x2225B00", Offset = "0x2225C01", VA = "0x2225B00")]
	public void SocketEraseOff(HumanAttachIDEnum attachId)
	{
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x2225CF0", Offset = "0x2225DF1", VA = "0x2225CF0")]
	public Transform[] EquipDetachAll()
	{
		return null;
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x2225EA0", Offset = "0x2225FA1", VA = "0x2225EA0")]
	public HumanModel()
	{
	}

	// Token: 0x04000829 RID: 2089
	[Token(Token = "0x4000695")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private string AssetName;

	// Token: 0x0400082A RID: 2090
	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected BipedIK bipedIk;

	// Token: 0x0400082B RID: 2091
	[Token(Token = "0x4000697")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected GrounderBipedIK grounderBipedIk;

	// Token: 0x0400082C RID: 2092
	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	protected HumanModel.HumanArm leftArm;

	// Token: 0x0400082D RID: 2093
	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	protected SpringManager springManager;

	// Token: 0x0400082E RID: 2094
	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private HumanJoint[] humanJoints;

	// Token: 0x0400082F RID: 2095
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	protected HumanModelSocket[] HumanSockets;

	// Token: 0x04000830 RID: 2096
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	protected ConstraintWeightPreset constraintWeightPreset;

	// Token: 0x04000831 RID: 2097
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 PastPosition;

	// Token: 0x04000832 RID: 2098
	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private bool m_IsPauseSpringBone;

	// Token: 0x04000833 RID: 2099
	[Token(Token = "0x400069F")]
	private const float SPRINTBONE_RESET_DISTANCE = 1f;

	// Token: 0x04000834 RID: 2100
	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0xB5")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E320", Offset = "0x15E421")]
	private bool <IsGrounderEnable>k__BackingField;

	// Token: 0x04000835 RID: 2101
	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0xB8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E330", Offset = "0x15E431")]
	private float <GrounderWeight>k__BackingField;

	// Token: 0x0200024A RID: 586
	[Token(Token = "0x2000FFC")]
	[Serializable]
	public class HumanArm
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00006828 File Offset: 0x00004A28
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDD")]
		public bool Enable
		{
			[Token(Token = "0x6006C4D")]
			[Address(RVA = "0x2225F80", Offset = "0x2226081", VA = "0x2225F80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006C4E")]
			[Address(RVA = "0x2225F90", Offset = "0x2226091", VA = "0x2225F90")]
			set
			{
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4F")]
		[Address(RVA = "0x2223FB0", Offset = "0x22240B1", VA = "0x2223FB0")]
		public HumanArm(Transform ikPoint)
		{
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C50")]
		[Address(RVA = "0x2225FA0", Offset = "0x22260A1", VA = "0x2225FA0")]
		public void Setup(IKSolverLimb solver)
		{
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C51")]
		[Address(RVA = "0x2225FB0", Offset = "0x22260B1", VA = "0x2225FB0")]
		public void SetWeight(float _weight)
		{
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C52")]
		[Address(RVA = "0x2225FC0", Offset = "0x22260C1", VA = "0x2225FC0")]
		public void SetTarget(Transform _target)
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C53")]
		[Address(RVA = "0x2225150", Offset = "0x2225251", VA = "0x2225150")]
		public void Update()
		{
		}

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4018E07")]
		[FieldOffset(Offset = "0x10")]
		private float m_Weight;

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4018E08")]
		[FieldOffset(Offset = "0x18")]
		private Transform m_Target;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4018E09")]
		[FieldOffset(Offset = "0x20")]
		private IKSolverLimb m_Solver;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4018E0A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_enable;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x4018E0B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_IkPoint;
	}
}

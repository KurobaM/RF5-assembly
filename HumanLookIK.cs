using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x02000244 RID: 580
[Token(Token = "0x20001D2")]
public class HumanLookIK : MonoBehaviour
{
	// Token: 0x170002A4 RID: 676
	// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E07 RID: 3591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000284")]
	public IKSolverLookAt IKSolverLookAt
	{
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x2221F50", Offset = "0x2222051", VA = "0x2221F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE30", Offset = "0x19BF31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x2221F60", Offset = "0x2222061", VA = "0x2221F60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE40", Offset = "0x19BF41")]
		set
		{
		}
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x2221F70", Offset = "0x2222071", VA = "0x2221F70")]
	public void Setup(HumanModel humanModel)
	{
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x22220D0", Offset = "0x22221D1", VA = "0x22220D0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x22220E0", Offset = "0x22221E1", VA = "0x22220E0")]
	private void OnUpdate()
	{
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x22226C0", Offset = "0x22227C1", VA = "0x22226C0")]
	public void SetTarget(Transform target, Vector3 offset)
	{
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x2222710", Offset = "0x2222811", VA = "0x2222710")]
	public void SetTarget(Transform target)
	{
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x22227C0", Offset = "0x22228C1", VA = "0x22227C0")]
	public void SetWeight(float weight)
	{
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x22227D0", Offset = "0x22228D1", VA = "0x22227D0")]
	public void SetSpeed(float speed)
	{
	}

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00006708 File Offset: 0x00004908
	// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000285")]
	public bool IsDeltaTime
	{
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x22227E0", Offset = "0x22228E1", VA = "0x22227E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE50", Offset = "0x19BF51")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x22227F0", Offset = "0x22228F1", VA = "0x22227F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BE60", Offset = "0x19BF61")]
		set
		{
		}
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00006720 File Offset: 0x00004920
	[Token(Token = "0x17000286")]
	private float GetdeltaTime
	{
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x22226A0", Offset = "0x22227A1", VA = "0x22226A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x2222800", Offset = "0x2222901", VA = "0x2222800")]
	public HumanLookIK()
	{
	}

	// Token: 0x04000805 RID: 2053
	[Token(Token = "0x4000673")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E050", Offset = "0x15E151")]
	private IKSolverLookAt <IKSolverLookAt>k__BackingField;

	// Token: 0x04000806 RID: 2054
	[Token(Token = "0x4000674")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_Target;

	// Token: 0x04000807 RID: 2055
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3 m_Offset;

	// Token: 0x04000808 RID: 2056
	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_maxDistance;

	// Token: 0x04000809 RID: 2057
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_LookSpeed;

	// Token: 0x0400080A RID: 2058
	[Token(Token = "0x4000678")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float m_TargetChangeDelta;

	// Token: 0x0400080B RID: 2059
	[Token(Token = "0x4000679")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E0B0", Offset = "0x15E1B1")]
	private float m_MaxAzimuth;

	// Token: 0x0400080C RID: 2060
	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E100", Offset = "0x15E201")]
	private float m_MinAzimuth;

	// Token: 0x0400080D RID: 2061
	[Token(Token = "0x400067B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E150", Offset = "0x15E251")]
	private float m_MaxAltura;

	// Token: 0x0400080E RID: 2062
	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E1A0", Offset = "0x15E2A1")]
	private float m_MinAltura;

	// Token: 0x0400080F RID: 2063
	[Token(Token = "0x400067D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E1F0", Offset = "0x15E2F1")]
	private float m_MaxWeight;

	// Token: 0x04000810 RID: 2064
	[Token(Token = "0x400067E")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15E230", Offset = "0x15E331")]
	private float m_BodyWeight;

	// Token: 0x04000811 RID: 2065
	[Token(Token = "0x400067F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool m_IgnorAngle;

	// Token: 0x04000812 RID: 2066
	[Token(Token = "0x4000680")]
	[FieldOffset(Offset = "0x5C")]
	private float m_currentMaxWeight;

	// Token: 0x04000813 RID: 2067
	[Token(Token = "0x4000681")]
	[FieldOffset(Offset = "0x60")]
	private Transform m_head;

	// Token: 0x04000814 RID: 2068
	[Token(Token = "0x4000682")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E280", Offset = "0x15E381")]
	private bool <IsDeltaTime>k__BackingField;
}

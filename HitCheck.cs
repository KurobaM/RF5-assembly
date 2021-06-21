using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x2000244")]
public static class HitCheck
{
	// Token: 0x1700037F RID: 895
	// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000347")]
	public static Collider[] OverlapResult
	{
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x24F2C10", Offset = "0x24F2D11", VA = "0x24F2C10")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000348")]
	public static RaycastHit[] CastResult
	{
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x24F2C80", Offset = "0x24F2D81", VA = "0x24F2C80")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000381 RID: 897
	// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000349")]
	public static HitResult[] HitResults
	{
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x24F2CF0", Offset = "0x24F2DF1", VA = "0x24F2CF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x24F2D60", Offset = "0x24F2E61", VA = "0x24F2D60")]
	private static void ClearHitResult()
	{
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x00008E38 File Offset: 0x00007038
	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x24F2DD0", Offset = "0x24F2ED1", VA = "0x24F2DD0")]
	private static bool AddHitResult(Vector3 point, Vector3 normal, float distance, Collider collider)
	{
		return default(bool);
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x24F3120", Offset = "0x24F3221", VA = "0x24F3120")]
	private static void SortHitResults(Vector3 center)
	{
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x00008E50 File Offset: 0x00007050
	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x24F3220", Offset = "0x24F3321", VA = "0x24F3220")]
	public static int OverlapSphere(Vector3 center, float radius, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
		return 0;
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00008E68 File Offset: 0x00007068
	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x24F3360", Offset = "0x24F3461", VA = "0x24F3360")]
	public static int SphereCast(Vector3 origin, float radius, Vector3 direction, float distance, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x24F34D0", Offset = "0x24F35D1", VA = "0x24F34D0")]
	private static void SphereCheckFunc(float radius, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x00008E80 File Offset: 0x00007080
	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x24F3A20", Offset = "0x24F3B21", VA = "0x24F3A20")]
	public static int SphereCheck(float radius, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00008E98 File Offset: 0x00007098
	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x24F3B70", Offset = "0x24F3C71", VA = "0x24F3B70")]
	public static int Check(SphereCollider sphere, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00008EB0 File Offset: 0x000070B0
	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x24F3DD0", Offset = "0x24F3ED1", VA = "0x24F3DD0")]
	public static int OverlapBox(Vector3 center, Vector3 halfExtents, Quaternion rotation, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x00008EC8 File Offset: 0x000070C8
	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x24F3F60", Offset = "0x24F4061", VA = "0x24F3F60")]
	public static int BoxCast(Vector3 origin, Vector3 halfExtents, Vector3 direction, Quaternion rotation, float distance, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013B1 RID: 5041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x24F4130", Offset = "0x24F4231", VA = "0x24F4130")]
	public static void BoxCheckFunc(Vector3 size, Quaternion rotation, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction)
	{
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x00008EE0 File Offset: 0x000070E0
	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x24F4760", Offset = "0x24F4861", VA = "0x24F4760")]
	public static int BoxCheck(Vector3 size, Quaternion rotation, Vector3 to, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013B3 RID: 5043 RVA: 0x00008EF8 File Offset: 0x000070F8
	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x24F48C0", Offset = "0x24F49C1", VA = "0x24F48C0")]
	public static int Check(BoxCollider box, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00008F10 File Offset: 0x00007110
	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x24F4B60", Offset = "0x24F4C61", VA = "0x24F4B60")]
	public static int Check(Collider collider, Vector3 from, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.Ignore)
	{
		return 0;
	}

	// Token: 0x04000B05 RID: 2821
	[Token(Token = "0x400089D")]
	private const int OverlapResultMax = 256;

	// Token: 0x04000B06 RID: 2822
	[Token(Token = "0x400089E")]
	private const int CastResultMax = 256;

	// Token: 0x04000B07 RID: 2823
	[Token(Token = "0x400089F")]
	private const int HitResultMax = 512;

	// Token: 0x04000B08 RID: 2824
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x0")]
	private static ColliderComparer m_ColliderComparer;

	// Token: 0x04000B09 RID: 2825
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x8")]
	private static RaycastHitComparer m_RaycastHitComparer;

	// Token: 0x04000B0A RID: 2826
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x10")]
	private static HitResultComparer m_HitResultComparer;

	// Token: 0x04000B0B RID: 2827
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x18")]
	private static Collider[] m_OverlapResult;

	// Token: 0x04000B0C RID: 2828
	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x20")]
	private static RaycastHit[] m_CastResult;

	// Token: 0x04000B0D RID: 2829
	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x28")]
	private static HitResult[] m_hitResults;

	// Token: 0x04000B0E RID: 2830
	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x30")]
	private static int m_hitResultCount;
}

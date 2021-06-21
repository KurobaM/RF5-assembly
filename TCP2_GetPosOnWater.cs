using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B5A RID: 2906
[Token(Token = "0x2000793")]
public class TCP2_GetPosOnWater : MonoBehaviour
{
	// Token: 0x06004ABF RID: 19135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003E9E")]
	[Address(RVA = "0x1FBD170", Offset = "0x1FBD271", VA = "0x1FBD170")]
	private void LateUpdate()
	{
	}

	// Token: 0x06004AC0 RID: 19136 RVA: 0x00017DC0 File Offset: 0x00015FC0
	[Token(Token = "0x6003E9F")]
	[Address(RVA = "0x1FBD300", Offset = "0x1FBD401", VA = "0x1FBD300")]
	public Vector3 GetPositionOnWater(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x06004AC1 RID: 19137 RVA: 0x00017DD8 File Offset: 0x00015FD8
	[Token(Token = "0x6003EA0")]
	[Address(RVA = "0x1FBDD60", Offset = "0x1FBDE61", VA = "0x1FBDD60")]
	public Vector3 GetNormalOnWater(Vector3 worldPosition)
	{
		return default(Vector3);
	}

	// Token: 0x06004AC2 RID: 19138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003EA1")]
	[Address(RVA = "0x1FBEA10", Offset = "0x1FBEB11", VA = "0x1FBEA10")]
	public TCP2_GetPosOnWater()
	{
	}

	// Token: 0x0400AB44 RID: 43844
	[Token(Token = "0x400813D")]
	[FieldOffset(Offset = "0x18")]
	public Material WaterMaterial;

	// Token: 0x0400AB45 RID: 43845
	[Token(Token = "0x400813E")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x174DE0", Offset = "0x174EE1")]
	public float heightScale;

	// Token: 0x0400AB46 RID: 43846
	[Token(Token = "0x400813F")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174E20", Offset = "0x174F21")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x174E20", Offset = "0x174F21")]
	public bool followWaterHeight;

	// Token: 0x0400AB47 RID: 43847
	[Token(Token = "0x4008140")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x174E70", Offset = "0x174F71")]
	public float heightOffset;

	// Token: 0x0400AB48 RID: 43848
	[Token(Token = "0x4008141")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "SpaceAttribute", RVA = "0x174EB0", Offset = "0x174FB1")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x174EB0", Offset = "0x174FB1")]
	public bool followWaterNormal;

	// Token: 0x0400AB49 RID: 43849
	[Token(Token = "0x4008142")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x174F00", Offset = "0x175001")]
	public Vector3 upAxis;

	// Token: 0x0400AB4A RID: 43850
	[Token(Token = "0x4008143")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x174F40", Offset = "0x175041")]
	public Vector3 postRotation;

	// Token: 0x0400AB4B RID: 43851
	[Token(Token = "0x4008144")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x174F80", Offset = "0x175081")]
	private bool isValid;

	// Token: 0x0400AB4C RID: 43852
	[Token(Token = "0x4008145")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Attribute(Name = "HideInInspector", RVA = "0x174FC0", Offset = "0x1750C1")]
	private int sineCount;

	// Token: 0x0400AB4D RID: 43853
	[Token(Token = "0x4008146")]
	[FieldOffset(Offset = "0x50")]
	private float[] sinePosOffsetsX;

	// Token: 0x0400AB4E RID: 43854
	[Token(Token = "0x4008147")]
	[FieldOffset(Offset = "0x58")]
	private float[] sinePosOffsetsZ;

	// Token: 0x0400AB4F RID: 43855
	[Token(Token = "0x4008148")]
	[FieldOffset(Offset = "0x60")]
	private float[] sinePhsOffsetsX;

	// Token: 0x0400AB50 RID: 43856
	[Token(Token = "0x4008149")]
	[FieldOffset(Offset = "0x68")]
	private float[] sinePhsOffsetsZ;
}

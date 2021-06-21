using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009EF RID: 2543
[Token(Token = "0x20006AA")]
public class MiniMapShaderController : MonoBehaviour
{
	// Token: 0x060042B7 RID: 17079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037CC")]
	[Address(RVA = "0x22F5A30", Offset = "0x22F5B31", VA = "0x22F5A30")]
	private void Awake()
	{
	}

	// Token: 0x060042B8 RID: 17080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037CD")]
	[Address(RVA = "0x22F5E30", Offset = "0x22F5F31", VA = "0x22F5E30")]
	private void Update()
	{
	}

	// Token: 0x060042B9 RID: 17081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037CE")]
	[Address(RVA = "0x22F5E40", Offset = "0x22F5F41", VA = "0x22F5E40")]
	private void OnDestroy()
	{
	}

	// Token: 0x060042BA RID: 17082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037CF")]
	[Address(RVA = "0x22F5EC0", Offset = "0x22F5FC1", VA = "0x22F5EC0")]
	private void setMapPos(Vector3 plyPos)
	{
	}

	// Token: 0x060042BB RID: 17083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037D0")]
	[Address(RVA = "0x22F6180", Offset = "0x22F6281", VA = "0x22F6180")]
	private void setScale(float scale)
	{
	}

	// Token: 0x060042BC RID: 17084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037D1")]
	[Address(RVA = "0x22F5D70", Offset = "0x22F5E71", VA = "0x22F5D70")]
	private void createTextureMask(byte[] masklist)
	{
	}

	// Token: 0x060042BD RID: 17085 RVA: 0x00016698 File Offset: 0x00014898
	[Token(Token = "0x60037D2")]
	[Address(RVA = "0x22F6240", Offset = "0x22F6341", VA = "0x22F6240")]
	private float getScale(int type)
	{
		return 0f;
	}

	// Token: 0x060042BE RID: 17086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037D3")]
	[Address(RVA = "0x22F5CA0", Offset = "0x22F5DA1", VA = "0x22F5CA0")]
	public void updateMap(int scaleType, Vector3 pos)
	{
	}

	// Token: 0x060042BF RID: 17087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037D4")]
	[Address(RVA = "0x22F6280", Offset = "0x22F6381", VA = "0x22F6280")]
	public void updateMapPos(Vector3 pos)
	{
	}

	// Token: 0x060042C0 RID: 17088 RVA: 0x000166B0 File Offset: 0x000148B0
	[Token(Token = "0x60037D5")]
	[Address(RVA = "0x22F6360", Offset = "0x22F6461", VA = "0x22F6360")]
	public Vector3 getIconMapPos(Vector3 pos, Vector3 plyPos)
	{
		return default(Vector3);
	}

	// Token: 0x060042C1 RID: 17089 RVA: 0x000166C8 File Offset: 0x000148C8
	[Token(Token = "0x60037D6")]
	[Address(RVA = "0x22F65D0", Offset = "0x22F66D1", VA = "0x22F65D0")]
	public bool IsRoom()
	{
		return default(bool);
	}

	// Token: 0x060042C2 RID: 17090 RVA: 0x000166E0 File Offset: 0x000148E0
	[Token(Token = "0x60037D7")]
	[Address(RVA = "0x22F65E0", Offset = "0x22F66E1", VA = "0x22F65E0")]
	public Vector3 getPlayerPos()
	{
		return default(Vector3);
	}

	// Token: 0x060042C3 RID: 17091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037D8")]
	[Address(RVA = "0x22F65F0", Offset = "0x22F66F1", VA = "0x22F65F0")]
	public void setMaskImage(Sprite spr)
	{
	}

	// Token: 0x060042C4 RID: 17092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037D9")]
	[Address(RVA = "0x22F6670", Offset = "0x22F6771", VA = "0x22F6670")]
	public MiniMapShaderController()
	{
	}

	// Token: 0x0400A163 RID: 41315
	[Token(Token = "0x40079D7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform MapRect;

	// Token: 0x0400A164 RID: 41316
	[Token(Token = "0x40079D8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image image;

	// Token: 0x0400A165 RID: 41317
	[Token(Token = "0x40079D9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FieldSize;

	// Token: 0x0400A166 RID: 41318
	[Token(Token = "0x40079DA")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float MapSize;

	// Token: 0x0400A167 RID: 41319
	[Token(Token = "0x40079DB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 OriginPos;

	// Token: 0x0400A168 RID: 41320
	[Token(Token = "0x40079DC")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 MapOffset;

	// Token: 0x0400A169 RID: 41321
	[Token(Token = "0x40079DD")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool inRoom;

	// Token: 0x0400A16A RID: 41322
	[Token(Token = "0x40079DE")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector3 MapOffset2F;

	// Token: 0x0400A16B RID: 41323
	[Token(Token = "0x40079DF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float Map2FY;

	// Token: 0x0400A16C RID: 41324
	[Token(Token = "0x40079E0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float[] MapScaleSize;

	// Token: 0x0400A16D RID: 41325
	[Token(Token = "0x40079E1")]
	[FieldOffset(Offset = "0x68")]
	private Material material;

	// Token: 0x0400A16E RID: 41326
	[Token(Token = "0x40079E2")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 PlayerPos;

	// Token: 0x0400A16F RID: 41327
	[Token(Token = "0x40079E3")]
	[FieldOffset(Offset = "0x7C")]
	private float oldScale;

	// Token: 0x0400A170 RID: 41328
	[Token(Token = "0x40079E4")]
	[FieldOffset(Offset = "0x80")]
	private Texture2D texMask;

	// Token: 0x0400A171 RID: 41329
	[Token(Token = "0x40079E5")]
	[FieldOffset(Offset = "0x88")]
	private byte[] buffMask;

	// Token: 0x0400A172 RID: 41330
	[Token(Token = "0x40079E6")]
	[FieldOffset(Offset = "0x90")]
	private Vector2[] MapRectTbl;
}

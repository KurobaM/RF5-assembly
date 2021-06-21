using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009EE RID: 2542
[Token(Token = "0x20006A9")]
public class MapShaderController : MonoBehaviour
{
	// Token: 0x060042AB RID: 17067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037C0")]
	[Address(RVA = "0x1F234C0", Offset = "0x1F235C1", VA = "0x1F234C0")]
	private void Start()
	{
	}

	// Token: 0x060042AC RID: 17068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037C1")]
	[Address(RVA = "0x1F23720", Offset = "0x1F23821", VA = "0x1F23720")]
	private void Update()
	{
	}

	// Token: 0x060042AD RID: 17069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037C2")]
	[Address(RVA = "0x1F23730", Offset = "0x1F23831", VA = "0x1F23730")]
	private void OnDestroy()
	{
	}

	// Token: 0x060042AE RID: 17070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037C3")]
	[Address(RVA = "0x1F237B0", Offset = "0x1F238B1", VA = "0x1F237B0")]
	private void setScale(float scale)
	{
	}

	// Token: 0x060042AF RID: 17071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037C4")]
	[Address(RVA = "0x1F23830", Offset = "0x1F23931", VA = "0x1F23830")]
	private void createTextureMask(byte[] masklist)
	{
	}

	// Token: 0x060042B0 RID: 17072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037C5")]
	[Address(RVA = "0x1F23680", Offset = "0x1F23781", VA = "0x1F23680")]
	public void updateMap(Vector3 pos)
	{
	}

	// Token: 0x060042B1 RID: 17073 RVA: 0x00016620 File Offset: 0x00014820
	[Token(Token = "0x60037C6")]
	[Address(RVA = "0x1F1EFD0", Offset = "0x1F1F0D1", VA = "0x1F1EFD0")]
	public Vector3 getIconMapPos(Vector3 pos)
	{
		return default(Vector3);
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x00016638 File Offset: 0x00014838
	[Token(Token = "0x60037C7")]
	[Address(RVA = "0x1F23910", Offset = "0x1F23A11", VA = "0x1F23910")]
	public float getMapSize()
	{
		return 0f;
	}

	// Token: 0x060042B3 RID: 17075 RVA: 0x00016650 File Offset: 0x00014850
	[Token(Token = "0x60037C8")]
	[Address(RVA = "0x1F23920", Offset = "0x1F23A21", VA = "0x1F23920")]
	public float getFieldSize()
	{
		return 0f;
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x00016668 File Offset: 0x00014868
	[Token(Token = "0x60037C9")]
	[Address(RVA = "0x1F23930", Offset = "0x1F23A31", VA = "0x1F23930")]
	public bool IsRoom()
	{
		return default(bool);
	}

	// Token: 0x060042B5 RID: 17077 RVA: 0x00016680 File Offset: 0x00014880
	[Token(Token = "0x60037CA")]
	[Address(RVA = "0x1F20F20", Offset = "0x1F21021", VA = "0x1F20F20")]
	public float getMapScale(int no)
	{
		return 0f;
	}

	// Token: 0x060042B6 RID: 17078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037CB")]
	[Address(RVA = "0x1F23940", Offset = "0x1F23A41", VA = "0x1F23940")]
	public MapShaderController()
	{
	}

	// Token: 0x0400A155 RID: 41301
	[Token(Token = "0x40079C9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform MapRect;

	// Token: 0x0400A156 RID: 41302
	[Token(Token = "0x40079CA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image image;

	// Token: 0x0400A157 RID: 41303
	[Token(Token = "0x40079CB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float MapSize;

	// Token: 0x0400A158 RID: 41304
	[Token(Token = "0x40079CC")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float FieldSize;

	// Token: 0x0400A159 RID: 41305
	[Token(Token = "0x40079CD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 OriginPos;

	// Token: 0x0400A15A RID: 41306
	[Token(Token = "0x40079CE")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private bool inRoom;

	// Token: 0x0400A15B RID: 41307
	[Token(Token = "0x40079CF")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float[] MapScaleSize;

	// Token: 0x0400A15C RID: 41308
	[Token(Token = "0x40079D0")]
	[FieldOffset(Offset = "0x48")]
	private Material material;

	// Token: 0x0400A15D RID: 41309
	[Token(Token = "0x40079D1")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 PlayerPos;

	// Token: 0x0400A15E RID: 41310
	[Token(Token = "0x40079D2")]
	[FieldOffset(Offset = "0x5C")]
	private float oldScale;

	// Token: 0x0400A15F RID: 41311
	[Token(Token = "0x40079D3")]
	[FieldOffset(Offset = "0x60")]
	private Texture2D texMask;

	// Token: 0x0400A160 RID: 41312
	[Token(Token = "0x40079D4")]
	[FieldOffset(Offset = "0x68")]
	private byte[] buffMask;

	// Token: 0x0400A161 RID: 41313
	[Token(Token = "0x40079D5")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 MapSizeRect;

	// Token: 0x0400A162 RID: 41314
	[Token(Token = "0x40079D6")]
	[FieldOffset(Offset = "0x78")]
	private float MapScale;
}

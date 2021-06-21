using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009ED RID: 2541
[Token(Token = "0x20006A8")]
public class FesMiniMapShaderController : MonoBehaviour
{
	// Token: 0x0600429E RID: 17054 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B3")]
	[Address(RVA = "0x21B1680", Offset = "0x21B1781", VA = "0x21B1680")]
	private void Start()
	{
	}

	// Token: 0x0600429F RID: 17055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B4")]
	[Address(RVA = "0x21B19A0", Offset = "0x21B1AA1", VA = "0x21B19A0")]
	private void Update()
	{
	}

	// Token: 0x060042A0 RID: 17056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B5")]
	[Address(RVA = "0x21B19B0", Offset = "0x21B1AB1", VA = "0x21B19B0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060042A1 RID: 17057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B6")]
	[Address(RVA = "0x21B1880", Offset = "0x21B1981", VA = "0x21B1880")]
	public void updateMap(int scaleType, Vector3 pos)
	{
	}

	// Token: 0x060042A2 RID: 17058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B7")]
	[Address(RVA = "0x21B1C50", Offset = "0x21B1D51", VA = "0x21B1C50")]
	public void updateMapPos(Vector3 pos)
	{
	}

	// Token: 0x060042A3 RID: 17059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B8")]
	[Address(RVA = "0x21B1AB0", Offset = "0x21B1BB1", VA = "0x21B1AB0")]
	private void setMapPos(Vector3 plyPos)
	{
	}

	// Token: 0x060042A4 RID: 17060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037B9")]
	[Address(RVA = "0x21B1A30", Offset = "0x21B1B31", VA = "0x21B1A30")]
	private void setScale(float scale)
	{
	}

	// Token: 0x060042A5 RID: 17061 RVA: 0x000165D8 File Offset: 0x000147D8
	[Token(Token = "0x60037BA")]
	[Address(RVA = "0x21B1D30", Offset = "0x21B1E31", VA = "0x21B1D30")]
	public Vector3 getIconMapPos(Vector3 pos, Vector3 plyPos)
	{
		return default(Vector3);
	}

	// Token: 0x060042A6 RID: 17062 RVA: 0x000165F0 File Offset: 0x000147F0
	[Token(Token = "0x60037BB")]
	[Address(RVA = "0x21B1E50", Offset = "0x21B1F51", VA = "0x21B1E50")]
	public bool IsRoom()
	{
		return default(bool);
	}

	// Token: 0x060042A7 RID: 17063 RVA: 0x00016608 File Offset: 0x00014808
	[Token(Token = "0x60037BC")]
	[Address(RVA = "0x21B1E60", Offset = "0x21B1F61", VA = "0x21B1E60")]
	public Vector3 getPlayerPos()
	{
		return default(Vector3);
	}

	// Token: 0x060042A8 RID: 17064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037BD")]
	[Address(RVA = "0x21B1E70", Offset = "0x21B1F71", VA = "0x21B1E70")]
	public void setMaskImage(Sprite spr)
	{
	}

	// Token: 0x060042A9 RID: 17065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037BE")]
	[Address(RVA = "0x21B1EF0", Offset = "0x21B1FF1", VA = "0x21B1EF0")]
	public void setNormalScale()
	{
	}

	// Token: 0x060042AA RID: 17066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60037BF")]
	[Address(RVA = "0x21B1F70", Offset = "0x21B2071", VA = "0x21B1F70")]
	public FesMiniMapShaderController()
	{
	}

	// Token: 0x0400A144 RID: 41284
	[Token(Token = "0x40079B8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform MapRect;

	// Token: 0x0400A145 RID: 41285
	[Token(Token = "0x40079B9")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image image;

	// Token: 0x0400A146 RID: 41286
	[Token(Token = "0x40079BA")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float FieldSize;

	// Token: 0x0400A147 RID: 41287
	[Token(Token = "0x40079BB")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float MapSize;

	// Token: 0x0400A148 RID: 41288
	[Token(Token = "0x40079BC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 OriginPos;

	// Token: 0x0400A149 RID: 41289
	[Token(Token = "0x40079BD")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector3 MapOffset;

	// Token: 0x0400A14A RID: 41290
	[Token(Token = "0x40079BE")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private bool inRoom;

	// Token: 0x0400A14B RID: 41291
	[Token(Token = "0x40079BF")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private Vector3 MapOffset2F;

	// Token: 0x0400A14C RID: 41292
	[Token(Token = "0x40079C0")]
	[FieldOffset(Offset = "0x58")]
	private Material material;

	// Token: 0x0400A14D RID: 41293
	[Token(Token = "0x40079C1")]
	[FieldOffset(Offset = "0x60")]
	private FesMinimapControl fesMinimapCntl;

	// Token: 0x0400A14E RID: 41294
	[Token(Token = "0x40079C2")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 PlayerPos;

	// Token: 0x0400A14F RID: 41295
	[Token(Token = "0x40079C3")]
	[FieldOffset(Offset = "0x74")]
	private float oldScale;

	// Token: 0x0400A150 RID: 41296
	[Token(Token = "0x40079C4")]
	[FieldOffset(Offset = "0x78")]
	private Texture2D texMask;

	// Token: 0x0400A151 RID: 41297
	[Token(Token = "0x40079C5")]
	[FieldOffset(Offset = "0x80")]
	private byte[] buffMask;

	// Token: 0x0400A152 RID: 41298
	[Token(Token = "0x40079C6")]
	[FieldOffset(Offset = "0x88")]
	private Vector2[] MapRectTbl;

	// Token: 0x0400A153 RID: 41299
	[Token(Token = "0x40079C7")]
	[FieldOffset(Offset = "0x90")]
	private float[] FesMapScale;

	// Token: 0x0400A154 RID: 41300
	[Token(Token = "0x40079C8")]
	[FieldOffset(Offset = "0x98")]
	private float NormalMapScale;
}

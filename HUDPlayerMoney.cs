using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009BB RID: 2491
[Token(Token = "0x2000686")]
public class HUDPlayerMoney : MonoBehaviour
{
	// Token: 0x06004116 RID: 16662 RVA: 0x00015F78 File Offset: 0x00014178
	[Token(Token = "0x6003649")]
	[Address(RVA = "0x2059C50", Offset = "0x2059D51", VA = "0x2059C50")]
	private int GetNowNum()
	{
		return 0;
	}

	// Token: 0x06004117 RID: 16663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600364A")]
	[Address(RVA = "0x2047DF0", Offset = "0x2047EF1", VA = "0x2047DF0")]
	public void Reset()
	{
	}

	// Token: 0x06004118 RID: 16664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600364B")]
	[Address(RVA = "0x2059DC0", Offset = "0x2059EC1", VA = "0x2059DC0")]
	private void Start()
	{
	}

	// Token: 0x06004119 RID: 16665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600364C")]
	[Address(RVA = "0x2059D20", Offset = "0x2059E21", VA = "0x2059D20")]
	private void RedrawText()
	{
	}

	// Token: 0x0600411A RID: 16666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600364D")]
	[Address(RVA = "0x2059DD0", Offset = "0x2059ED1", VA = "0x2059DD0")]
	private void Update()
	{
	}

	// Token: 0x0600411B RID: 16667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600364E")]
	[Address(RVA = "0x2047DD0", Offset = "0x2047ED1", VA = "0x2047DD0")]
	public void DoDestroy()
	{
	}

	// Token: 0x0600411C RID: 16668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600364F")]
	[Address(RVA = "0x205A2E0", Offset = "0x205A3E1", VA = "0x205A2E0")]
	public void DestroySelf()
	{
	}

	// Token: 0x0600411D RID: 16669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003650")]
	[Address(RVA = "0x205A1A0", Offset = "0x205A2A1", VA = "0x205A1A0")]
	private void UpdateNum()
	{
	}

	// Token: 0x0600411E RID: 16670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003651")]
	[Address(RVA = "0x205A390", Offset = "0x205A491", VA = "0x205A390")]
	public HUDPlayerMoney()
	{
	}

	// Token: 0x04009FDB RID: 40923
	[Token(Token = "0x400788E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HUDPlayerMoney.TextType type;

	// Token: 0x04009FDC RID: 40924
	[Token(Token = "0x400788F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text Text;

	// Token: 0x04009FDD RID: 40925
	[Token(Token = "0x4007890")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text PlusTextObject;

	// Token: 0x04009FDE RID: 40926
	[Token(Token = "0x4007891")]
	[FieldOffset(Offset = "0x30")]
	public int dispNum;

	// Token: 0x04009FDF RID: 40927
	[Token(Token = "0x4007892")]
	[FieldOffset(Offset = "0x34")]
	public int targetNum;

	// Token: 0x04009FE0 RID: 40928
	[Token(Token = "0x4007893")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool CallHUDController;

	// Token: 0x04009FE1 RID: 40929
	[Token(Token = "0x4007894")]
	[FieldOffset(Offset = "0x40")]
	private string LastText;

	// Token: 0x04009FE2 RID: 40930
	[Token(Token = "0x4007895")]
	[FieldOffset(Offset = "0x48")]
	private bool DestroyAfter;

	// Token: 0x020009BC RID: 2492
	[Token(Token = "0x20012B7")]
	private enum TextType
	{
		// Token: 0x04009FE4 RID: 40932
		[Token(Token = "0x401B3B1")]
		Seed,
		// Token: 0x04009FE5 RID: 40933
		[Token(Token = "0x401B3B2")]
		Money,
		// Token: 0x04009FE6 RID: 40934
		[Token(Token = "0x401B3B3")]
		Etc
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000957 RID: 2391
[Token(Token = "0x2000645")]
public class CutInTelopControl : MonoBehaviour
{
	// Token: 0x06003F70 RID: 16240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C7")]
	[Address(RVA = "0x20EE570", Offset = "0x20EE671", VA = "0x20EE570")]
	private void CheckInit()
	{
	}

	// Token: 0x06003F71 RID: 16241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C8")]
	[Address(RVA = "0x20EE630", Offset = "0x20EE731", VA = "0x20EE630")]
	public void UseTelopOn(string textid, float lifeTime, bool PlaySE)
	{
	}

	// Token: 0x06003F72 RID: 16242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034C9")]
	[Address(RVA = "0x20EE810", Offset = "0x20EE911", VA = "0x20EE810")]
	private void SetColor()
	{
	}

	// Token: 0x06003F73 RID: 16243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034CA")]
	[Address(RVA = "0x20EE880", Offset = "0x20EE981", VA = "0x20EE880")]
	private void Update()
	{
	}

	// Token: 0x06003F74 RID: 16244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034CB")]
	[Address(RVA = "0x20EEAC0", Offset = "0x20EEBC1", VA = "0x20EEAC0")]
	public CutInTelopControl()
	{
	}

	// Token: 0x040080E2 RID: 32994
	[Token(Token = "0x4007413")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SText SText;

	// Token: 0x040080E3 RID: 32995
	[Token(Token = "0x4007414")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image TelopImage;

	// Token: 0x040080E4 RID: 32996
	[Token(Token = "0x4007415")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float MinTextWidth;

	// Token: 0x040080E5 RID: 32997
	[Token(Token = "0x4007416")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float fadeSpeed;

	// Token: 0x040080E6 RID: 32998
	[Token(Token = "0x4007417")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform rectTransform;

	// Token: 0x040080E7 RID: 32999
	[Token(Token = "0x4007418")]
	[FieldOffset(Offset = "0x38")]
	private Color borderColor;

	// Token: 0x040080E8 RID: 33000
	[Token(Token = "0x4007419")]
	[FieldOffset(Offset = "0x48")]
	private Color textColor;

	// Token: 0x040080E9 RID: 33001
	[Token(Token = "0x400741A")]
	[FieldOffset(Offset = "0x58")]
	private string TextId;

	// Token: 0x040080EA RID: 33002
	[Token(Token = "0x400741B")]
	[FieldOffset(Offset = "0x60")]
	private float LifeTime;

	// Token: 0x040080EB RID: 33003
	[Token(Token = "0x400741C")]
	[FieldOffset(Offset = "0x64")]
	private float fade;

	// Token: 0x040080EC RID: 33004
	[Token(Token = "0x400741D")]
	[FieldOffset(Offset = "0x68")]
	private bool Inited;
}

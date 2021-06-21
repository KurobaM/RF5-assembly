using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B17 RID: 2839
[Token(Token = "0x2000765")]
public class LocalizeText : MonoBehaviour
{
	// Token: 0x0600497E RID: 18814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D76")]
	[Address(RVA = "0x1F0B730", Offset = "0x1F0B831", VA = "0x1F0B730")]
	public void SetText(string str = "", SysTextGroup _textGroup = SysTextGroup.None)
	{
	}

	// Token: 0x0600497F RID: 18815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D77")]
	[Address(RVA = "0x1F0B980", Offset = "0x1F0BA81", VA = "0x1F0B980")]
	private void CheckUpdate()
	{
	}

	// Token: 0x06004980 RID: 18816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D78")]
	[Address(RVA = "0x1F0BAA0", Offset = "0x1F0BBA1", VA = "0x1F0BAA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06004981 RID: 18817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D79")]
	[Address(RVA = "0x1F0BAB0", Offset = "0x1F0BBB1", VA = "0x1F0BAB0")]
	public LocalizeText()
	{
	}

	// Token: 0x0400A947 RID: 43335
	[Token(Token = "0x4007F82")]
	[FieldOffset(Offset = "0x18")]
	private Text Text;

	// Token: 0x0400A948 RID: 43336
	[Token(Token = "0x4007F83")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string textId;

	// Token: 0x0400A949 RID: 43337
	[Token(Token = "0x4007F84")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int textPaneId;

	// Token: 0x0400A94A RID: 43338
	[Token(Token = "0x4007F85")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private SysTextGroup textGroup;

	// Token: 0x0400A94B RID: 43339
	[Token(Token = "0x4007F86")]
	[FieldOffset(Offset = "0x30")]
	private SysLang nowLanguage;
}

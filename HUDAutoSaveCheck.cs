using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000993 RID: 2451
[Token(Token = "0x200066F")]
public class HUDAutoSaveCheck : MonoBehaviour
{
	// Token: 0x0600402C RID: 16428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600357D")]
	[Address(RVA = "0x2041920", Offset = "0x2041A21", VA = "0x2041920")]
	private void Start()
	{
	}

	// Token: 0x0600402D RID: 16429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600357E")]
	[Address(RVA = "0x20419B0", Offset = "0x2041AB1", VA = "0x20419B0")]
	private void Update()
	{
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600357F")]
	[Address(RVA = "0x2041C20", Offset = "0x2041D21", VA = "0x2041C20")]
	public HUDAutoSaveCheck()
	{
	}

	// Token: 0x04009E84 RID: 40580
	[Token(Token = "0x400778B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image autoSaveImage;

	// Token: 0x04009E85 RID: 40581
	[Token(Token = "0x400778C")]
	private const float MIN_SHOW_TIME = 2f;

	// Token: 0x04009E86 RID: 40582
	[Token(Token = "0x400778D")]
	[FieldOffset(Offset = "0x20")]
	private float timeCount;

	// Token: 0x04009E87 RID: 40583
	[Token(Token = "0x400778E")]
	private const float FADE_TIME = 0.1f;

	// Token: 0x04009E88 RID: 40584
	[Token(Token = "0x400778F")]
	[FieldOffset(Offset = "0x24")]
	private float fadeSpeed;
}

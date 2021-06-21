using System;
using Il2CppDummyDll;
using RF5Subtitle;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AD7 RID: 2775
[Token(Token = "0x2000745")]
public class UISubtitleVoiceComment : MonoBehaviour
{
	// Token: 0x0600480B RID: 18443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C53")]
	[Address(RVA = "0x2122A10", Offset = "0x2122B11", VA = "0x2122A10")]
	private void Awake()
	{
	}

	// Token: 0x0600480C RID: 18444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C54")]
	[Address(RVA = "0x2122A20", Offset = "0x2122B21", VA = "0x2122A20")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600480D RID: 18445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C55")]
	[Address(RVA = "0x2122AF0", Offset = "0x2122BF1", VA = "0x2122AF0")]
	public void Setup(int id, AudioSource _audioSource, UISystemTextData _textData)
	{
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x00017760 File Offset: 0x00015960
	[Token(Token = "0x6003C56")]
	[Address(RVA = "0x2122C20", Offset = "0x2122D21", VA = "0x2122C20")]
	private int GetPlayNo(int time, int nowNo = -1)
	{
		return 0;
	}

	// Token: 0x0600480F RID: 18447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C57")]
	[Address(RVA = "0x2122CF0", Offset = "0x2122DF1", VA = "0x2122CF0")]
	private void UpdateText(int time, int nextText)
	{
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C58")]
	[Address(RVA = "0x2122EF0", Offset = "0x2122FF1", VA = "0x2122EF0")]
	private void Update()
	{
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C59")]
	[Address(RVA = "0x21230E0", Offset = "0x21231E1", VA = "0x21230E0")]
	public UISubtitleVoiceComment()
	{
	}

	// Token: 0x0400A76D RID: 42861
	[Token(Token = "0x4007E8A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x0400A76E RID: 42862
	[Token(Token = "0x4007E8B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text TextObject;

	// Token: 0x0400A76F RID: 42863
	[Token(Token = "0x4007E8C")]
	[FieldOffset(Offset = "0x28")]
	private SubtitleDataTable.DataList playList;

	// Token: 0x0400A770 RID: 42864
	[Token(Token = "0x4007E8D")]
	[FieldOffset(Offset = "0x30")]
	private UISystemTextData textData;

	// Token: 0x0400A771 RID: 42865
	[Token(Token = "0x4007E8E")]
	[FieldOffset(Offset = "0x38")]
	private AudioSource audioSource;

	// Token: 0x0400A772 RID: 42866
	[Token(Token = "0x4007E8F")]
	[FieldOffset(Offset = "0x40")]
	private float nTime;

	// Token: 0x0400A773 RID: 42867
	[Token(Token = "0x4007E90")]
	[FieldOffset(Offset = "0x44")]
	private int nowPlayNo;
}

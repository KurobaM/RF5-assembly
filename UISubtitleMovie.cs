using System;
using Il2CppDummyDll;
using RF5Subtitle;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AD5 RID: 2773
[Token(Token = "0x2000743")]
public class UISubtitleMovie : MonoBehaviour
{
	// Token: 0x06004802 RID: 18434 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C4A")]
	[Address(RVA = "0x2121FE0", Offset = "0x21220E1", VA = "0x2121FE0")]
	public void Setup(int id, AudioSource _audioSource)
	{
	}

	// Token: 0x06004803 RID: 18435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C4B")]
	[Address(RVA = "0x2122180", Offset = "0x2122281", VA = "0x2122180")]
	public void Setup(int id, MoviePlayer _moviePlayer)
	{
	}

	// Token: 0x06004804 RID: 18436 RVA: 0x00017748 File Offset: 0x00015948
	[Token(Token = "0x6003C4C")]
	[Address(RVA = "0x2122320", Offset = "0x2122421", VA = "0x2122320")]
	private int GetPlayNo(int time, int nowNo = -1)
	{
		return 0;
	}

	// Token: 0x06004805 RID: 18437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C4D")]
	[Address(RVA = "0x21223F0", Offset = "0x21224F1", VA = "0x21223F0")]
	private void UpdateText(int time, int nextText)
	{
	}

	// Token: 0x06004806 RID: 18438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C4E")]
	[Address(RVA = "0x2122690", Offset = "0x2122791", VA = "0x2122690")]
	private void Update()
	{
	}

	// Token: 0x06004807 RID: 18439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C4F")]
	[Address(RVA = "0x21228D0", Offset = "0x21229D1", VA = "0x21228D0")]
	public UISubtitleMovie()
	{
	}

	// Token: 0x0400A761 RID: 42849
	[Token(Token = "0x4007E7E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image BorderImage;

	// Token: 0x0400A762 RID: 42850
	[Token(Token = "0x4007E7F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text TextObject;

	// Token: 0x0400A763 RID: 42851
	[Token(Token = "0x4007E80")]
	[FieldOffset(Offset = "0x28")]
	private SubtitleDataTable.DataList playList;

	// Token: 0x0400A764 RID: 42852
	[Token(Token = "0x4007E81")]
	[FieldOffset(Offset = "0x30")]
	private UISystemTextData textData;

	// Token: 0x0400A765 RID: 42853
	[Token(Token = "0x4007E82")]
	[FieldOffset(Offset = "0x38")]
	private AudioSource audioSource;

	// Token: 0x0400A766 RID: 42854
	[Token(Token = "0x4007E83")]
	[FieldOffset(Offset = "0x40")]
	private MoviePlayer moviePlayer;

	// Token: 0x0400A767 RID: 42855
	[Token(Token = "0x4007E84")]
	[FieldOffset(Offset = "0x48")]
	private float nTime;

	// Token: 0x0400A768 RID: 42856
	[Token(Token = "0x4007E85")]
	[FieldOffset(Offset = "0x4C")]
	private int nowPlayNo;
}

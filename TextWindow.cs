using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020004BD RID: 1213
[Token(Token = "0x2000382")]
public class TextWindow : MonoBehaviour
{
	// Token: 0x06001DC9 RID: 7625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x205C170", Offset = "0x205C271", VA = "0x205C170")]
	public void SetDispNextIcon(bool _dispNextIcon)
	{
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x205C1B0", Offset = "0x205C2B1", VA = "0x205C1B0")]
	public void SetText(string text, int speakerNpcId = -1, string nameTextId = "")
	{
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x205C540", Offset = "0x205C641", VA = "0x205C540")]
	public void Enable(bool flag)
	{
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x205C580", Offset = "0x205C681", VA = "0x205C580")]
	private void AddStr(string t)
	{
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x205C9A0", Offset = "0x205CAA1", VA = "0x205C9A0")]
	private void AddTextToDispLength()
	{
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x205CCF0", Offset = "0x205CDF1", VA = "0x205CCF0")]
	public void TextUpdate()
	{
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C0")]
	[Address(RVA = "0x205CEA0", Offset = "0x205CFA1", VA = "0x205CEA0")]
	public void forceDisp()
	{
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x205CE80", Offset = "0x205CF81", VA = "0x205CE80")]
	public bool isUpdate()
	{
		return default(bool);
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x0000CD08 File Offset: 0x0000AF08
	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x205CF20", Offset = "0x205D021", VA = "0x205CF20")]
	public bool isMouthEnded()
	{
		return default(bool);
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x205CF30", Offset = "0x205D031", VA = "0x205CF30")]
	private void Update()
	{
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60019C4")]
	[Address(RVA = "0x205CFF0", Offset = "0x205D0F1", VA = "0x205CFF0")]
	public TextWindow()
	{
	}

	// Token: 0x04006401 RID: 25601
	[Token(Token = "0x4005EC5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float textPerSec;

	// Token: 0x04006402 RID: 25602
	[Token(Token = "0x4005EC6")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float MouthTimeDelayMax;

	// Token: 0x04006403 RID: 25603
	[Token(Token = "0x4005EC7")]
	[FieldOffset(Offset = "0x20")]
	private float MouthTimeDelayNow;

	// Token: 0x04006404 RID: 25604
	[Token(Token = "0x4005EC8")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text messageText;

	// Token: 0x04006405 RID: 25605
	[Token(Token = "0x4005EC9")]
	[FieldOffset(Offset = "0x30")]
	private string message;

	// Token: 0x04006406 RID: 25606
	[Token(Token = "0x4005ECA")]
	[FieldOffset(Offset = "0x38")]
	private int dispLength;

	// Token: 0x04006407 RID: 25607
	[Token(Token = "0x4005ECB")]
	[FieldOffset(Offset = "0x3C")]
	private int textLength;

	// Token: 0x04006408 RID: 25608
	[Token(Token = "0x4005ECC")]
	[FieldOffset(Offset = "0x40")]
	private float timeCount;

	// Token: 0x04006409 RID: 25609
	[Token(Token = "0x4005ECD")]
	[FieldOffset(Offset = "0x48")]
	private TextOverwriteList TextOverwriteList;

	// Token: 0x0400640A RID: 25610
	[Token(Token = "0x4005ECE")]
	[FieldOffset(Offset = "0x50")]
	private int addedText;

	// Token: 0x0400640B RID: 25611
	[Token(Token = "0x4005ECF")]
	[FieldOffset(Offset = "0x58")]
	private string nowText;

	// Token: 0x0400640C RID: 25612
	[Token(Token = "0x4005ED0")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private int BigSize;

	// Token: 0x0400640D RID: 25613
	[Token(Token = "0x4005ED1")]
	private const int OnPlus = 1;

	// Token: 0x0400640E RID: 25614
	[Token(Token = "0x4005ED2")]
	private const int OnSlash = 2;

	// Token: 0x0400640F RID: 25615
	[Token(Token = "0x4005ED3")]
	private const int OnBig = 3;

	// Token: 0x04006410 RID: 25616
	[Token(Token = "0x4005ED4")]
	private const int OnColor = 4;

	// Token: 0x04006411 RID: 25617
	[Token(Token = "0x4005ED5")]
	[FieldOffset(Offset = "0x68")]
	private bool[] useBigOnLine;

	// Token: 0x04006412 RID: 25618
	[Token(Token = "0x4005ED6")]
	[FieldOffset(Offset = "0x70")]
	private int onLine;

	// Token: 0x04006413 RID: 25619
	[Token(Token = "0x4005ED7")]
	[FieldOffset(Offset = "0x78")]
	private List<int> OnUsingExcptList;

	// Token: 0x04006414 RID: 25620
	[Token(Token = "0x4005ED8")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image NextIcon;

	// Token: 0x04006415 RID: 25621
	[Token(Token = "0x4005ED9")]
	[FieldOffset(Offset = "0x88")]
	private bool nextFlag;

	// Token: 0x04006416 RID: 25622
	[Token(Token = "0x4005EDA")]
	[FieldOffset(Offset = "0x89")]
	private bool dispNextIcon;

	// Token: 0x04006417 RID: 25623
	[Token(Token = "0x4005EDB")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<int, SoundID> TextSoundDic;

	// Token: 0x04006418 RID: 25624
	[Token(Token = "0x4005EDC")]
	[FieldOffset(Offset = "0x98")]
	private Dictionary<string, SoundID> TextSoundDicStr;

	// Token: 0x04006419 RID: 25625
	[Token(Token = "0x4005EDD")]
	[FieldOffset(Offset = "0xA0")]
	private SoundID playingId;
}

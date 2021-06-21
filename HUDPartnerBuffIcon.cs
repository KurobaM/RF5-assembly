using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009B8 RID: 2488
[Token(Token = "0x2000683")]
public class HUDPartnerBuffIcon : MonoBehaviour
{
	// Token: 0x06004100 RID: 16640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003633")]
	[Address(RVA = "0x2058540", Offset = "0x2058641", VA = "0x2058540")]
	private void CheckInit()
	{
	}

	// Token: 0x06004101 RID: 16641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003634")]
	[Address(RVA = "0x2058680", Offset = "0x2058781", VA = "0x2058680")]
	private void Start()
	{
	}

	// Token: 0x06004102 RID: 16642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003635")]
	[Address(RVA = "0x2043B10", Offset = "0x2043C11", VA = "0x2043B10")]
	public void Setup(CharacterStatusBase _status)
	{
	}

	// Token: 0x06004103 RID: 16643 RVA: 0x00015EE8 File Offset: 0x000140E8
	[Token(Token = "0x6003636")]
	[Address(RVA = "0x2058690", Offset = "0x2058791", VA = "0x2058690")]
	private bool CheckOnFoodBuff()
	{
		return default(bool);
	}

	// Token: 0x06004104 RID: 16644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003637")]
	[Address(RVA = "0x20587F0", Offset = "0x20588F1", VA = "0x20587F0")]
	private void SetDispFood()
	{
	}

	// Token: 0x06004105 RID: 16645 RVA: 0x00015F00 File Offset: 0x00014100
	[Token(Token = "0x6003638")]
	[Address(RVA = "0x20588E0", Offset = "0x20589E1", VA = "0x20588E0")]
	private bool CheckOnRuneBuff()
	{
		return default(bool);
	}

	// Token: 0x06004106 RID: 16646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003639")]
	[Address(RVA = "0x2058BC0", Offset = "0x2058CC1", VA = "0x2058BC0")]
	private void SetDispRuneBuff()
	{
	}

	// Token: 0x06004107 RID: 16647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600363A")]
	[Address(RVA = "0x2058D00", Offset = "0x2058E01", VA = "0x2058D00")]
	private void Update()
	{
	}

	// Token: 0x06004108 RID: 16648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600363B")]
	[Address(RVA = "0x2058D50", Offset = "0x2058E51", VA = "0x2058D50")]
	public HUDPartnerBuffIcon()
	{
	}

	// Token: 0x04009FC2 RID: 40898
	[Token(Token = "0x4007875")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image FoodIconImage;

	// Token: 0x04009FC3 RID: 40899
	[Token(Token = "0x4007876")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image RuneBuffIconImage;

	// Token: 0x04009FC4 RID: 40900
	[Token(Token = "0x4007877")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite[] RuneBuffSprites;

	// Token: 0x04009FC5 RID: 40901
	[Token(Token = "0x4007878")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve RuneBuffAnimationCurve;

	// Token: 0x04009FC6 RID: 40902
	[Token(Token = "0x4007879")]
	[FieldOffset(Offset = "0x38")]
	private bool inited;

	// Token: 0x04009FC7 RID: 40903
	[Token(Token = "0x400787A")]
	[FieldOffset(Offset = "0x39")]
	private bool foodStat;

	// Token: 0x04009FC8 RID: 40904
	[Token(Token = "0x400787B")]
	[FieldOffset(Offset = "0x3A")]
	private bool runeBuffStat;

	// Token: 0x04009FC9 RID: 40905
	[Token(Token = "0x400787C")]
	[FieldOffset(Offset = "0x40")]
	private CharacterStatusBase status;

	// Token: 0x04009FCA RID: 40906
	[Token(Token = "0x400787D")]
	[FieldOffset(Offset = "0x48")]
	private bool[] runeBuffSubStat;

	// Token: 0x04009FCB RID: 40907
	[Token(Token = "0x400787E")]
	[FieldOffset(Offset = "0x50")]
	private List<Sprite> RuneBuffSpriteList;

	// Token: 0x04009FCC RID: 40908
	[Token(Token = "0x400787F")]
	[FieldOffset(Offset = "0x58")]
	private float runeBuffChangeTime;

	// Token: 0x04009FCD RID: 40909
	[Token(Token = "0x4007880")]
	[FieldOffset(Offset = "0x5C")]
	private int nowRuneBuffSpriteNo;
}

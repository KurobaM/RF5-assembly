using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x020007E2 RID: 2018
[Token(Token = "0x200053A")]
public class ChildSaveData
{
	// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BEA")]
	[Address(RVA = "0x1E9F250", Offset = "0x1E9F351", VA = "0x1E9F250")]
	public ChildSaveData()
	{
	}

	// Token: 0x060034C9 RID: 13513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BEB")]
	[Address(RVA = "0x1E9F280", Offset = "0x1E9F381", VA = "0x1E9F280")]
	public void Initialize()
	{
	}

	// Token: 0x060034CA RID: 13514 RVA: 0x00011F88 File Offset: 0x00010188
	[Token(Token = "0x6002BEC")]
	[Address(RVA = "0x1E9F480", Offset = "0x1E9F581", VA = "0x1E9F480")]
	public int GetChildDataCount()
	{
		return 0;
	}

	// Token: 0x060034CB RID: 13515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x1E9F4D0", Offset = "0x1E9F5D1", VA = "0x1E9F4D0")]
	public ChildData GetChildData(int npcid)
	{
		return null;
	}

	// Token: 0x060034CC RID: 13516 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x1E9F660", Offset = "0x1E9F761", VA = "0x1E9F660")]
	public ChildData GetChildData(ActorID actorId)
	{
		return null;
	}

	// Token: 0x060034CD RID: 13517 RVA: 0x00011FA0 File Offset: 0x000101A0
	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x1E9F7F0", Offset = "0x1E9F8F1", VA = "0x1E9F7F0")]
	private int GetChildId(int npcId)
	{
		return 0;
	}

	// Token: 0x060034CE RID: 13518 RVA: 0x00011FB8 File Offset: 0x000101B8
	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x1E9F810", Offset = "0x1E9F911", VA = "0x1E9F810")]
	public int GetChildNum()
	{
		return 0;
	}

	// Token: 0x060034CF RID: 13519 RVA: 0x00011FD0 File Offset: 0x000101D0
	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x1E9F920", Offset = "0x1E9FA21", VA = "0x1E9F920")]
	public bool IsChildBirthDay(int npcId)
	{
		return default(bool);
	}

	// Token: 0x060034D0 RID: 13520 RVA: 0x00011FE8 File Offset: 0x000101E8
	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x1E9FAA0", Offset = "0x1E9FBA1", VA = "0x1E9FAA0")]
	public bool IsChild1Born()
	{
		return default(bool);
	}

	// Token: 0x060034D1 RID: 13521 RVA: 0x00012000 File Offset: 0x00010200
	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x1E9FAD0", Offset = "0x1E9FBD1", VA = "0x1E9FAD0")]
	public bool IsChild23Born()
	{
		return default(bool);
	}

	// Token: 0x060034D2 RID: 13522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x1E9FB00", Offset = "0x1E9FC01", VA = "0x1E9FB00")]
	public void Child1Birth()
	{
	}

	// Token: 0x060034D3 RID: 13523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x1E9FFB0", Offset = "0x1EA00B1", VA = "0x1E9FFB0")]
	public void Child23Birth()
	{
	}

	// Token: 0x060034D4 RID: 13524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x1E9FB40", Offset = "0x1E9FC41", VA = "0x1E9FB40")]
	private void BabyBirth(int npcid)
	{
	}

	// Token: 0x060034D5 RID: 13525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x1EA0000", Offset = "0x1EA0101", VA = "0x1EA0000")]
	private void BabyAddVoice(int npcid, int personality)
	{
	}

	// Token: 0x04007872 RID: 30834
	[Token(Token = "0x4006D58")]
	[FieldOffset(Offset = "0x10")]
	private List<ChildData> _childDatas;
}

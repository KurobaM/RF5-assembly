using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200027F RID: 639
[Token(Token = "0x20001FA")]
public class GrantAttributeManager : SingletonMonoBehaviour<GrantAttributeManager>
{
	// Token: 0x06001000 RID: 4096 RVA: 0x000073F8 File Offset: 0x000055F8
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x1FF4FB0", Offset = "0x1FF50B1", VA = "0x1FF4FB0")]
	public bool Regist(Character chara, GrantAttributeController controller)
	{
		return default(bool);
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x00007410 File Offset: 0x00005610
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x1FF5020", Offset = "0x1FF5121", VA = "0x1FF5020")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06001002 RID: 4098 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E73")]
	[Address(RVA = "0x1FF5090", Offset = "0x1FF5191", VA = "0x1FF5090")]
	public GrantAttributeController Get(Character chara)
	{
		return null;
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x1FF5140", Offset = "0x1FF5241", VA = "0x1FF5140")]
	private void Update()
	{
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x00007428 File Offset: 0x00005628
	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x1FF5260", Offset = "0x1FF5361", VA = "0x1FF5260")]
	public bool DoSet(Character chara, AttackAttribute attribute, float duraion = 2f)
	{
		return default(bool);
	}

	// Token: 0x06001005 RID: 4101 RVA: 0x00007440 File Offset: 0x00005640
	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x1FF53B0", Offset = "0x1FF54B1", VA = "0x1FF53B0")]
	public bool DoAdd(Character chara)
	{
		return default(bool);
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x1FF54D0", Offset = "0x1FF55D1", VA = "0x1FF54D0")]
	public void DoRemove(Character chara, AttackAttribute attribute)
	{
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x1FF5600", Offset = "0x1FF5701", VA = "0x1FF5600")]
	public void DoClear(Character chara)
	{
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x00007458 File Offset: 0x00005658
	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x1FF5720", Offset = "0x1FF5821", VA = "0x1FF5720")]
	public AttackAttribute GetAttribute(Character chara)
	{
		return (AttackAttribute)0;
	}

	// Token: 0x06001009 RID: 4105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x1FF5840", Offset = "0x1FF5941", VA = "0x1FF5840")]
	public GrantAttributeManager()
	{
	}

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400072B")]
	protected const float DefaultDuration = 2f;

	// Token: 0x0400091E RID: 2334
	[Token(Token = "0x400072C")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, GrantAttributeController> m_Register;
}

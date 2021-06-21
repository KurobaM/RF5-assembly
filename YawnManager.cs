using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000292 RID: 658
[Token(Token = "0x200020B")]
[Serializable]
public class YawnManager : SingletonMonoBehaviour<YawnManager>
{
	// Token: 0x060010EB RID: 4331 RVA: 0x00007CC8 File Offset: 0x00005EC8
	[Token(Token = "0x6000F5C")]
	[Address(RVA = "0x284EA20", Offset = "0x284EB21", VA = "0x284EA20")]
	public bool Regist(Character chara, YawnController controller)
	{
		return default(bool);
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00007CE0 File Offset: 0x00005EE0
	[Token(Token = "0x6000F5D")]
	[Address(RVA = "0x284EA90", Offset = "0x284EB91", VA = "0x284EA90")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F5E")]
	[Address(RVA = "0x284EB00", Offset = "0x284EC01", VA = "0x284EB00")]
	public YawnController Get(Character chara)
	{
		return null;
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x284EBB0", Offset = "0x284ECB1", VA = "0x284EBB0")]
	private void Start()
	{
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x284ED20", Offset = "0x284EE21", VA = "0x284ED20")]
	private void Update()
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x284F1C0", Offset = "0x284F2C1", VA = "0x284F1C0")]
	private void OnDayCarry(int days)
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x284F220", Offset = "0x284F321", VA = "0x284F220")]
	private void OnHourCarry(int hours)
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x284F2C0", Offset = "0x284F3C1", VA = "0x284F2C0")]
	public void DoPlayAll(float duration)
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00007CF8 File Offset: 0x00005EF8
	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x284F090", Offset = "0x284F191", VA = "0x284F090")]
	public bool DoPlay(Character chara, float duration)
	{
		return default(bool);
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00007D10 File Offset: 0x00005F10
	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x284F480", Offset = "0x284F581", VA = "0x284F480")]
	public bool DoStop(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x284F5C0", Offset = "0x284F6C1", VA = "0x284F5C0")]
	public void DoStopAll()
	{
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x284F700", Offset = "0x284F801", VA = "0x284F700")]
	public YawnManager()
	{
	}

	// Token: 0x04000978 RID: 2424
	[Token(Token = "0x4000777")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, YawnController> m_Register;

	// Token: 0x04000979 RID: 2425
	[Token(Token = "0x4000778")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<Character, float> m_PlayOrder;

	// Token: 0x0400097A RID: 2426
	[Token(Token = "0x4000779")]
	[FieldOffset(Offset = "0x28")]
	private List<Character> m_DeleteList;
}

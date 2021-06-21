using System;
using Il2CppDummyDll;

// Token: 0x02000284 RID: 644
[Token(Token = "0x20001FF")]
public class MobManager : SingletonMonoBehaviour<MobManager>
{
	// Token: 0x06001049 RID: 4169 RVA: 0x00007788 File Offset: 0x00005988
	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x1D78850", Offset = "0x1D78951", VA = "0x1D78850")]
	public bool Regist(MobController controller)
	{
		return default(bool);
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x000077A0 File Offset: 0x000059A0
	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x1D789C0", Offset = "0x1D78AC1", VA = "0x1D789C0")]
	public bool Remove(MobController controller)
	{
		return default(bool);
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x1D7A130", Offset = "0x1D7A231", VA = "0x1D7A130")]
	private void Update()
	{
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x1D7A980", Offset = "0x1D7AA81", VA = "0x1D7A980")]
	public void Init()
	{
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x1D7AA90", Offset = "0x1D7AB91", VA = "0x1D7AA90")]
	public void OnDayCarry(int days)
	{
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x1D7AB80", Offset = "0x1D7AC81", VA = "0x1D7AB80")]
	public MobManager()
	{
	}

	// Token: 0x0400092D RID: 2349
	[Token(Token = "0x400073B")]
	[FieldOffset(Offset = "0x18")]
	private Register<MobController> m_Register;
}

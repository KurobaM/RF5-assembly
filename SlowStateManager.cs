using System;
using Il2CppDummyDll;

// Token: 0x0200028E RID: 654
[Token(Token = "0x2000207")]
public class SlowStateManager : SingletonMonoBehaviour<SlowStateManager>
{
	// Token: 0x060010CB RID: 4299 RVA: 0x00007B30 File Offset: 0x00005D30
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x2252700", Offset = "0x2252801", VA = "0x2252700")]
	public bool Regist(CharacterBase chara, SlowStateController controller)
	{
		return default(bool);
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00007B48 File Offset: 0x00005D48
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x2252770", Offset = "0x2252871", VA = "0x2252770")]
	public bool Remove(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x22527E0", Offset = "0x22528E1", VA = "0x22527E0")]
	public SlowStateController Get(CharacterBase chara)
	{
		return null;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00007B60 File Offset: 0x00005D60
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x2252890", Offset = "0x2252991", VA = "0x2252890")]
	public bool IsSlow(CharacterBase chara)
	{
		return default(bool);
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x22529B0", Offset = "0x2252AB1", VA = "0x22529B0")]
	public void DoSlow(CharacterBase chara)
	{
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x2252AD0", Offset = "0x2252BD1", VA = "0x2252AD0")]
	private void Update()
	{
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x2252BF0", Offset = "0x2252CF1", VA = "0x2252BF0")]
	public SlowStateManager()
	{
	}

	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x18")]
	private Register<CharacterBase, SlowStateController> m_Register;
}

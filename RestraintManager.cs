using System;
using Il2CppDummyDll;

// Token: 0x0200028B RID: 651
[Token(Token = "0x2000205")]
public class RestraintManager : SingletonMonoBehaviour<RestraintManager>
{
	// Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x248D570", Offset = "0x248D671", VA = "0x248D570")]
	private void Update()
	{
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00007AB8 File Offset: 0x00005CB8
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x248D690", Offset = "0x248D791", VA = "0x248D690")]
	public bool Regist(Character chara, RestraintController controller)
	{
		return default(bool);
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00007AD0 File Offset: 0x00005CD0
	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x248D700", Offset = "0x248D801", VA = "0x248D700")]
	public bool Remove(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x248D770", Offset = "0x248D871", VA = "0x248D770")]
	public RestraintController Get(Character chara)
	{
		return null;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x00007AE8 File Offset: 0x00005CE8
	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x248D820", Offset = "0x248D921", VA = "0x248D820")]
	public bool IsRestraint(Character chara)
	{
		return default(bool);
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x248D940", Offset = "0x248DA41", VA = "0x248D940")]
	public void OnRestraint(Character chara)
	{
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x248DA60", Offset = "0x248DB61", VA = "0x248DA60")]
	public RestraintManager()
	{
	}

	// Token: 0x0400095F RID: 2399
	[Token(Token = "0x4000767")]
	[FieldOffset(Offset = "0x18")]
	private Register<Character, RestraintController> m_Register;
}
